
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace casestudy1
{
    public class SQLConnection
    {
        public static SqlConnection con;
        public static SqlConnection getcon()
        {
            con = new SqlConnection("data source = ADMW46ZLPC1570\\SQLEXPRESS; Initial catalog = ZensarDB; " + "user id= sa; password = Temp1234");
            con.Open();
            return con;
        }
    }
}

