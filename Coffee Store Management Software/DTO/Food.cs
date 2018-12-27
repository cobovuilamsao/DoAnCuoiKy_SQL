using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Store_Management_Software.DTO
{
  public  class Food
    {
        private int id;
        private string name;
        private int idCategory;
        private decimal price;

        public Food(int Id, string Name, int Idcategory, decimal Price)
        {
            this.id = Id;
            this.name = Name;
            this.idCategory = Idcategory;
            this.price = Price;
        }
        public Food(DataRow row)
        {
            this.id = (int)row["id"];
            this.name = row["name"].ToString();
            this.idCategory = (int)row["idCategory"];
            this.price = (decimal)Convert.ToDouble(row["price"].ToString());

        }


        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int IdCategory { get => idCategory; set => idCategory = value; }
        public decimal Price { get => price; set => price = value; }
    }
}
