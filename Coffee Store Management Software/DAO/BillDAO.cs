using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Coffee_Store_Management_Software.DTO;

namespace Coffee_Store_Management_Software.DAO
{
   public class BillDAO
    {
        private static BillDAO instance;

     
        private BillDAO() { }

        public static BillDAO Instance
        { get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            set { instance = value; }
        }

        public void Checkout(int id, int discount, double grosslycost)
        {
            string query = "Update dbo.Bill set DateCheckOut=GetDate(), statuses=1, grosslycost="+grosslycost+", Discount="+discount+"where id="+id;
            DataProvider.Instance.Executenonquery(query);
        }
         public DataTable getprofitbyday(DateTime checkin , DateTime checkout)
        {
            return DataProvider.Instance.Executequery("execute profitbyday @chekin , @checkout", new object[] {checkin,checkout});
        }
        public List<Bill> loadinglistbill()
        {
            List<Bill> listbill = new List<Bill>();

            string query = "Select * from bill";
            DataTable data = DataProvider.Instance.Executequery(query);

            foreach (DataRow items in data.Rows)
            {
               Bill f = new Bill(items);
                listbill.Add(f);
            }

            return listbill;

        }

        public int GetUnCheckBillIDByTableID(int id)
        {

            // sucessfully: billID;
            /// unsuccessfully: -1
            string query = "select * from Bill where Bill.idTable="+id+"and dbo.Bill.statuses=0";
            DataTable data = DataProvider.Instance.Executequery(query);
            if (data.Rows.Count>0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID1;
            }
            return -1;
        }

        public  void insertbill(int id)
        {
            DataProvider.Instance.Executenonquery("exec Insert_bill @idTable",new object[]{id});
        }

        public  int getmaxidbill()
        {
            try
            {
                return (int)DataProvider.Instance.Executescalar("select MAX(id) from Bill");
            }
            catch
            {
                return 1;
            }
        }
        
        public bool deletebillbyidtable(int idbill,int idtable)
        {

            Bill_InforDAO.Instance.deletebillinfobyidbill(idbill);
                string query = string.Format("delete Bill where Bill.idtable={0} " ,idtable);

               int result= DataProvider.Instance.Executenonquery(query);

            return result > 0;
            
        }
     


    }

}

