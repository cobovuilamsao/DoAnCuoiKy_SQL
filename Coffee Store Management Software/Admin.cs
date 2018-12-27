using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Coffee_Store_Management_Software.DAO;
using Coffee_Store_Management_Software.DTO;

namespace Coffee_Store_Management_Software
{
    public partial class Admin : Form
    {
        BindingSource foodlist = new BindingSource();
        BindingSource accountlist = new BindingSource();
        BindingSource foodcategorylist = new BindingSource();
        BindingSource dinningtablelist = new BindingSource();
        private Account loginaccountadmin;

        public Account Loginaccountadmin { get => loginaccountadmin; set => loginaccountadmin = value; }

        public Admin(Account acc)
        {
            this.Loginaccountadmin = acc;
            InitializeComponent();
            
        }
       

        private void Admin_Load(object sender, EventArgs e)
        {
            loadingdatafromdatabase();
          
        }
     

        private void loadingdatafromdatabase()
        {
            dgvfood.DataSource = foodlist;
            dgvaccount.DataSource = accountlist;
            dgvcategory.DataSource = foodcategorylist;
            dgvtable.DataSource = dinningtablelist;

            //string data = "execute Avral_GetaccountbyUsername @UserName";
            //dgvaccount.DataSource = DataProvider.Instance.Executequery(data,new object[] {"Caogiachuc"});

            // dgvprofit.DataSource= DataProvider.Instance.Executequery("select * from bill where statuses = 1");
           // loadingaccount();
            loadinglishfood();
            loadingaccount();
            loaddatetimepickerbill();
            loadlistdatebyday(datefrom.Value,dateto.Value);
            loadingcategory();
            addfoodbinding();
            addcategorybinding();
          
            loadingcategoryforcombobox(cmbfoodcategory);
            addaccountbinding();


            loadingdinningtable();
            adddiningtablebinding();
            //loadingtableforcombobox(cmbstatus);

        }
       public void loadingdinningtable()
        {

            dinningtablelist.DataSource = TableDAO.Instance.Loadinglisttable();
            
        }
        void adddiningtablebinding()
        {
            try
            {
                txttableNAME.DataBindings.Add(new Binding("Text", dgvtable.DataSource, "Name", true, DataSourceUpdateMode.Never));
                txttableID.DataBindings.Add(new Binding("Text", dgvtable.DataSource, "Id1", true, DataSourceUpdateMode.Never));
                //
                //string id = txttableID.Text;
            }
            catch { }



        }
      

        void addaccountbinding()
        {
            txtaccountusername.DataBindings.Add(new Binding("Text", dgvaccount.DataSource, "Username"));
            txtaccountdisplayname.DataBindings.Add(new Binding("Text", dgvaccount.DataSource, "DisPlayName"));
            numericUpDowntypeofaccount.DataBindings.Add(new Binding("Value", dgvaccount.DataSource, "Type"));
         
        }
        void loadingaccount()
        {
            accountlist.DataSource = AccountDAO.Instance.getlistaccount();
        }
        void loadinglishfood()
        {
            foodlist.DataSource = FoodDAO.Instance.loadingfood();
        }
        void loadingcategory()
        {
            foodcategorylist.DataSource = FoodCategoryDAO.Instance.loadfoodcategory();
        }

        #region methods
        public void loaddatetimepickerbill()
        {
            DateTime today = DateTime.Now;
            datefrom.Value = new DateTime(today.Year,today.Month,1);
            dateto.Value = datefrom.Value.AddMonths(1).AddDays(-1);

        }
            



       public void loadlistdatebyday (DateTime checkin, DateTime checkout)
        {
            dgvprofit.DataSource = BillDAO.Instance.getprofitbyday(checkin,checkout);  
        }


        public void addfoodbinding()
        {//true allowed by press type data between datasource and textbox become the one and contrary
           // DataSourceUpdateMode.Never :allowed by changing data each other
            txtfoodnamedisplay.DataBindings.Add(new Binding("text", dgvfood.DataSource, "name",true,DataSourceUpdateMode.Never));
            txtfoodID.DataBindings.Add(new Binding("text", dgvfood.DataSource,"id", true, DataSourceUpdateMode.Never));
            txtprice.DataBindings.Add(new Binding("text", dgvfood.DataSource, "price", true, DataSourceUpdateMode.Never));
        }

        public void addcategorybinding()
        {
            //true allowed by press type data between datasource and textbox become the one and contrary
            // DataSourceUpdateMode.Never :allowed by changing data each other
            txtcategoryID.DataBindings.Add(new Binding("text", dgvcategory.DataSource, "id", true, DataSourceUpdateMode.Never));
           txtcategoryname.DataBindings.Add(new Binding("text", dgvcategory.DataSource, "name", true, DataSourceUpdateMode.Never));
            
        }

        public void loadingcategoryforcombobox(ComboBox cb)
        {
            cb.DataSource = FoodCategoryDAO.Instance.loadfoodcategory();
            cb.DisplayMember = "name";

        }

        
        #endregion

        #region events


        private void btnprofitreview_Click(object sender, EventArgs e)
        {
            loadlistdatebyday(datefrom.Value, dateto.Value);
        

        }

        private void txtfoodID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //int id = Convert.ToInt32(txtcategoryID.Text);
                // in the case id=0 or null so see below
                if (dgvfood.SelectedCells.Count > 0)
                {
                    int id = (int)dgvfood.SelectedCells[0].OwningRow.Cells["idCategory"].Value;
                    //meaning :.SelectedCells[0]// chossing  any cell 
                    //OwningRow : chossing one row 
                    //cell: chossing all cells of that row
                    // then taking out the Name's cell is idcategory
                    //  if (Int32.TryParse(txtcategoryID.Text, out id)) // trying to pressing type become id if successfully so 
                    // {

                    FoodCategory category = FoodCategoryDAO.Instance.GetcategorybyID(id);
                    cmbfoodcategory.SelectedItem = category;
                    int index = -1;
                    int i = 0;
                    foreach (FoodCategory item in cmbfoodcategory.Items)
                    {
                        if (item.Id == category.Id)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }
                    cmbfoodcategory.SelectedIndex = index;

                    // }
                }
            }
            catch { }
        }
        #endregion

        private void btnfoodinsert_Click(object sender, EventArgs e)
        {
            txtfoodID.Text = null;
            string name = txtfoodnamedisplay.Text;
            int categoryID = (cmbfoodcategory.SelectedItem as FoodCategory).Id;
            float price = float.Parse(txtprice.Text);
            if(FoodDAO.Instance.insertfood(name,categoryID,price))
            {
                MessageBox.Show("Inserted successfully");
                loadinglishfood();
                if (insertfood != null) insertfood(this, new EventArgs());

            }
            else
            {
                MessageBox.Show("Something was wrong during inserting food");
            }
        }

        private void btnafoodedit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtfoodID.Text);
            string name = txtfoodnamedisplay.Text;
            int categoryID = (cmbfoodcategory.SelectedItem as FoodCategory).Id;
            float price = float.Parse(txtprice.Text);

            if (FoodDAO.Instance.updatefood(id,name, categoryID, price))
            {
                MessageBox.Show("Updated successfully");
                loadinglishfood();
                if (updatefood != null) updatefood(this, new EventArgs());

            }
            else
            {
                MessageBox.Show("Something was wrong during updating food");
            }
        }

        private void btnfoodremove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtfoodID.Text);
              if (FoodDAO.Instance.deletefood(id))
            {
                MessageBox.Show("deleted successfully");
                loadinglishfood();
                if (deletefood != null) deletefood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Something was wrong during updating food");
            }
        }

        private event EventHandler insertfood;
        public event EventHandler Insertfood
        {
            add { insertfood += value; }
            remove { insertfood -= value; }
        }
        private event EventHandler deletefood;
        public event EventHandler Deletefood
        {
            add { deletefood += value; }
            remove { deletefood -= value; }
        }
        private event EventHandler updatefood;
        public event EventHandler Updatefood
        {
            add { updatefood += value; }
            remove { updatefood -= value; }
        }



        public List<Food> SearchingfoodbyName(string name)
        {
            List<Food> listfood = FoodDAO.Instance.SearchingfoodbyName(name);
            return listfood;
        }


        private void btnfoodsearch_Click(object sender, EventArgs e)
        {
          foodlist.DataSource=  SearchingfoodbyName(txtfoodnamesearch.Text);
        }

        private void btnfoodview_Click(object sender, EventArgs e)
        {
            loadinglishfood();
        }

        private void btnaccountinsertview_Click(object sender, EventArgs e)
        {
            loadingaccount();
        }


        void addaccount(string username ,string dispalyname ,int type)
        {
            if(AccountDAO.Instance.insertaccount(username,dispalyname,type))
            {
                MessageBox.Show("Added successfully");
            }
            else
            {
                MessageBox.Show("adding account was Failed");
            }
            loadingaccount();
        }
        void updateaccount(string username, string dispalyname, int type)
        {
            if (AccountDAO.Instance.updateaccount(username, dispalyname, type))
            {
                MessageBox.Show("Updated successfully");
                if (updateaccountadmin != null)
                {
                    updateaccountadmin(this, new AccountEventadmin(AccountDAO.Instance.getaccountbyusername(username)));
                }
            }
            else
            {
                MessageBox.Show("Updating account was Failed");
            }
            loadingaccount();
        }
        void deleteaccount(string username)
        {
            if (Loginaccountadmin.Username.Equals(username))
            {
                MessageBox.Show("please! don't be deleted yourself");

            }
            else
            {
                if (AccountDAO.Instance.deleteaccount(username))
                {
                    MessageBox.Show("Deleted successfully");
                }
                else
                {
                    MessageBox.Show("Deleting account was Failed");
                }

            }
            
            loadingaccount();
        }

        private void btnaccountinsert_Click(object sender, EventArgs e)
        {
            string username = txtaccountusername.Text;
            string displayname = txtaccountdisplayname.Text;
            // int id = (numericUpDowntypeofaccount.Tag as Account).Type;
            int id = (int)numericUpDowntypeofaccount.Value;
            addaccount(username, displayname, id);
        }


        private void btnaccountremove_Click(object sender, EventArgs e)
        {
            string username = txtaccountusername.Text;
          
            deleteaccount(username);
        }

        private void btnaccountedit_Click(object sender, EventArgs e)
        {
            string username = txtaccountusername.Text;
            string displayname = txtaccountdisplayname.Text;
            // int id = (numericUpDowntypeofaccount.Tag as Account).Type;
            int id = (int)numericUpDowntypeofaccount.Value;
            updateaccount(username, displayname, id);

        }
        void resetpassword(string username)
        {
            if (AccountDAO.Instance.Resetingpassword(username))
            {
                MessageBox.Show("Reseted successfully");
            }
            else
            {
                MessageBox.Show("Reseting  account was Failed");
            }
            loadingaccount();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            string username = txtaccountusername.Text;

            resetpassword(username);
        }

        private event EventHandler<AccountEventadmin> updateaccountadmin;
        public event EventHandler<AccountEventadmin> Updateaccountadmin
        {
            add { updateaccountadmin += value; }
            remove { updateaccountadmin -= value; }
        }

        public class AccountEventadmin : EventArgs
        {
            private Account acc;

            public Account Acc { get => acc; set => acc = value; }
            public AccountEventadmin(Account acc)
            {
                this.acc = acc;
            }
        }

      

        private void btncategoryinsert_Click(object sender, EventArgs e)
        {
            txtcategoryID.Text = null;
            string namecategory = txtcategoryname.Text;
            string categoryID = txtcategoryID.Text;
            if (FoodCategoryDAO.Instance.insertfoodcategory(namecategory))
            {
                MessageBox.Show("Inserted successfully");
                loadingcategory();
                loadinglishfood();
                loadingcategoryforcombobox(cmbfoodcategory);
                if (insertcategory != null) insertcategory(this, new EventArgs());

            }
            else
            {
                MessageBox.Show("Something was wrong during inserting food");
            }
        }

        private event EventHandler insertcategory;
        public event EventHandler Insertcategory
        {
            add { insertcategory += value; }
            remove { insertcategory -= value; }
        }

        private void btncategoryedit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtcategoryID.Text);
            string categoryname = txtcategoryname.Text;
          
          

            if (FoodCategoryDAO.Instance.updatecategory(categoryname,id))
            {
                MessageBox.Show("Updated successfully");
                loadingcategory();
                loadinglishfood();
                loadingcategoryforcombobox(cmbfoodcategory);
                if (updatecategory != null) updatecategory(this, new EventArgs());

            }
            else
            {
                MessageBox.Show("Something was wrong during updating food");
            }
        }

        private event EventHandler updatecategory;
        public event EventHandler Updatecategory
        {
            add { updatecategory += value; }
            remove { updatecategory -= value; }
        }

        private void btncategoryremove_Click(object sender, EventArgs e)
        {
            try
            {
                int idcategory = Convert.ToInt32(txtcategoryID.Text);
                List<Food> datafood = FoodDAO.Instance.loadingfood();
                foreach (Food items in datafood)
                {

                    FoodCategoryDAO.Instance.deletefoodcategory(idcategory, items.Id);
                  
                }
                MessageBox.Show("Deleted successfully");
                if (deletecategory != null) deletecategory(this, new EventArgs());
                loadingcategory();
                loadinglishfood();
                loadingcategoryforcombobox(cmbfoodcategory);

            }
            catch
            {
                MessageBox.Show("Something was wrong active during deletion .\n"
                    +"Perhaps this category is being existed in any-table in order to guarantee the binding feature .\n"
                    +"however, if you really wanna cetainly do it .\n"
                    +"Let deleting food in food-table before deleting in category ");
            }

            
                    
                
            
           
        }
        private event EventHandler deletecategory;
        public event EventHandler Deletecategory
        {
            add { deletecategory += value; }
            remove { deletecategory -= value; }
        }

        private void cmbfoodcategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btncategoryview_Click(object sender, EventArgs e)
        {
            loadingcategory();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvtable_Click(object sender, EventArgs e)
        {
            loadingtableforcombobox(cmbtablestatus);

        }
        public void inserttablefunction()
        {
             string nametable = txttableNAME.Text;
            txttableID.Text = ((TableDAO.Instance.getmaxidbill()+1).ToString());
           //cmbstatus.Text = "Empty";
           
            if (TableDAO.Instance.inserttable(nametable, cmbtablestatus.Text))
            {
                MessageBox.Show("Inserted another successfully");
                loadingdinningtable();
                adddiningtablebinding();
                loadingtableforcombobox(cmbtablestatus);
                if (inserttable != null) inserttable(this, new EventArgs());

            }
            else
            {
                MessageBox.Show("Something was wrong during inserting food");
            }
        }

        public void loadingtableforcombobox(ComboBox cb)
        {


            int id = Convert.ToInt32(txttableID.Text);

           //// cmbstatus.DataBindings.Add(new Binding("SelectedValue", dgvtable.DataSource, "Status", true));
           cmbtablestatus.DataSource = DataProvider.Instance.Executequery("select * from tablefood where id=" + id);

         //   cb.DataSource = TableDAO.Instance.Loadinglisttable();
            cb.DisplayMember = "Status";
           // cb.SelectedIndex = 1;

        }

        private void btneatingtableinsert_Click(object sender, EventArgs e)
        {

            inserttablefunction();

        }
        private event EventHandler inserttable;
        public event EventHandler Inserttable
        {
            add { inserttable += value; }
            remove { inserttable -= value; }
        }

        private event EventHandler updatetable;
        public event EventHandler Updatetable
        {
            add { updatetable += value; }
            remove { updatetable -= value; }
        }


        private event EventHandler deletetable;
        public event EventHandler Deletetable
        {
            add { deletetable += value; }
            remove { deletetable -= value; }
        }
        private void dgvtable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void deletetablefunction()
        {
            


        }

        void removetable()
        {
            //try
            //{
                int idtable = Convert.ToInt32(txttableID.Text);
                string status = cmbtablestatus.Text;
            if (status == "Empty")
            {
                DataProvider.Instance.Executequery(string.Format("delete from tablefood where id={0} and status='Empty'",idtable));


                MessageBox.Show("Deleted successfully");
                loadingdinningtable();
                loadingtableforcombobox(cmbtablestatus);
                if (deletetable != null) deletetable(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("this table is existed so you can not do this activity");
            }

              







        }

        private void btneatingtableremove_Click(object sender, EventArgs e)
        {
            removetable();



        }
        void updatetablefunction()
        {
            int id = Convert.ToInt32(txttableID.Text);
            string nametable = txttableNAME.Text;
            string status = cmbtablestatus.Text;

            if (TableDAO.Instance.updatetable(id,nametable,status))
            {
                MessageBox.Show("Updated successfully");
                loadingtableforcombobox(cmbtablestatus);
                loadingdinningtable();
                 if (updatetable != null) updatetable(this, new EventArgs());

            }
            else
            {
                MessageBox.Show("Something was wrong during updating table");
            }




        }

        private void btneatingtableedit_Click(object sender, EventArgs e)
        {
            updatetablefunction();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            Profit frm = new Profit();
            //delPassData del=new delPassData(frm.funData); // remove this line
            frm.Profit_Load(sender,e,this.datefrom.Value,this.dateto.Value); // passing data directly to function
            frm.Show();
        }




       
    }
}
