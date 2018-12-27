using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Coffee_Store_Management_Software.DTO
{
    class Table
    {
        private int id;//,sum_food;
        private string name, status,username;
        public Table(int id, string name, string status, string username)
        {
            this.Id1 = id;
            this.name = name;
            this.status = status;
            this.username = username;

          //  this.sum_food = sum_food;
        }
        public Table(DataRow row)
        {
            this.Id1 = (int)row["id"];
            this.name = row["name"].ToString();
            this.status = row["status"].ToString();
            this.username = row["UserName"].ToString();
           ///this.sum_food = (int)row["sum_food"];

        }

        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }
        public int Id1 { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
       // public int Sum_food { get => sum_food; set => sum_food = value; }
    }
}
