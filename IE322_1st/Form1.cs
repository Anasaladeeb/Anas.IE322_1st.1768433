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
    public partial class FrmLogin : Form
    {
        string username = "Ali";
        string myPassword = "1234";
        bool loggedin = false;
      
        int attempt = 1;
        int MaxAttempts = 3;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (! loggedin)
            {



                while (attempt <= MaxAttempts)
                {
                    if (TxtUser.Text != username)
                    {
                        // username is incorrect
                        MessageBox.Show("Invalid username, " + (MaxAttempts - attempt) + " attempts remaining");
                        attempt++;
                        TxtUser.Clear();
                        TxtPass.Clear();
                        return; // معناها عودة عشان يسجل دخول مرة ثانية. بدونها بيكمل البرنامج من نفسه ويرفض التسجيل
                       
                    }

                    else
                    {   // username is correct
                        // so check password			
                        if (TxtPass.Text != "1234")
                        {
                            // Incorrect password
                            MessageBox.Show("Incorrect password," + (MaxAttempts - attempt) + " attempts remaining");
                            attempt++;
                            TxtUser.Clear();
                            TxtPass.Clear();
                            return;
                        }
                        else
                        {
                            //Both are correct
                            attempt = 0; // reset the number of attempts
                            loggedin = true; // you dont have to declear the variable toice 
                            MessageBox.Show(" Hi " +  username  + " your login successful ");
                            TxtUser.Clear();
                            TxtPass.Clear();


                            BtnLogin.Text = "Logout";
                            //toolStripStatusLabel1.Text = "You are logged in."; هذا مرحلة قادمة
                            // this.Width = 1600;
                            break; // come out of while loop
                        }//endif

                    }//endif
                }//end while
            }
        }

        private void TxtPass_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void BtnEXIT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LblForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(" Go away ");
        }

        private void BtnRadio_Click(object sender, EventArgs e)
        {
            FrmRadio frm = new FrmRadio();
            frm.ShowDialog();
        }

        private void BtnCheckBox_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.ShowDialog();

        }

        private void BtnCombo_Click(object sender, EventArgs e)
        {
            FrmCombo frm = new FrmCombo();
            frm.ShowDialog();
        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            FrmRandom frm = new FrmRandom();
            frm.ShowDialog();
        }

        private void GroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void BtnRandomCom_Click(object sender, EventArgs e)
        {
            FrmRandomCombo frm = new FrmRandomCombo();
            frm.ShowDialog();
        }

        private void BtnPictureBox_Click(object sender, EventArgs e)
        {
            FrmImage frm = new FrmImage();
            frm.ShowDialog();
                
        }

        private void BtnPictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
