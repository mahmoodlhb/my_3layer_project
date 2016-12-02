using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using System.Data;

namespace Business
{
   public class login : DataAccesslayer
    {
        public string password;
        public int studentId;
        public DataTable loginclass(string password,int studentId)
        {
            base.ConnectToDatabase();
            string quary = "Select * from Student where studentId="+studentId+" and password="+password;
            DataTable dtbl = base.select(quary);
            base.DisconnectFromDatabase();
            return dtbl;
        }
    }
}
