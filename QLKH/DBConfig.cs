using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKH
{
    internal static class DBConfig
    {
        private static string sqlStr;

        public static string SqlStr { get => sqlStr; set => sqlStr = value; }

        public static void SqlConnectionString(string username, string password)
        {
            //SqlStr = $"Data Source=.;Initial Catalog=QLGYM;User ID={username};Password={password};Trust Server Certificate=True";
            SqlStr = $"Data Source=.;Initial Catalog=QLGYM_NEW;User ID={username};Password={password};Trust Server Certificate=True";

        }
    }
}
