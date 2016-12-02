using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

/*
 * کلاس کمکی اتصال به دیتا بیس
 * 
 * data access در لایه
 */
namespace DataAccess
{
    public class DataAccesslayer //مورفی متد ها برای اتصال به دیتا بیس به صورت سراسری
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable tbl;

        public DataAccesslayer()//ساخت یک شی از متدها به صورت سراسری
        {
            con =new SqlConnection();
            cmd=new SqlCommand();
            adapter = new SqlDataAdapter();
            cmd.Connection = con;
            adapter.SelectCommand = cmd;
          
        }
        public void ConnectToDatabase()// تابع اتصال به دیتا بیس
        {
            con.ConnectionString = "Data Source=mahmood;Initial Catalog=hw3_DB;Integrated Security=True";
            con.Open();
        }
        public void DisconnectFromDatabase()//تابع قطع ارتباط با دیتا بیس
        {
            con.Close();
        }
        public DataTable select(string query) //دستور سلکت از دیتا بیس
        {
            cmd.CommandText = query;
            tbl = new DataTable();
            try
            {
                adapter.Fill(tbl);
            }
            catch (Exception e)
            {
                var a = e;
            }
            
            return tbl; 
        }
        public void docommand(string query)//تابع اجرایی دستورات اضافه حذف آپدیت
        {
            cmd.CommandText=query;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                var s = e;
            }
           
        }
    }
}
