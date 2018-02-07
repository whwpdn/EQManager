using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EQManager
{
    public partial class InputControl : UserControl
    {

        enum FormDataIdx
        {

        }
        public InputControl()
        {
            InitializeComponent();
        }
        public Dictionary<string, string> GetModifiedData()
        {
            //<db fiedl name , modified data>
            Dictionary<string, string> modified = new Dictionary<string, string>();
            if (this.tbBoardName.Modified)
                modified.Add("MatroxBoard", this.tbBoardName.Text);
            if (this.tbSystem.Modified)
                modified.Add("SystemName", this.tbSystem.Text);
            if (this.tbUse.Modified)
                modified.Add("use", this.tbUse.Text);
            if (this.tbManageNum.Modified)
                modified.Add("ManageNum", this.tbManageNum.Text);
            if (this.tbSerialNum.Modified)
                modified.Add("SerialNum", this.tbSerialNum.Text);
            if (this.tbBoardSerialNum.Modified)
                modified.Add("BoardSerial", this.tbBoardSerialNum.Text);
            if (this.tbSplitter.Modified)
                modified.Add("Splitter", this.tbSplitter.Text);
            if (this.tbCPU.Modified)
                modified.Add("CPU", this.tbCPU.Text);
            if (this.tbRAM.Modified)
                modified.Add("RAM", this.tbRAM.Text);
            if (this.tbHDD.Modified)
                modified.Add("HDD", this.tbHDD.Text);
            if (this.tbVGA.Modified)
                modified.Add("VGA", this.tbVGA.Text);
            if (this.tbUser.Modified)
                modified.Add("User", this.tbUser.Text);
            if (this.tbLoc.Modified)
                modified.Add("Location", this.tbLoc.Text);
            if (this.tbIncoming.Modified)
                modified.Add("IncomingDate", this.tbIncoming.Text);
            if (this.tbNote.Modified)
                modified.Add("note", this.tbNote.Text);
            return modified;
        }

         public List<string> GetFormData()
         {
              List<string> newData = new List<string>();
              // number
              //newData.Add(idx.ToString());
             
              //use
              newData.Add(this.tbUse.Text);

              // requirment info
              // system
              newData.Add(tbSystem.Text);
              //ManageNum
              if (tbManageNum.Text == "")
              {
                  CheckError(this.lbManageNum);
                  return null;
              }
              newData.Add(tbManageNum.Text);
              //Serial
              //if (tbSerialNum.Text == "")
              //{
              //    CheckError(this.lbSerial);
              //    return;
              //}
              newData.Add(tbSerialNum.Text);
              //BoardType
              //if (tbBoardName.Text == "")
              //{
              //    CheckError(this.lbBoardName);
              //    return;
              //}
              newData.Add(tbBoardName.Text);
              //BoardSerial
              //if (tbBoardSerialNum.Text == "")
              //{
              //    CheckError(this.lbBoardSerial);
              //    return;
              //}
              newData.Add(tbBoardSerialNum.Text);

              // Additional info
              // splitter
              newData.Add(tbSplitter.Text);
              //CPU
              newData.Add(tbCPU.Text);
              //Ram
              newData.Add(tbRAM.Text);
              //HDD
              newData.Add(tbHDD.Text);
              // VGA
              newData.Add(tbVGA.Text);
              //User
              newData.Add(tbUser.Text);
              //Location
              newData.Add(tbLoc.Text);

              // incoming
              newData.Add(tbIncoming.Text);
              // note
              newData.Add(tbNote.Text);

              return newData;

         }
         public void SetFormData(string[] datalist)
         {
           
             //use
             this.tbUse.Text = datalist[0];
             // system
             this.tbSystem.Text = datalist[1];
             //ManageNum
             this.tbManageNum.Text = datalist[2];
             //Serial
             this.tbSerialNum.Text = datalist[3];
             // boardName
             this.tbBoardName.Text = datalist[4];
             //BoardSerial
             this.tbBoardSerialNum.Text = datalist[5];
             // splitter
             this.tbSplitter.Text = datalist[6];
             //CPU
             this.tbCPU.Text = datalist[7];
             //Ram
             this.tbRAM.Text = datalist[8];
             //HDD
             this.tbHDD.Text = datalist[9];
             // VGA
             this.tbVGA.Text = datalist[10];
             //User
             this.tbUser.Text =  datalist[11];
             //Location
             this.tbLoc.Text= datalist[12];

             // incoming
             this.tbIncoming.Text = datalist[13];
             // note
             this.tbNote.Text = datalist[14];

         }
         private void CheckError(Label lbError)
         {
             lbError.ForeColor = Color.Red;
         }
          
    }
}
