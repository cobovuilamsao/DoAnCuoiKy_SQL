using Coffee_Store_Management_Software.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Store_Management_Software
{
    public partial class Profit : Form
    {
        public Profit()
        {
            InitializeComponent();
        }

        public void funData(DateTime checkin, DateTime checkout)
        {
           


        }

        public void Profit_Load(object sender, EventArgs e, DateTime checkin, DateTime checkout)
        {

            

           


            Profitreport rp1 = new Profitreport();
            rp1.SetDataSource(BillDAO.Instance.getprofitbyday(checkin, checkout).DefaultView);

            crystalReportViewer1.ReportSource = rp1;

        }
    }
}
