using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_Ass4
{
    public class DBConnect
    {
        protected SqlConnection conn = new SqlConnection("server=DESKTOP-LVLR7JR;database=BookStore;uid=sa;pwd=123456789");
    }
}
