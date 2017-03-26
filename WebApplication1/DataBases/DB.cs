using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.DataBases
{
    public class DB
    {
        public static string ConnectionString
        {
            get
            {
                return System.Configuration.ConfigurationManager.ConnectionStrings["InsurSqlConnectionString"].ConnectionString;
            }
        }
    }
}