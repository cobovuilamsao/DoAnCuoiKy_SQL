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
    public partial class Checkoutform : Form
    {
        public Checkoutform()
        {
            InitializeComponent();
        }

        public void Checkoutform_Load(object sender, EventArgs e,string query)
        {


            //lablesum.Text = sum.ToString();
            //labletid.Text = idtable.ToString();


            //MessageBox.Show(sumfood.ToString());
           // query = string.Format("execute CheckOutSQL_pro {0},{1}", sumfood, tableid);


            CheckOut rp1 = new CheckOut();
            rp1.SetDataSource(DataProvider.Instance.Executequery(query).DefaultView);

            crystalReportViewer1.ReportSource = rp1;


            //  DataProvider.Instance.Executequery(string.Format(" update tablefood set username = null, status = 'Empty' where id={0}", tableid);




           


        }


    }
}
