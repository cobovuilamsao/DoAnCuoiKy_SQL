using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Coffee_Store_Management_Software.DTO
{
   public class Bill
    {
        private int idTable;
        private int statuses;
        private int idtable;
        private DateTime? datacheckOut;

        private DateTime? datacheckIn;
        private int discount;

        private int ID;
        public Bill(int id, DateTime? Datacheckin,DateTime? datacheckout,int status, int idtable, int discount)
        {
            this.ID = id;
            this.datacheckIn = DatacheckIn;
            this.datacheckOut= datacheckout;
            this.statuses = status;
            this.idtable = idtable;
            this.discount = discount;
        }
        public Bill(DataRow row)
        {
           this.ID = (int)row["id"];
          this.datacheckIn = (DateTime?)row["DateCheckIn"];

            if (row["DateCheckOut"].ToString() != "")
            {
                this.datacheckOut = (DateTime?)row["DateCheckOut"];
            }
            this.statuses = (int)row["statuses"];
            this.idtable = (int)row["idtable"];
            this.discount = (int)row["Discount"];
        }
        

        public int ID1 { get => ID; set => ID = value; }
        public DateTime? DatacheckIn { get => datacheckIn; set => datacheckIn = value; }
public DateTime? DatacheckOut { get => datacheckOut; set => datacheckOut = value; }
       
        public int IdTable { get => idTable; set => idTable = value; }
        public int Statuses { get => statuses; set => statuses = value; }
        public int Idtable { get => idtable; set => idtable = value; }
        public int Discount { get => discount; set => discount = value; }
    }
}
