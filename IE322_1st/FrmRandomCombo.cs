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
    public partial class FrmRandomCombo : Form
    {
        

        public FrmRandomCombo()
        {
            InitializeComponent();
        }

        private void BtnGenerateQuiz03_AAF19_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < r.Next(1, 50) - 1; i++) // هنا بنكون عدد عشوائي من العناصر بين 1 و 50 وحطيت ناقص واحد عشان الايتمز تبدا من الصفر. وكل عنصر هو عدد عشوائي من بين مية و 999 
            {
                CmbQuiz03_AAF19.Items.Add(r.Next(100, 999));
            }
        }

        private void BtnResetQuiz03_AAF19_Click(object sender, EventArgs e)
        {
            CmbQuiz03_AAF19.ResetText();
            CmbQuiz03_AAF19.Items.Clear();
        }
    }
}
