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
    public partial class FrmRadio : Form
    {
        public FrmRadio()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void RdoRed2_CheckedChanged(object sender, EventArgs e)
        {
         if (RdoRed2.Checked == true) 
              RdoRed2.ForeColor = Color.FromArgb(255, 0, 0); // استعمل رمز اللون لتلوين النص
         else
              RdoRed2.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void Rdoyellow2_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdoyellow2.Checked == true) 
                Rdoyellow2.ForeColor = Color.FromName("yellow");  //استعمل اسم اللونلتلوين النص
            else
                Rdoyellow2.ForeColor = Color.FromName("Black");                  
        }

        private void RdoGreen2_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoGreen2.Checked == true)  
                RdoGreen2.ForeColor = Color.FromName("Green");
            else
                RdoGreen2.ForeColor = Color.FromName("Black");
        }

        private void RdoBlue2_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoBlue2.Checked == true)
                RdoBlue2.ForeColor = Color.FromName("Blue"); // بعد التلوين اذا ضغطت على لون وبعدا لون ثاني اللون الاول يبقى زي ما هو ولا يرجع أسود لذلك استعملنا دالة IF
            else
                RdoBlue2.ForeColor = Color.FromName("Black");
        }

        private void RdoRed_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoRed.Checked == true)
                RdoRed.ForeColor = Color.FromName("Red"); // 
            else
                RdoRed.ForeColor = Color.FromName("Black");
        }

        private void RdoGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoGreen.Checked == true)
                RdoGreen.ForeColor = Color.FromName("Green");
            else
                RdoGreen.ForeColor = Color.FromName("Black");
        }

        private void RdoBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoBlue.Checked == true)
                RdoBlue.ForeColor = Color.FromName("Blue"); 
            else
                RdoBlue.ForeColor = Color.FromName("Black");
        }

        private void RdoYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoYellow.Checked == true)
                RdoYellow.ForeColor = Color.FromName("yellow"); 
            else
                RdoYellow.ForeColor = Color.FromName("Black");
        }

        private void FrmRadio_Load(object sender, EventArgs e)
        {

        }
    }
    
}
