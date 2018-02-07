using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            this.detailEquipment.HistoryData = new ShowHistoryData(this.SetHistory);
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
        private void SetHistory(string strManageNum)
        {
            List<string[]> resultlist = dbConn.GetEquipmentHistory(strManageNum);
            DetailView historyView = new DetailView();

            historyView.InsertColumn("date",0);

            historyView.SetEquipmentHistoryData(resultlist);

            Form historyForm = new Form();
            historyForm.Controls.Add(historyView);
            historyForm.AutoSize = true;
            historyForm.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            historyForm.Show();
        }

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

      
    }
}
