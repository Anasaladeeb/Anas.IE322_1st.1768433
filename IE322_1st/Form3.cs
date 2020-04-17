using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IE322_1st
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void BtnBackCheckBox_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (checkBoxCoffee.Checked == true)
            {
               msg=checkBoxCoffee.Text;
            }
            if (CheckBoxDonut.Checked == true)
            {
                msg = msg + " " + CheckBoxDonut.Text;
            }
            if (checkBoxBrownie.Checked == true)
            {
                msg = msg + " " + checkBoxBrownie.Text;
            }
           
            //هذي طريقتي وتنفع. وفيه طريقة ثانية للدكتور. 
           if (msg == "")
            MessageBox.Show("no thing have been selected");
      
           else
            MessageBox.Show(msg +" have been ordered ");
          
           //طريقة الدكتور
            //if (msg.Length == 0)
            {
               // msg = "no thing ";
            }
            //MessageBox.Show(msg + " have been ordered ");
        }   
           
    }
}
