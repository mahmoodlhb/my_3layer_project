using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Business;
namespace Business
{
    public class studentsec : DataAccesslayer
    {
        public DataTable schedule()
        {
            base.ConnectToDatabase();
            string quary = "Select * from Tablevahed";
            DataTable dtbl = base.select(quary);
            base.DisconnectFromDatabase();
            return dtbl;
        }
    }
}
