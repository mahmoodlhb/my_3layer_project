using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class deleteuser : DataAccesslayer
    {       public string password;
            public int studentId;
        public void delete(string password,int studentId)
        {
            
            base.ConnectToDatabase();
            string quary = "DELETE from Tablevahed where studentId=" + studentId + " and password=" + password;
            DataTable dtbl = base.select(quary);
            base.DisconnectFromDatabase();
            return;
        }
    }
}
