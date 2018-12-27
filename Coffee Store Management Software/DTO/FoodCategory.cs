using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Store_Management_Software.DTO
{
  public  class FoodCategory
    {
        private int id;
        private string name;

        public FoodCategory(int Id, string Name)
        {
            this.id = Id;
            this.name = Name;
        }


        public FoodCategory(DataRow row)
        {
            this.id = (int)row["id"];
            this.name = row["name"].ToString();

        }


        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
