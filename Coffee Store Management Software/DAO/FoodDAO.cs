 using Coffee_Store_Management_Software.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Store_Management_Software.DAO
{
   public class FoodDAO
    {

        private static FoodDAO instance;

        public static FoodDAO Instance
        { get { if (instance == null) instance = new FoodDAO(); return FoodDAO.instance;}
          set => instance = value;
        }
        public FoodDAO() { }

        //loading data from food

        public List<Food> loadlistdatafoodbyidcategory(int id)
        {

            List<Food> listfood = new List<Food>();
            string query = "select * from Food where Food.idCategory=" + id;
            DataTable data = DataProvider.Instance.Executequery(query);
            foreach (DataRow items in data.Rows)
            {
                if (data.Rows.Count > 0)
                {
                    Food eachfood = new Food(items);
                    listfood.Add(eachfood);

                }


            }
            return listfood;
        }

        public List<Food> loadingfood()
        {
            List<Food> listfood = new List<Food>();
            string query = "Select * from Food";
            DataTable data = DataProvider.Instance.Executequery(query);

            foreach(DataRow items in data.Rows)
            {
                Food f = new Food(items);
                listfood.Add(f);
            }

            return listfood;
        }
         public bool insertfood(string name , int idCategory, float price)
        {
            string query = string.Format("insert Food (name ,idCategory,price)values(N'{0}',{1},{2})",name,idCategory,price); 
            int result = DataProvider.Instance.Executenonquery(query);
            return result > 0;
        }

        public bool updatefood(int idfood,string name, int idCategory, float price)
        {
            string query = string.Format("update food set name=N'{0}',idCategory={1},price={2} where id={3}", name, idCategory, price,idfood);
            int result = DataProvider.Instance.Executenonquery(query);
            return result > 0;
        }
        public bool deletefood(int idfood)
        {
            Bill_InforDAO.Instance.deletebillinfobyidfood(idfood);
            string query = string.Format("delete food where id={0}",idfood);
            int result = DataProvider.Instance.Executenonquery(query);
            return result > 0;
        }
        public bool deletefoodbyidcategory(int idcategory,int idfood)
        {
            Bill_InforDAO.Instance.deletebillinfobyidfood(idfood);
            string query = string.Format("delete food where idCategory={0}", idcategory);
            int result = DataProvider.Instance.Executenonquery(query);
            return result > 0;
        }

        public List<Food> SearchingfoodbyName(string name)
        {
            List<Food> listfood = new List<Food>();
            string query = string.Format("Select * from Food where name like N'%{0}%'", name);
            // % at head : dont care any word in front of {0} anyway seeking on the right word in {0} that ok
            // % at the ending : the contrary
            // but those above only for seeking VietNamese
            string query1 = string.Format(" select * from Dbo.food where [dbo].[fuConvertToUnsign1](name) like N'%'+[dbo].[fuConvertToUnsign1](N'{0}')+'%'", name);


            DataTable data = DataProvider.Instance.Executequery(query1);

            foreach (DataRow items in data.Rows)
            {
                Food f = new Food(items);
                listfood.Add(f);
            }

            return listfood;
        }
    }
}
