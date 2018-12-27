using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Store_Management_Software.DTO
{
   public class Menu
    {
        private string  foodname;
        private int count;
        private decimal price;
        private decimal sum;

        public Menu(string Foodname, int count, decimal price, decimal sum )
        {
            this.foodname = Foodname;
            this.count = Count;
            this.price = Price;
            this.Sum = sum;
        }
        public Menu(DataRow row)
        {
            this.foodname = (string)row["name"];
            this.price =(decimal)Convert.ToDouble(row["price"].ToString());
            this.count = (int)row["count"];
            this.Sum = (decimal)Convert.ToDouble(row["sum"].ToString());
        }
        public string Foodname { get => foodname; set => foodname = value; }
        public int Count { get => count; set => count = value; }
        public decimal Price { get => price; set => price = value; }
        public decimal Sum { get => sum; set => sum = value; }
    }
}
