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
    public partial class PersonaInfor : Form
    {

        Account personaldetail;
        public PersonaInfor(Account acc)
        {
            this.Personaldetail = acc;
            InitializeComponent();
            showdetail(personaldetail);
        }

        void showdetail(Account acc)
        {
            txtdisplayname.Text = acc.Displayname;
            txtusername.Text = acc.Username;
            // txtretypenewpassword.Text = acc.Type.ToString();
            txtPassword.Text = acc.Password;
        }

        public Account Personaldetail { get => personaldetail; set {  personaldetail = value; } }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void updateaccountinfor()
        {
            string displayname = txtdisplayname.Text;
            string password = txtPassword.Text;
            string newpassword = txtnewpass.Text;
            string retypenewpassword = txtretypenewpassword.Text;
            string username = txtusername.Text;
            if(!newpassword.Equals(retypenewpassword))
            {
                MessageBox.Show("Retyping your password which is coincident with new password");
            }
            else
            {
                if (AccountDAO.Instance.updateaccount(username, displayname, password, newpassword))
                {
                    MessageBox.Show("Updated successfully");
                    if(updateaccount!=null)
                    {
                        updateaccount(this, new AccountEvent(AccountDAO.Instance.getaccountbyusername(username)));
                            }
                }
                else
                {
                    MessageBox.Show("Please ! filling out in the blanks correctly");
                }
            }

        }
      
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateaccountinfor();
        }



        private event EventHandler<AccountEvent> updateaccount;
        public event EventHandler<AccountEvent> Updateaccount
        {
            add { updateaccount += value; }
            remove { updateaccount -= value; }
        }

        public class AccountEvent:EventArgs
        {
            private Account acc;

            public Account Acc { get => acc; set => acc = value; }
            public AccountEvent(Account acc)
            {
                this.acc = acc;
            }
        }
    }
}
