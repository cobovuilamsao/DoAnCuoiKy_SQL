using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Store_Management_Software.DTO
{
    public class Bill_Infor
    {

        public int id;
        public int idfood;
        public int idbill;
        public int count;// the sum of foods being chosen 
        // initiated function 
       public Bill_Infor(int ID,int FoofID, int BillID, int Count)
        {
            this.id = ID;
            this.idfood = FoofID;
            this.idbill = BillID;
            this.count = Count;

        }
        public Bill_Infor(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Idbill = (int)row["idBill"];
            this.Idfood = (int)row["idFood"];
            this.Count = (int)row["count"];

        }


        public int Id { get => id; set => id = value; }
        public int Idfood { get => idfood; set => idfood = value; }
        public int Idbill { get => idbill; set => idbill = value; }
        public int Count { get => count; set => count = value; }
    }
}
