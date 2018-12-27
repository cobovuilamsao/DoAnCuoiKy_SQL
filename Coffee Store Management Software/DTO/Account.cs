using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Store_Management_Software.DTO
{
    public class Account
    {
        private string username;
        private string displayname;
        private string password;
        private int type;

        public Account(string username, string displayname, string password, int type)
        {
            this.username = username;
            this.displayname = displayname;
            this.password = password;
            this.type = type;
        }
        public Account(DataRow row)
        {

            this.username = row["UserName"].ToString();
            this.displayname = row["DisPlayName"].ToString();
            this.password = row["PassWord"].ToString();
            this.type = (int)row["Type"];
        }



        public string Username { get => username; set => username = value; }
        public string Displayname { get => displayname; set => displayname = value; }
        public string Password { get => password; set => password = value; }
        public int Type { get => type; set => type = value; }
    }
}
