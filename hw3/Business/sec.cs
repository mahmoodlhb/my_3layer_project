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
    public class sec:DataAccesslayer
    {
        
            public DataTable plan(int id)
        {
            base.ConnectToDatabase();
            string quary = "Select * from Tablevahed where id=(Select courseID from entekhabvahed where studentID=" + id + ")";
            DataTable dtbl = base.select(quary);
            base.DisconnectFromDatabase();
            return dtbl;
        }
    }
}
