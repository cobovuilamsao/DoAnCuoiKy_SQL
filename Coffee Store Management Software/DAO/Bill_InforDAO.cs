using Coffee_Store_Management_Software.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Store_Management_Software.DAO
{
    public class Bill_InforDAO
    {
        private static Bill_InforDAO instance;

        public static Bill_InforDAO Instance
        {
            get { if (instance == null) instance = new Bill_InforDAO(); return Bill_InforDAO.instance; }
            private  set { instance = value; }
        }
        public List<Bill_Infor> loadinglistbillinfo()
        {
            List<Bill_Infor> listbill = new List<Bill_Infor>();

            string query = "Select * from billinfo";
            DataTable data = DataProvider.Instance.Executequery(query);

            foreach (DataRow items in data.Rows)
            {
                Bill_Infor f = new Bill_Infor(items);
                listbill.Add(f);
            }

            return listbill;

        }
        public Bill_InforDAO() { }
        public List<Bill_Infor> getlistbillinfor(int id)
        {
            List<Bill_Infor> listbillinfor = new List<Bill_Infor>();

            string query = "select * from BillInfo where BillInfo.idBill = " + id;
         
            DataTable data = DataProvider.Instance.Executequery(query);
            foreach (DataRow items in data.Rows)
            {
                Bill_Infor infor = new Bill_Infor(items);
                listbillinfor.Add(infor);

            }
                return listbillinfor;
        }
       public void insertbillinfor(int idbill, int idfood, int count )
        {
            DataProvider.Instance.Executenonquery("execute Insert_billinfor @idbill , @idfood , @count", new object[] { idbill,idfood,count });
        }
        public void deletebillinfobyidfood(int id)
        {
           

            string query = "delete BillInfo where BillInfo.idFood = " + id;

            DataProvider.Instance.Executequery(query);
        }

        public bool deletebillinfobyidbill(int idbill)
        {


            string query = "delete BillInfo where BillInfo.idbill = " + idbill;

           int result= DataProvider.Instance.Executenonquery(query);
            return result> 0;
        }

    }
}
