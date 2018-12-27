using Coffee_Store_Management_Software.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Coffee_Store_Management_Software.DAO
{
    class TableDAO
    {
        private static TableDAO instance;
        public static int tablewidth=90;
        public static int tableheight = 90;

        public static TableDAO Instance { get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
                set { instance = value; } }

        private TableDAO() { }

        public void movingtable(int id1,int id2)
        {
            DataProvider.Instance.Executequery(string.Format("execute USP_SwitchTabel {0},{1}",id1,id2 ));

        }
        public void combininggtable(int id1, int id2)
        {
            DataProvider.Instance.Executequery(string.Format("execute Combiningtable {0},{1}", id1, id2));

        }


        public List<Table> Loadinglisttable()
        {
            List<Table> listtable = new List<Table>();
            DataTable data = DataProvider.Instance.Executequery("select * from tablefood");
             foreach( DataRow items in data.Rows)
            {
                Table table = new Table(items);
                listtable.Add(table);

            }
            
            return listtable;

        }
        
        public bool inserttable(string name,string status)
        {
            string query = string.Format("insert dbo.TableFood(name,status)values(N'{0}',N'{1}')", name,status);
            int result = DataProvider.Instance.Executenonquery(query);
            return result > 0;
        }
        public bool updatetable(int idtable, string nametable, string status)
        {
            string query = string.Format("update tablefood set name=N'{0}',status=N'{1}' where id ={2}", nametable, status, idtable);
            int result = DataProvider.Instance.Executenonquery(query);
            return result > 0;
        }
        public void deletetablebyidbill(int idbill, int idtable)
        {
            
            if (idbill == null)
            {
              
                 DataProvider.Instance.Executenonquery(string.Format("delete tablefood where id={0}", idtable));

            }
            else
            {
                BillDAO.Instance.deletebillbyidtable(idbill, idtable);
                 DataProvider.Instance.Executenonquery(string.Format("delete tablefood where id={0}", idtable));
            }
            
        }
        
        public int getmaxidbill()
        {
            try
            {
                return (int)DataProvider.Instance.Executescalar("select MAX(id) from tablefood");
            }
            catch
            {
                return 1;
                ///dsfsf
            }
        }
    }
}
