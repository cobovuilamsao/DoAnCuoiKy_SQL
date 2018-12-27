using Coffee_Store_Management_Software.DAO;
using Coffee_Store_Management_Software.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Coffee_Store_Management_Software.Admin;
using static Coffee_Store_Management_Software.PersonaInfor;
using Menu = Coffee_Store_Management_Software.DTO.Menu;

namespace Coffee_Store_Management_Software
{
    public partial class Tablemanager : Form
    {


        private Account loginaccount;
        private Button bang;

        private Account accountadmin;

        public Account Loginaccount { get => loginaccount; set { loginaccount = value; changeaccount(loginaccount.Type); } }

        public Account Accountadmin { get => accountadmin; set => accountadmin = value; }

        public Tablemanager(Account acc)
        {
          //  crystalReportViewer1.Visible = false;
           
            InitializeComponent();
            this.loginaccount = acc;
            
            changeaccount(loginaccount.Type);
            

            loadtable();
            loadcategory();


            

        }

       
        void changeaccount(int type)
        {
            
                adminMenuItem.Enabled =type==1;
            accountMenuItem.Text ="Informational Account (" + loginaccount.Displayname + ")";
      
           }

        #region methods
        void loadcategory()
        {
            List<FoodCategory> listcategory = FoodCategoryDAO.Instance.loadfoodcategory();
            cmbcategoryfood.DataSource = listcategory;
            cmbcategoryfood.DisplayMember = "name";
           




        }


        void loadfoodbyidcategory(int id)
        {

            List<Food> listfood = FoodDAO.Instance.loadlistdatafoodbyidcategory(id);
            cmbfood.DataSource = listfood;
            cmbfood.DisplayMember = "name";
          



        }

        string query; 
        void loadtable()
        {

            flowlayouttable.Controls.Clear();
            List<Table> tablelist = TableDAO.Instance.Loadinglisttable();
            foreach (Table items in tablelist)
            {
                Button btn = new Button() { Width = TableDAO.tablewidth, Height = TableDAO.tableheight };
                btn.Text = items.Name + Environment.NewLine + items.Status;
                btn.Click += btn_Click;   
                
               
                btn.Tag = items;// this tag , data type is object so that you can back up (save all things in this tag )
                              
                switch (items.Status)
                {
                    case "Existed": btn.BackColor = Color.Yellow;btn.Text +="-" +items.Username;
                       // MessageBox.Show("total:"+sumfood.ToString());


                      

                        break;

                    default:
                        btn.BackColor = Color.Gray;
                        break;

                }

                flowlayouttable.Controls.Add(btn);
                
            }



            loadmovingtablecombox(cmblistable);
            loadcollectingtablecombox(cmbcombiningtable);


        }

        void loadmovingtablecombox(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.Loadinglisttable();
            cb.DisplayMember = "Name";



        }
        void loadcollectingtablecombox(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.Loadinglisttable();
            cb.DisplayMember = "Name";



        }

        int sumfood;
        void showbill(int id)
        {
           
            lsvbill.Items.Clear();
        
            List<Menu> listbillinfor = MenuDAO.Instance.getlistmenubytableunchecking(id);
            decimal summ = 0;

            CultureInfo culutreInfo = new CultureInfo("vi-VN");
            culutreInfo.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            culutreInfo.DateTimeFormat.DateSeparator = "/";
            culutreInfo.NumberFormat.PercentDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = culutreInfo;
            foreach (Menu items in listbillinfor)
            {


                ListViewItem lsvItem = new ListViewItem(items.Foodname.ToString());
                lsvItem.SubItems.Add(items.Price.ToString("0,00.##"));
                lsvItem.SubItems.Add(items.Count.ToString());

                lsvItem.SubItems.Add(items.Sum.ToString("0,00.##"));
                summ += items.Sum;
              

                lsvbill.Items.Add(lsvItem);
                sumfood = lsvbill.Items.Count;

              //  MessageBox.Show("count:"+items.Count.ToString());
            }
            //txtSum.Text = summ.ToString("c");
            txtSum.Text = summ.ToString("0,00.##");

           
        }



        #endregion

        #region events
        public int tableid;
        public string usernametable;
        public string status ;
        private void btn_Click(object sender, EventArgs e)
        {

            bang = (Button)sender;
            usernametable = ((sender as Button).Tag as Table).Username;
            tableid = ((sender as Button).Tag as Table).Id1;
            lsvbill.Tag = (sender as Button).Tag;
            showbill(tableid);
            lab_NoTable.Text = ((sender as Button).Tag as Table).Name;

             status = ((sender as Button).Tag as Table).Status;
            if(status=="Empty")
            {
               // tbtresettable.Enabled = false;

            }
            else
            {
              //  tbtresettable.Enabled = true;
            }

            if (usernametable == "" || usernametable== loginaccount.Username|| status=="Empty")  
            {
                btnaddfood1.Enabled = true;
               

            }
            else if (usernametable != loginaccount.Username)
                {
                MessageBox.Show("you can not touch with this table");
                btnaddfood1.Enabled = false;
               // tbtresettable.Enabled = false;
            }


            int orginaltable = tableid;
            string originalstatus = status;

         //   MessageBox.Show(orginaltable + "" + status);


        }
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void personalInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonaInfor f = new PersonaInfor(loginaccount);
            f.Updateaccount += f_Updateaccount;
            f.ShowDialog();

        }

        private void f_Updateaccount(object sender, AccountEvent e)
        {
            accountMenuItem.Text = "Informational Account (" + e.Acc.Displayname + ")";
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Admin f = new Admin(accountadmin);
            f.Updateaccountadmin += f_updateaccountadmin;
            f.Loginaccountadmin = loginaccount;
            f.Insertfood += f_Insertfood;
            f.Deletefood += f_Deletefood;
            f.Insertcategory += f_insertcategory;
            f.Updatecategory += f_undatecategory;
            f.Deletecategory += f_deletecategory;
            f.Inserttable += f_inserttable;
            f.Updatetable += f_updatetable;
            f.Deletetable += f_deletetable;
          //  f.Update_account += f_update_account;
            f.ShowDialog();

        }

        private void f_deletetable(object sender, EventArgs e)
        {
            loadtable();
        }

        private void f_updatetable(object sender, EventArgs e)
        {

            loadtable();


        }

        private void f_inserttable(object sender, EventArgs e)
        {
            loadtable();
        }

        private void f_deletecategory(object sender, EventArgs e)
        {
            loadcategory();
        }

        private void f_undatecategory(object sender, EventArgs e)
        {
            loadcategory();
        }

        private void f_insertcategory(object sender, EventArgs e)
        {

            loadcategory();
        //    loadfoodbyidcategory((cmbcategoryfood.SelectedItem as FoodCategory).Id);
        //    if (lsvbill.Tag != null)
        //        showbill((lsvbill.Tag as Table).Id1);
        }

        private void f_updateaccountadmin(object sender, AccountEventadmin e)
        {
            accountMenuItem.Text = "Informational Account (" + e.Acc.Displayname + ")";
        }

        //private void f_update_account(object sender, AccountEventadmin e)
        //{
        //    accountMenuItem.Text = "Informational Account (" + e.Acc.Displayname + ")";
        //}

        private void f_Updatefood(object sender, EventArgs e)
        {
            loadfoodbyidcategory((cmbcategoryfood.SelectedItem as FoodCategory).Id);
            if(lsvbill.Tag!=null)
            showbill((lsvbill.Tag as Table).Id1);
        }

        private void f_Deletefood(object sender, EventArgs e)
        {
            loadfoodbyidcategory((cmbcategoryfood.SelectedItem as FoodCategory).Id);
            if (lsvbill.Tag != null)
                showbill((lsvbill.Tag as Table).Id1);
            loadtable();
        }

        private void f_Insertfood(object sender, EventArgs e)
        {
            loadfoodbyidcategory((cmbcategoryfood.SelectedItem as FoodCategory).Id);
            if (lsvbill.Tag != null)
                showbill((lsvbill.Tag as Table).Id1);
        }

        private void cmbcategoryfood_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            FoodCategory selected = cb.SelectedItem as FoodCategory;
            id = selected.Id;
            loadfoodbyidcategory(id);
        }
        #endregion
     

        private void btnaddfood_Click(object sender, EventArgs e)
        {

            try
            {
               




                Table table = lsvbill.Tag as Table;
                if (table == null)
                {

                    MessageBox.Show("Let choosing table ");
                    return;
                }

                int idbill = BillDAO.Instance.GetUnCheckBillIDByTableID(table.Id1);
                int foodid = (cmbfood.SelectedItem as Food).Id;
                int count = (int)numfoodcount.Value;

                if (idbill == -1)
                {

                    BillDAO.Instance.insertbill(table.Id1);
                    Bill_InforDAO.Instance.insertbillinfor(BillDAO.Instance.getmaxidbill(), foodid, count);
                    // loadtable();

                }
                else
                {

                    Bill_InforDAO.Instance.insertbillinfor(idbill, foodid, count);
                    // loadtable();


                }

                showbill(table.Id1);
                DataProvider.Instance.Executequery(string.Format("update tablefood set UserName=N'{0}' where id={1}", loginaccount.Username, tableid));
                //loadtable();
                
                bang.BackColor = Color.Yellow;
                
                bang.Text = lab_NoTable.Text+"\n"+status+"-"+ loginaccount.Username.ToString();


              
            }

            catch
            {
                MessageBox.Show("This food wasn't existed into food categorey. please check it again before choosing");
            }

            //DataProvider.Instance.Executenonquery("execute UpdatestatusTable");
            //flowlayouttable.Controls.Clear();
            //loadtable();

          
        }

        private void btncheckout_Click(object sender, EventArgs e)
        {

            Table table = lsvbill.Tag as Table;
            int idbill = BillDAO.Instance.GetUnCheckBillIDByTableID(table.Id1);
            int discount = (int)numdiscount.Value;
            double totalcost = double.Parse(txtSum.Text.Split(',')[0]);
            double grosslycost = totalcost - (totalcost / 100)*discount;
            
            if (idbill!=-1)
            {
               if(MessageBox.Show(string.Format("Are you sure for checking out at{0}\n GrosslyCosts= (Grosslycosts/100)*(Discount={1}-({1}/100)*{2}={3})",table.Name,totalcost,discount,grosslycost),"Notification",MessageBoxButtons.OKCancel)==System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.Checkout(idbill,discount,grosslycost);
                    showbill(idbill);
                    // loadtable();
                    bang.BackColor = Color.Gray;

                    bang.Text = lab_NoTable.Text + "\n" + status;
                }
            }
           

            //MessageBox.Show(sumfood.ToString());
            query = string.Format("execute CheckOutSQL_pro {0},{1}", sumfood, tableid);


            //CheckOut rp1 = new CheckOut();
            //rp1.SetDataSource(DataProvider.Instance.Executequery(query).DefaultView);
           
            //crystalReportViewer1.ReportSource = rp1;


            //  DataProvider.Instance.Executequery(string.Format(" update tablefood set username = null, status = 'Empty' where id={0}", tableid);




            Checkoutform frm = new Checkoutform();
            //delPassData del=new delPassData(frm.funData); // remove this line
            frm.Checkoutform_Load(sender, e,query); // passing data directly to function
            frm.Show();


        }


        //private void tbtremovetable_Click(object sender, EventArgs e)
        //{



        //    //  MessageBox.Show(tableid.ToString());
        //    //lab_NoTable.Text = ((sender as Button).Tag as Table).Name;
        //    //if (tableid == null)
        //    //{
        //    //    MessageBox.Show("");

        //    List<Bill_Infor> listbill = Bill_InforDAO.Instance.loadinglistbillinfo(); 
        //        foreach (Bill_Infor items in listbill)
        //    {
        //      //  DataProvider.Instance.Executequery(string.Format("delete billinfo where billinfo.idBill={0}", items.Idbill));
        //        Bill_InforDAO.Instance.deletebillinfobyidbill(items.Idbill);


        //    }

        //    List<Bill> listbill1 = BillDAO.Instance.loadinglistbill();

        //    foreach (Bill items in listbill1)
        //    {
        //        BillDAO.Instance.deletebillbyidtable(items.ID1, tableid);
        //       // DataProvider.Instance.Executequery(string.Format("delete Bill where Bill.idtable = {0}",tableid));

        //    }



        //    TableDAO.Instance.updatetable(tableid, lab_NoTable.Text, "Empty");
        //    loadtable();
        //    MessageBox.Show("Reset table successfully");
        //    lsvbill.Items.Clear();


            
        //}

        private void Tablemanager_Load(object sender, EventArgs e)
        {
            //tbtresettable.Enabled = false;
            // MessageBox.Show(loginaccount.Username.ToString());

            //Tablemanager a=new Tablemanager();
          // MessageBox.ShowSize.Height.ToString()+"-"+ a.Size.Width.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;

            List<Menu> listbillinfor = MenuDAO.Instance.getlistmenubytableunchecking(tableid);
           
       

            foreach (Menu items in listbillinfor)
            {



                MessageBox.Show(items.Count.ToString());
      
              

                //  MessageBox.Show("count:"+items.Count.ToString());
            }
            //txtSum.Text = summ.ToString("c");
           



        }
        int click = 0;
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("Choosing your table that you wanna move, please"), "Notification", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                



                int id1 = (lsvbill.Tag as Table).Id1;
                int id2 = (cmblistable.SelectedItem as Table).Id1;
                if (MessageBox.Show(string.Format("are you actually wanna move from {0} table to {1} table ", (lsvbill.Tag as Table).Name, (cmblistable.SelectedItem as Table).Name), "Notification", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    TableDAO.Instance.movingtable(id1, id2);
                    loadtable();
                }

            }

        }

        private void btnCollectingtable_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show(string.Format("Choosing your table that you wanna combine, please"), "Notification", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                int id1 = (lsvbill.Tag as Table).Id1;
                int id2 = (cmbcombiningtable.SelectedItem as Table).Id1;
                string name1 = (lsvbill.Tag as Table).Name;
                string name2 = (cmbcombiningtable.SelectedItem as Table).Name;

                if (MessageBox.Show(string.Format("are you actually wanna combining both of {0} table and {1} table to become one unique table ", name1, name2), "Notification", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    TableDAO.Instance.combininggtable(id2, id1);
                    loadtable();
                }
            }

        }

        private void flowlayouttable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolboxControl1_Click(object sender, EventArgs e)
        {

        }
    }

}
