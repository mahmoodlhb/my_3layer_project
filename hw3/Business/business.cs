using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using System.Data;
using DataAccess;

namespace Business
{
    public class business:DataAccesslayer// impliment kardan class dataaccess va dastresi be tavabe an (ertebate facade)
    {                                       ///facade dar laye dataccess haman data accesslayer mibashad
        public int id;
        public string name;
        public string lastname;
        public string password;
        public int studentId;
        public int tell;
        public string address;
        public string sex;
        public int fildID;
        public int studentID;
        public int courseID;
        public void add()
        {
            base.ConnectToDatabase();
            string query = "insert into Student (name,lastname,password,studentId,tell,address,sex,fieldID) values (N'{0}',N'{1}',N'{2}','{3}',N'{4}',N'{5}',N'{6}','{7}')";
            query = string.Format(query, name, lastname, password, studentId, tell, address, sex, fildID);
            base.docommand(query);
            base.DisconnectFromDatabase();
        }
        public void addtosection(int a,int b)
        {
            base.ConnectToDatabase();
            string query = "insert into entekhabvahed (studentID,courseID) values ('{0}','{1}')";
            query = string.Format(query, a, b);
            base.docommand(query);
            base.DisconnectFromDatabase();
        }
        public void delete()
        {
            base.ConnectToDatabase();
            string querydel = "delete from Student where id={0}";
            querydel = string.Format(querydel, id);
            base.docommand(querydel);
            base.DisconnectFromDatabase();
        }
        public void update()
        {
            base.ConnectToDatabase();
            string queryup = "update Student SET name=N'{0}',lastname=N'{1}',password=N'{2}',studentId='{3}',tell=N'{4}',address=N'{5}',sex=N'{6}',fieldID='{7}'";
            queryup = string.Format(queryup, name, lastname, password, studentId, tell, address, sex, fildID);
            base.docommand(queryup);
            base.DisconnectFromDatabase();
        }
        public DataTable select()
        {
            base.ConnectToDatabase();
            string queryselect = "select * from Student";
            DataTable dtbl = base.select(queryselect);
            base.DisconnectFromDatabase();
            return dtbl;

        }
    }
}
