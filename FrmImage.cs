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
    public partial class FrmImage : Form
    {
        public FrmImage()
        {
            InitializeComponent();
        }

        private void BtnLoadImage_Click(object sender, EventArgs e)
        {
           TryImage.Image = Image.FromFile("C:\\Users\\MSI\\Pictures\\Anas's Picture.jpg");
           
        }

        private void TryImage_Click(object sender, EventArgs e)
        {

        }

        private void FrmImage_Load(object sender, EventArgs e)
        {

        }
    }
}
