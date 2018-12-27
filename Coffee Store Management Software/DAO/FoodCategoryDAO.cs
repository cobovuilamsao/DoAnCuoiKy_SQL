using Coffee_Store_Management_Software.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Store_Management_Software.DAO
{
  public  class FoodCategoryDAO
    {
        private static FoodCategoryDAO instance;

        public static FoodCategoryDAO Instance { get { if (instance==null) instance=new FoodCategoryDAO(); return FoodCategoryDAO.instance; } set => instance = value; }
        public FoodCategoryDAO() { }

        public List<FoodCategory> loadfoodcategory()
        {

            List<FoodCategory> listcategoryfood = new List<FoodCategory>();
            string query = "select * from FoodCategory";
            DataTable data = DataProvider.Instance.Executequery(query);
            foreach (DataRow items in data.Rows)
            {
                //if(data.Rows.Count>0)
                //{
                FoodCategory category = new FoodCategory(items);
                listcategoryfood.Add(category);

                // }


            }
            return listcategoryfood;
        }

        public FoodCategory GetcategorybyID(int id)
        {
            FoodCategory newcategory = null;
            string query = "select * from FoodCategory where id="+id;
            DataTable data = DataProvider.Instance.Executequery(query);
            foreach (DataRow items in data.Rows)
            {
                //if(data.Rows.Count>0)
                //{
                newcategory = new FoodCategory(items);
                return newcategory;
                

            }
            return newcategory;

        }

        public bool insertfoodcategory(string nameCategory)
        {
            string query = string.Format("insert FoodCategory (name)values(N'{0}')", nameCategory);
            int result = DataProvider.Instance.Executenonquery(query);
            return result > 0;
        }

        public bool updatecategory(string nameCategory, int id)
        {
            string query = string.Format("update FoodCategory set name=N'{0}' where id={1}",nameCategory ,id);
            int result = DataProvider.Instance.Executenonquery(query);
            return result > 0;
        }
        public bool deletefoodcategory(int idcategory,int idfood)
        {

            FoodDAO.Instance.deletefoodbyidcategory(idcategory,idfood);
            string query = string.Format("delete FoodCategory where id={0}", idcategory);
            int result = DataProvider.Instance.Executenonquery(query);
            return result > 0;
        }

    }
}
