using Coffee_Store_Management_Software.DAO;
using Coffee_Store_Management_Software.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Store_Management_Software
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you really wanna to exit from this program ", "notification", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

       

        bool login(string Username, string Password)
        {

            return AccountDAO.Instance.login(Username, Password);
        }

    

    
      

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;

            if (login(username, password))
            {
                Account loginaccount = AccountDAO.Instance.getaccountbyusername(username);

                Tablemanager open = new Tablemanager(loginaccount);

                this.Hide();
                open.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Your Username or Password is wrong , please check it again!");
            }
        }
    }
}
