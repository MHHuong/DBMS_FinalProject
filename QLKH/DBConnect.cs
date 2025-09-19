using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using System.Data;


namespace QLKH
{
    internal class DBConnect
    {

        private SqlConnection sqlConn;
        public DBConnect()
        {
            sqlConn = new SqlConnection(DBConfig.SqlStr);
        }
        public SqlConnection SqlConn { get => sqlConn; set => sqlConn = value; }

        public void OpenDatabase()
        {
            if (SqlConn == null)
            {
                SqlConn = new SqlConnection(DBConfig.SqlStr);
            }
            if (SqlConn.State == ConnectionState.Closed)
            {
                SqlConn.Open();
            }
        }

        public void CloseDatabase()
        {
            if (SqlConn != null && SqlConn.State == ConnectionState.Open)
            {
                SqlConn.Close();
            }
        }

        public DataTable Execute(string sqlStr)
        {
            OpenDatabase();
            SqlDataAdapter da = new SqlDataAdapter(sqlStr, SqlConn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CloseDatabase();
            return dt;
        }
        public DataTable Execute(string sqlStr, params SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            OpenDatabase();
            try
            {
                using (var cmd = new SqlCommand(sqlStr, SqlConn))
                {
                    if (parameters != null && parameters.Length > 0)
                        cmd.Parameters.AddRange(parameters);

                    using (var da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            finally
            {
                CloseDatabase();
            }
            return dt;
        }
        public int ExecuteNonQuery(string sqlStr, params SqlParameter[] parameters)
        {
            OpenDatabase();
            try
            {
                using (var cmd = new SqlCommand(sqlStr, SqlConn))
                {
                    if (parameters != null && parameters.Length > 0)
                        cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteNonQuery();
                }
            }
            finally { CloseDatabase(); }
        }

        public object ExecuteScalar(string sqlStr, params SqlParameter[] parameters)
        {
            OpenDatabase();
            try
            {
                using (var cmd = new SqlCommand(sqlStr, SqlConn))
                {
                    if (parameters != null && parameters.Length > 0)
                        cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteScalar();
                }
            }
            finally { CloseDatabase(); }
        }

        public DataTable ExecuteProcTable(string procName, params SqlParameter[] parameters)
        {
            var dt = new DataTable();
            OpenDatabase();
            try
            {
                using (var cmd = new SqlCommand(procName, SqlConn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (parameters != null && parameters.Length > 0)
                        cmd.Parameters.AddRange(parameters);
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            finally { CloseDatabase(); }
            return dt;
        }

        public int ExecuteProcNonQuery(string procName, params SqlParameter[] parameters)
        {
            OpenDatabase();
            try
            {
                using (var cmd = new SqlCommand(procName, SqlConn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (parameters != null && parameters.Length > 0)
                        cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteNonQuery();
                }
            }
            finally { CloseDatabase(); }
        }

        public static SqlParameter P(string name, SqlDbType type, object value, int size = 0, ParameterDirection dir = ParameterDirection.Input)
        {
            var p = new SqlParameter(name, type) { Direction = dir, Value = value ?? DBNull.Value };
            if (size > 0) p.Size = size;
            return p;
        }
    }
}
