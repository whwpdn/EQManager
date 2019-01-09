using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace EQManager
{
    public enum ViewType
    {
        Equipment = 0,
        Board,
        History
    }

   
    public partial class DetailView : UserControl
    {

        public ShowHistoryData HistoryData;
        public EditData editEquipmentData;
        public DeleteData delEquipmentData;

        string strSelectedEquipment = "";
        ViewType iViewType = ViewType.Equipment;
        public DetailView()
        {
            InitializeComponent();
            //ChangeUIType(iViewType);
        }

        [Category("MyProperties"), Description("Change View Type")]
        public ViewType ViewType
        {
            get { return iViewType; }
            set
            {
                this.iViewType = value;
                ChangeUIType();
            }
        }
        public int GetColumnCount
        {
            get { return this.dataGridDetailView.ColumnCount; }
        }

        public int GetRowCount
        {
            get { return this.dataGridDetailView.RowCount; }
        }

        public string[] GetHeaderText(int idx = -1)
        {
            if (idx >= this.GetColumnCount) return new string[]{""};

            if(idx ==-1)
            {
                string[] headers = new string[this.GetColumnCount];
                for (int i = 0; i < this.GetColumnCount; i++ )
                {
                    headers[i] = this.dataGridDetailView.Columns[i].HeaderText;
                }
                return headers;
            }
            else
            {
                string[] headers = {dataGridDetailView.Columns[idx].HeaderText};
                return headers;
            }
        }

        public void ChangeUIType()
        {
            //List<DataGridViewColumn> listCols = new List<DataGridViewColumn>();
            //listCols.Add(this.colUse);
            this.dataGridDetailView.Columns.Clear();

            if(this.iViewType ==ViewType.Board)
            {
                this.dataGridDetailView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                    this.colUse,
                    this.colManageNumber,
                    this.colBoardType,
                    this.colBoardSerial,
                    this.colUser,
                    this.colLoc,
                    this.colIncomeDate,
                    this.colNote});
                this.menuitemHistory.Visible = false;
            }
            else if (this.iViewType == ViewType.Equipment)
            {
                this.dataGridDetailView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                    this.colUse,
                    this.colSystem,
                    this.colManageNumber,
                    this.colSerial,
                    this.colBoardType,
                    this.colBoardSerial,
                    this.colSplitter,
                    this.colCPU,
                    this.colRAM,
                    this.colHDD,
                    this.colVGA,
                    this.colUser,
                    this.colLoc,
                    this.colIncomeDate,
                    this.colNote});
            }
            else
            {
                this.dataGridDetailView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                    this.colDate,
                    this.colUse,
                    this.colSystem,
                    this.colManageNumber,
                    this.colSerial,
                    this.colBoardType,
                    this.colBoardSerial,
                    this.colSplitter,
                    this.colCPU,
                    this.colRAM,
                    this.colHDD,
                    this.colVGA,
                    this.colUser,
                    this.colLoc,
                    this.colIncomeDate,
                    this.colNote});
            }
        }
        public void AddColumn(string strColName)
        {
            DataGridViewColumn colDate = new DataGridViewColumn();
            colDate.HeaderText = strColName;
            this.dataGridDetailView.Columns.Add(colDate);
        }

        public void InsertColumn(string strColName, int idx)
        {
            DataGridViewTextBoxColumn colDate = new DataGridViewTextBoxColumn();
            colDate.HeaderText = strColName;
            colDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridDetailView.Columns.Insert(idx,colDate);
        }


        public void SetEquipmentData(List<string[]> resultlist)
        {
            //초기화
            this.dataGridDetailView.Rows.Clear();
            this.dataGridDetailView.Refresh();

            foreach (string[] rowlist in resultlist)
            {
                SetEquipmentData(rowlist);
                //this.dataGridDetailView.Rows.Add(rowlist);
            }
        }


        public void SetEquipmentData(string[] resultlist)
        {
            this.dataGridDetailView.Rows.Add(resultlist);
        }
        
        public List<string[]> GetRowData()
        {
            List<string[]> rowdatas = new List<string[]>();
            foreach(DataGridViewRow aRow in this.dataGridDetailView.Rows)
            {
                string[] aData = new string[aRow.Cells.Count];
                if (aRow.Cells[0].Value == null) continue;

                for(int i=0; i<aRow.Cells.Count ; i++)
                {
                    aData[i] = aRow.Cells[i].Value == null ? "" : aRow.Cells[i].Value.ToString();
                }
                rowdatas.Add(aData);
            }
            return rowdatas;
        }

        public string[] GetRowData(int idx)
        {
            DataGridViewRow aRow = this.dataGridDetailView.Rows[idx];
            string[] aData = new string[aRow.Cells.Count];
            if (aRow.Cells[0].Value == null) return null;
            for (int i = 0; i < aRow.Cells.Count; i++)
            {
                aData[i] = aRow.Cells[i].Value == null ? "" : aRow.Cells[i].Value.ToString();
            }
            return aData;
        }
        private void dataGridDetailView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            // when mouse down on cell , select row
            if (e.RowIndex < 0) return;
            if (!this.dataGridDetailView.Rows[e.RowIndex].Selected) this.dataGridDetailView.Rows[e.RowIndex].Selected = true;
       
        }

        private void dataGridDetailView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // if last row , return 
                if (this.dataGridDetailView.RowCount == (this.dataGridDetailView.SelectedRows[0].Index + 1) ) return;
                //selected item -테스트코드( 관리번호 가져오는 열로 수정해야함).
                strSelectedEquipment = this.dataGridDetailView.SelectedRows[0].Cells[2].Value.ToString();

                // show context menu
               // Point pp = PointToClient(e.Location);
                //Point p2p = PointToScreen(e.Location);
                this.contextMenuStrip1.Show(this, e.Location);
            }
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            
        }
        public void SetEquipmentHistoryData(List<string[]> resultlist)
        {
            //초기화
            this.dataGridDetailView.Rows.Clear();
            this.dataGridDetailView.Refresh();

            foreach (string[] rowlist in resultlist)
            {

                this.dataGridDetailView.Rows.Add(rowlist);
            }
        }

        private void editDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] datalist = this.GetRowData(this.dataGridDetailView.CurrentCell.RowIndex);
           editEquipmentData(datalist);
        }

        private void menuitemHistory_Click(object sender, EventArgs e)
        {
            HistoryData(strSelectedEquipment);
        }

        private void deleteDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delEquipmentData(strSelectedEquipment);
        }


       
    }
}
