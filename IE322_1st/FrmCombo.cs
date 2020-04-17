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
    public partial class FrmCombo : Form
    {
        public FrmCombo()
        {
            InitializeComponent();
            
            //هنا نكتب محتوى 
            
            CmbDays.Items.Add("Saturday");
            CmbDays.Items.Add("Sunday");
            CmbDays.Items.Add("Monday");
            CmbDays.Items.Add("Tuesday");
            CmbDays.Items.Add("Wednesday");
            CmbDays.Items.Add("Thursday");
            CmbDays.Items.Add("Friday");
        }

        private void BtnBackCombo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmCombo_Load(object sender, EventArgs e)
        {

        }

        private void BtnShowSM1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CmbDays.Text);
        }

        private void BtnRemoveByName_Click(object sender, EventArgs e)
        {
            CmbDays.Items.Remove("Friday");
        }

        private void BtnRemoveByIndex_Click(object sender, EventArgs e)
        {
            CmbDays.Items.RemoveAt(1);
        }

        private void BtnRemoveLastItem_Click(object sender, EventArgs e)
        {
          if(CmbDays.Items.Count >= 1 )
            {
                CmbDays.Items.RemoveAt(CmbDays.Items.Count - 1);  //ناقص واحد لان عدد العناصر مثلا 6 لكن اول عنصر رقمه يكون صفر والاخير خمسة  
            }
            else
            {
                MessageBox.Show("Can't remove the last item");
            }  
            //استعمل دالة count هنا
        }

        private void BtnRemove2ndLastItem_Click(object sender, EventArgs e)
        {
            if (CmbDays.Items.Count >= 2)
            {
                CmbDays.Items.RemoveAt(CmbDays.Items.Count - 2);
            }
            else
            {
                MessageBox.Show("Can't remove the last item");
            }

            //هنا استعمل count 
        }
    }
}
