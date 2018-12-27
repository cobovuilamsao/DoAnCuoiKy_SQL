using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace Coffee_Store_Management_Software.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance
        { get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set => instance = value; // only interal role can be touched into this class by using  type of private 
        }
        private DataProvider(){}

               

        private string connect = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=Coffee_Shop_Management_Software;Integrated Security=True";

       



        // select count *
        public object Executescalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection cnn = new SqlConnection(connect))
            {
                cnn.Open();
                SqlCommand comman = new SqlCommand(query, cnn);
                //comman.Parameters.AddWithValue("@UserName", ID);
                if (parameter != null)
                {
                    string[] listparameter = query.Split(' ');
                    int i = 0;
                    foreach (string item in listparameter)
                    {
                        if (item.Contains('@'))
                        {
                            comman.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter bridgeconnect = new SqlDataAdapter(comman);

                data = comman.ExecuteScalar();
                cnn.Close();
            }
            return data;

        }
        // this function return out type of number 
        public int Executenonquery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection cnn = new SqlConnection(connect))
            {
                cnn.Open();
                SqlCommand comman = new SqlCommand(query, cnn);
                //comman.Parameters.AddWithValue("@UserName", ID);
                if (parameter != null)
                {
                    string[] listparameter = query.Split(' ');
                    int i = 0;
                    foreach (string item in listparameter)
                    {
                        if (item.Contains('@'))
                        {
                            comman.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                //SqlDataAdapter bridgeconnect = new SqlDataAdapter(comman);

                data = comman.ExecuteNonQuery();
                cnn.Close();
            }
            return data;

        }
                
            // function return out type of datatable 
        public DataTable Executequery(string query, object[] parameter=null)
        {
            DataTable data = new DataTable();
            using (SqlConnection cnn = new SqlConnection(connect))
            {
                cnn.Open();
                SqlCommand comman = new SqlCommand(query, cnn);
                //comman.Parameters.AddWithValue("@UserName", ID);
                if(parameter!=null)
                {
                    string[] listparameter = query.Split(' ');
                    int i = 0;
                    foreach(string item in listparameter)
                    {
                        if(item.Contains('@'))
                        {
                            comman.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter bridgeconnect = new SqlDataAdapter(comman);

                data = new DataTable();
                bridgeconnect.Fill(data);

                cnn.Close();
            }
            return data;

        }


    }


    //    public DataTable Executequery(string query, string ID)
    //    {


    //        DataTable data = new DataTable();
    //        using (SqlConnection cnn = new SqlConnection(connect))
    //        {
    //            cnn.Open();
    //            SqlCommand comman = new SqlCommand(query,cnn);
    //            comman.Parameters.AddWithValue("@UserName",ID);

    //            SqlDataAdapter bridgeconnect = new SqlDataAdapter(comman);

    //            data = new DataTable();
    //            bridgeconnect.Fill(data);

    //            cnn.Close();
    //        }
    //        return data; 

    //        }


    //}
}
