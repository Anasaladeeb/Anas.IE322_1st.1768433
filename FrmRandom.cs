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
    public partial class FrmRandom : Form
    {
        
        Random y = new Random(); 


        public FrmRandom()
        {
            InitializeComponent();
        }

        private void BtnBackRandom_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnRandomNum_Click(object sender, EventArgs e)
        {
            BtnRandomNum.Text = Convert.ToString(y.Next(1, 10)); //فوق عرف ان الواي عدد عشوائي وهنا حولها الى نص وحدد ان قيمتها تكون بين الواحد والعشرة

                
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            int r= y.Next(0, 255);
            int g= y.Next(0, 255);
            int b= y.Next(0, 255);

            LblRgb.Text = Convert.ToString(r)+"-"+Convert.ToString(g)+"-"+Convert.ToString(b);
            BtnGenerate.BackColor = Color.FromArgb(r,g,b);
            this.BackColor = Color.FromArgb(255-r, 255-g, 255-b); //استعمل كلمه ذيس بدل ما يكتب اسم الفورم ويمكن استعمال ايهما
        }

        private void LblRgb_Click(object sender, EventArgs e)
        {

        }
    }
}
