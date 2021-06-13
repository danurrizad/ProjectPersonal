using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SchedulLOG
{
    public class DataConn
    {
        public static string Conn = ConfigurationManager.ConnectionStrings["Schedulle"].ConnectionString;
    }
}