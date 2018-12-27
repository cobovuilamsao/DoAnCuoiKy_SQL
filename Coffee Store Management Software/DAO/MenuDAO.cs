using Coffee_Store_Management_Software.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Store_Management_Software.DAO
{
   public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; } set { MenuDAO.instance = value; }
        }
        private MenuDAO() { }
        public List<Menu> getlistmenubytableunchecking(int id)
        {
            List<Menu> listmenu = new List<Menu>();
            string query = "select Food.name ,Food.price,BillInfo.count, Food.price*BillInfo.count as sum from BillInfo, bill, food where food.id = BillInfo.idFood and BillInfo.idBill = Bill.id and Bill.statuses=0 and Bill.idTable =" + id;
            DataTable data = DataProvider.Instance.Executequery(query);
            foreach(DataRow items in data.Rows)
            {
                Menu menu = new Menu(items);
                listmenu.Add(menu);
            }


            return listmenu;
        }
    }
}
