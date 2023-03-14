using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace proje1.Database
{
    public class DbHelper
    {
        public static SqlConnection connection = new SqlConnection("Data Source=DESKTOP-JU7J8P7;Initial Catalog=Taxi;Integrated Security=True");

 
    }
}