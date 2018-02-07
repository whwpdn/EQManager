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
    public partial class EditDataForm : Form
    {
        Dictionary<string, string> dicModifiedData;
        public Dictionary<string, string> ModifiedData
        {
            get{return this.dicModifiedData;}
        }
        public EditDataForm(string[] datalist)
        {
            InitializeComponent();
            dicModifiedData = new Dictionary<string, string>();
            this.inputControl1.SetFormData(datalist);
        }

        public void SetFormData(string[] datalist)
        {
            this.inputControl1.SetFormData(datalist);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dicModifiedData = this.inputControl1.GetModifiedData();
        }
    }
}
