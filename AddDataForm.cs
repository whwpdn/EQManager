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
    public partial class AddDataForm : Form
    {
        public AddDataForm()
        {
            InitializeComponent();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<string> newData = this.inputControl1.GetFormData();

            this.detailView1.SetEquipmentData(newData.ToArray());
        }

        private void btnTransation_Click(object sender, EventArgs e)
        {

        }

        public List<string[]> GetNewEquipmentData()
        {
            return this.detailView1.GetRowData();
        }

        private void tbRAM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8 && e.KeyChar != 46) //8:백스페이스,46:소수점
            {
                e.Handled = true;
            }
        }

        private void tbHDD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8 && e.KeyChar != 46) //8:백스페이스,46:소수점
            {
                e.Handled = true;
            }
        }

       


    }
}
