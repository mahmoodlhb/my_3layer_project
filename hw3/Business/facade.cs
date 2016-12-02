using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using System.Data;
namespace Business
{
    public class facade 
    {
        public static DataTable loginuser(string a, int b)
        {
            Business.login login = new login();
            return login.loginclass(a,b);
        }
        public static DataTable getplan(int a)
        {
            Business.sec sec = new sec();
            return sec.plan(a);
        }
        public static void studentobj()
        {
            Business.student obj = new student();

        }
        public static DataTable getschedule()
        {
            Business.studentsec sec = new studentsec();
            return sec.schedule();
        }
    }
}
