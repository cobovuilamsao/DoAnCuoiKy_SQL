using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Coffee_Store_Management_Software.DTO;

namespace Coffee_Store_Management_Software.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            { if (instance == null)instance = new AccountDAO();return instance;}
            private set { instance = value; }
        }
        private AccountDAO() { }

        public bool login(string username , string password)
        {
            string query = "select * from Account where Username=N'"+username+"' and PassWord=N'"+password+"'";
            DataTable result = DataProvider.Instance.Executequery(query);


            return result.Rows.Count>0;
        }
        public Account getaccountbyusername(string username)
        {

            DataTable data = DataProvider.Instance.Executequery("select * from Account where UserName='"+username+"'");
            foreach(DataRow items in data.Rows)
            {
                return new Account(items);
            }
            return null;

        }

        public bool updateaccount(string username , string displayname, string pass, string newpass)
        {

            int data = DataProvider.Instance.Executenonquery("Updateaccount @username , @displayname , @password , @newpassword", new object[] {username,displayname,pass,newpass });
            return data > 0;
    
        }

        public DataTable getlistaccount()
        {
            return DataProvider.Instance.Executequery(" select Username,DisPlayName,Type from account");
        }
        public bool insertaccount(string username, string displayname, int type)
        {
            string query = string.Format("insert account (Username ,DisPlayName,Type)values(N'{0}',N'{1}',{2})", username, displayname, type);
            int result = DataProvider.Instance.Executenonquery(query);
            return result > 0;
        }

        public bool updateaccount(string username, string displayname, int type)
        {
            string query = string.Format("update account set displayname=N'{1}',type={2} where Username=N'{0}'", username, displayname, type);
            int result = DataProvider.Instance.Executenonquery(query);
            return result > 0;
        }
        public bool deleteaccount(string username)
        {
           // Bill_InforDAO.Instance.deletebillinfobyidfood(idaccount);
            string query = string.Format("delete account where UserName=N'{0}'",username);
            int result = DataProvider.Instance.Executenonquery(query);
            return result > 0;
        }

        public bool Resetingpassword(string username)
        {
            // Bill_InforDAO.Instance.deletebillinfobyidfood(idaccount);
            string query = string.Format("update account set PassWord=N'0' where UserName=N'{0}'", username);
            int result = DataProvider.Instance.Executenonquery(query);
            return result > 0;
        }
    }
}
