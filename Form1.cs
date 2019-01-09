using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace EQManager
{
    public delegate void ShowHistoryData(string managementNumber);
    public delegate void InsertHistoryData(string[] datalist);
    public delegate void EditData(string[] datalist);
    public delegate void DeleteData(string strManageNum);

    public partial class Form1 : Form
    {
        DBConnect dbConn;
        public Form1()
        {
            InitializeComponent();

            Init();
            InitFilter();
            //
        }

        private void Init()
        {
            dbConn = new DBConnect();

            this.detailEquipment.HistoryData = new ShowHistoryData(this.SetEquipmentHistory);
            this.detailEquipment.editEquipmentData = new EditData(this.EditEquipmentData);
            this.detailEquipment.delEquipmentData = new DeleteData(this.DeleteEquipmentData);
            this.comboCondition.SelectedIndex = 0;
        }
        private void InitFilter()
        {
            // init model list view
            List<string[]> resultlist = dbConn.GetModelList(0); // 0 - workstation
            this.lvModel.Items.Add(new ListViewItem("All"));    // default list view item.            
            foreach (string[] ModelList in resultlist)
            {
                this.lvModel.Items.Add(new ListViewItem(ModelList[0], ModelList[1]));
            }

            // board
            resultlist = dbConn.GetModelList(1); // 1 - matroxboard
            this.lvBoard.Items.Add(new ListViewItem("All")); // default list view item.
            foreach (string[] ModelList in resultlist)
            {
                this.lvBoard.Items.Add(new ListViewItem(ModelList[0], ModelList[1]));
            }

            // user
            //resultlist = dbConn.GetUserList();
            //this.lvUser.Items.Add(new ListViewItem("All"));
            //foreach(string[] UserList in resultlist)
            //{
            //    this.lvUser.Items.Add(new ListViewItem(UserList[0], UserList[1]));
            //}
            resultlist = dbConn.GetUserList();
            this.comboUser.Items.Add("All");
            foreach(string[] UserList in resultlist)
            {
                this.comboUser.Items.Add(UserList[0]);
            }
        }
        
        private void lvModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvModel.SelectedItems.Count > 0)
            {
                ListViewItem item = this.lvModel.SelectedItems[0];
                //if(item.ImageKey =="1")
                //{
                //    List<string[]> resultlist = dbConn.GetBoardDetails(item.Text);
                //    this.detailEquipment.SetEquipmentData(resultlist);
                //}
                //else
                //{
                    List<string[]> resultlist = dbConn.GetEquipmentDetails(item.Text);
                    this.detailEquipment.SetEquipmentData(resultlist);
                    this.tabViewDetail.SelectedIndex = 0;
                //}
                
            }
        }


        private void EditEquipmentData(string[] datalist)
        {
            EditDataForm edfrm = new EditDataForm(datalist);
            //edfrm.SetFormData(datalist);
            if (DialogResult.OK == edfrm.ShowDialog())
            {
                string strSETQuery = "";
                foreach(KeyValuePair<string, string> aData in edfrm.ModifiedData)
                {
                    if (strSETQuery != "") strSETQuery += ", ";
                    strSETQuery += string.Format("{0}='{1}'", aData.Key, aData.Value);
                }
                dbConn.InsertEquipmentHistoryData(datalist , DateTime.Now);
                if (dbConn.UpdateEquipmentData(edfrm.ModifiedData, datalist[2]))
                    UpdateDataGridView();
            }

        }

        private void UpdateDataGridView()
        {
            if (this.lvModel.SelectedItems.Count > 0)
            {
                ListViewItem item = this.lvModel.SelectedItems[0];
                List<string[]> resultlist = dbConn.GetEquipmentDetails(item.Text);
                this.detailEquipment.SetEquipmentData(resultlist);
            }
        }

        private void DeleteEquipmentData(string strManageNum)
        {
            if (dbConn.DeleteEquipmentData(strManageNum))
                UpdateDataGridView();

        }
        private void SetEquipmentHistory(string strManageNum)
        {
            List<string[]> resultlist = dbConn.GetEquipmentHistory(strManageNum);
            DetailView historyView = new DetailView();
            historyView.ViewType = ViewType.History;
            //historyView.InsertColumn("date",0);

            historyView.SetEquipmentHistoryData(resultlist);

            Form historyForm = new Form();
            historyForm.Controls.Add(historyView);
            historyForm.AutoSize = true;
            historyForm.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            historyForm.Show();
        }

        //private void SetBoardHistory(string strManageNum)
        //{
        //    //List<string[]> resultlist = dbConn.GetBoardHistory(strManageNum);
        //    DetailView historyView = new DetailView();

        //    historyView.InsertColumn("date", 0);

        //    historyView.SetEquipmentHistoryData(resultlist);

        //    Form historyForm = new Form();
        //    historyForm.Controls.Add(historyView);
        //    historyForm.AutoSize = true;
        //    historyForm.AutoSizeMode = AutoSizeMode.GrowAndShrink;

        //    historyForm.Show();
        //}

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strCondition = "";

            if(this.cbSystem.Checked)
            {
                strCondition += "systemName";
            }
            if(this.cbManageNum.Checked)
            {
                if (strCondition != "") strCondition += ",";
                strCondition += "ManageNum";
            }
            if(this.cbBoardType.Checked)
            {
                if (strCondition != "") strCondition += ",";
                strCondition += "MatroxBoard";
            }
            if(strCondition == "")
            {
                return;
            }
            else
            {
                string query = string.Format("WHERE CONCAT({0}) REGEXP '{1}'", strCondition, this.tbSearchWord.Text);
                List<string[]> resultlist= dbConn.GetEquipmentDetailsConditions(query);

                this.detailEquipment.SetEquipmentData(resultlist);
            }
            
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool rst = true;
            AddDataForm frmAdd = new AddDataForm();
            if(DialogResult.OK == frmAdd.ShowDialog())
            {
                List<string[]> newdata = frmAdd.GetNewEquipmentData();
                rst = this.dbConn.InsertEquipmentData(newdata);
            }

            if (rst)
                UpdateDataGridView();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void comboCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboCondition.SelectedIndex ==0)
            {
                this.cbSystem.Checked = true;
                this.cbManageNum.Checked = true;
                this.cbBoardType.Checked = true;
            }
            else if(comboCondition.SelectedIndex ==1)
            {
                this.cbSystem.Checked = true;
                this.cbManageNum.Checked = false;
                this.cbBoardType.Checked = false;
            }
            else if(comboCondition.SelectedIndex ==2)
            {
                this.cbSystem.Checked = false;
                this.cbManageNum.Checked = true;
                this.cbBoardType.Checked = false;
            }
            else if(comboCondition.SelectedIndex ==3)
            {
                this.cbSystem.Checked = false;
                this.cbManageNum.Checked = false;
                this.cbBoardType.Checked = true;
            }

        }

        private void lvBoard_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvBoard.SelectedItems.Count > 0)
            {
                ListViewItem item = this.lvBoard.SelectedItems[0];

                List<string[]> resultlist = dbConn.GetBoardDetail(item.ImageKey);
                this.detailBoard.SetEquipmentData(resultlist);

                this.tabViewDetail.SelectedIndex = 1;
            }
        }

        private void btnUserSearch_Click(object sender, EventArgs e)
        {
            int userId= this.comboUser.SelectedIndex;
            if(userId==0)
            {
                List<string[]> result = dbConn.GetEquipmentDetailsConditions("");
                this.detailEquipment.SetEquipmentData(result);
            }
            else
            {
                string strCondition = string.Format("WHERE userid={0}", userId);
                List<string[]> result = dbConn.GetEquipmentDetailsConditions(strCondition);
                this.detailEquipment.SetEquipmentData(result);
            }
        }

        private void ExportExcelFile(List<string[]> data, ref Excel._Worksheet objSheet)
        {
            int num = 0;
            object missingType = Type.Missing;

            int colCnt = detailEquipment.GetColumnCount;
            int rowCnt = data.Count;
            string[] headers = detailEquipment.GetHeaderText();
            string[] columns = new string[colCnt];
            for (int c = 0; c < colCnt; c++)
            {
                num = c + 65;
                columns[c] = Convert.ToString((char)num);
            }

            try
            {
                Excel.Range range;
                range = objSheet.get_Range(columns[0] + "1:" + columns[colCnt - 1] + "1", Missing.Value);
                range.Value2 = headers;

                for (int i = 0; i < rowCnt; i++)
                {
                    string strRange = columns[0] + (i + 2) + ":" + columns[colCnt - 1] + (i + 2);
                    range = objSheet.get_Range(strRange, Missing.Value);
                    range.Value2 = data[i];
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //private void ExportExcelFile()
        //{
        //    int num = 0;
        //    object missingType = Type.Missing;

        //    Excel.Application objApp;
        //    Excel._Workbook objBook;
        //    Excel.Workbooks objBooks;
        //    Excel.Sheets objSheets;
        //    Excel._Worksheet objSheet;
        //    Excel.Range range;
        //    int colCnt = detailEquipment.GetColumnCount;
        //    int rowCnt = detailEquipment.GetRowCount;
        //    string[] headers = detailEquipment.GetHeaderText();
        //    string[] columns = new string[colCnt];
        //    for (int c = 0; c < colCnt; c++)
        //    {
        //        num = c + 65;
        //        columns[c] = Convert.ToString((char)num);
        //    }

        //    try
        //    {
        //        objApp = new Excel.Application();
        //        objBooks = objApp.Workbooks;
        //        objBook = objBooks.Add(Missing.Value);
        //        objSheets = objBook.Worksheets;
        //        //objSheet = (Excel._Worksheet)objSheets.get_Item(1);
        //        objSheet = (Excel._Worksheet)objSheets.Add(objSheets[1], Type.Missing, Type.Missing, Type.Missing);
        //        objSheet.Name = "all";
        //        range = objSheet.get_Range(columns[0] + "1:" + columns[colCnt - 1] + "1", Missing.Value);
        //        range.Value2 = headers;

        //        for (int i = 0; i < rowCnt; i++)
        //        {
        //            string strRange = columns[0] + (i + 2) + ":" + columns[colCnt - 1] + (i + 2);
        //            range = objSheet.get_Range(strRange, Missing.Value);
        //            range.Value2 = this.detailEquipment.GetRowData(i);
        //        }


        //        // 시트 추가할때 
        //        //objSheet = (Excel._Worksheet)objSheets.Add(objSheets[2], Type.Missing, Type.Missing, Type.Missing);
        //        //range = objSheet.get_Range(columns[0] + "1:" + columns[colCnt - 1] + "1", Missing.Value);
        //        //range.Value2 = headers;
        //        //objSheet.Name = "Model";
        //        //for (int i = 0; i < rowCnt;i++)
        //        //{
        //        //    string strRange = columns[0] + (i + 2) + ":" + columns[colCnt - 1] + (i + 2);
        //        //    range = objSheet.get_Range(strRange, Missing.Value);
        //        //    range.Value2 = this.detailEquipment.GetRowData(i);
        //        //}

        //        objApp.Visible = false;
        //        objApp.UserControl = false;
        //        objBook.SaveAs(@dlg.FileName,
        //            Excel.XlFileFormat.xlWorkbookNormal,
        //            Type.Missing, Type.Missing, false, false,
        //            Excel.XlSaveAsAccessMode.xlNoChange,
        //            false, false, Type.Missing, Type.Missing, Type.Missing);

        //        objBook.Close(false, missingType, missingType);
        //        Cursor.Current = Cursors.Default;
        //        MessageBox.Show("Save Success!!!");

        //        //for(int i=0; i<rowCnt -1; i++)
        //        //{
        //        //    for(int j =0; j<colCnt;j++)
        //        //    {
        //        //        range = objSheet.get_Range(columns[j] + Convert.ToString(i + 2), Missing.Value);
        //        //        objSheet.get_Range()
        //        //        range.set_Value(Missing.Value,detailEquipment.GetRowData(i).Cells[j].Value.ToString());
        //        //        range.
        //        //    }
        //        //}
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = "noname";
            dlg.DefaultExt = "xls";
            dlg.Filter = "Excel files (*.xls|*.xls";
            //dlg.InitialDirectory = "c:\\";

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                Excel.Application objApp = new Excel.Application();
                Excel.Workbooks objBooks = objApp.Workbooks;
                Excel._Workbook objBook = objBook = objBooks.Add(Missing.Value);
                Excel.Sheets objSheets = objBook.Worksheets;
                Excel._Worksheet objSheet;
                
                for(int i=0; i<lvModel.Items.Count ; i++)
                {
                    objSheet = (Excel._Worksheet)objSheets.Add(objSheets[i+1], Type.Missing, Type.Missing, Type.Missing);
                    objSheet.Name = lvModel.Items[i].Text;
                    List<string[]> resultlist = dbConn.GetEquipmentDetails(lvModel.Items[i].Text);
                    ExportExcelFile(resultlist, ref objSheet);
                }

                objApp.Visible = false;
                objApp.UserControl = false;
                objBook.SaveAs(@dlg.FileName,
                    Excel.XlFileFormat.xlWorkbookNormal,
                    Type.Missing, Type.Missing, false, false,
                    Excel.XlSaveAsAccessMode.xlNoChange,
                    false, false, Type.Missing, Type.Missing, Type.Missing);

                objBook.Close(false, Type.Missing, Type.Missing);
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Save Success!!!");
                //ExportExcelFile();
            }
        }
    }
}
