using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using QLKSDTO;
namespace QLKSDAO
{
    public class DataProvider
    {
        public static string ChuoiKetNoi
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            }
        }
        public static DataTable TruyVan_LayDuLieu(string sql)
        {
            SqlConnection con = new SqlConnection(ChuoiKetNoi);
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable kq = new DataTable();
            da.Fill(kq);
            return kq;
        }
        public static DataTable SelectData(string sql, CommandType type, SqlParameter[] paras)
        {
            DataTable kq = new DataTable();
            SqlConnection sqlcon = new SqlConnection(ChuoiKetNoi);
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlcon;
            cmd.CommandText = sql;
            cmd.CommandType = type;
            if (paras != null)
                cmd.Parameters.AddRange(paras);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(kq);
            sqlcon.Close();
            return kq;
        }
        public static void ExcuteNonQuery(string sql, CommandType type, SqlParameter[] paras)
        {
            SqlConnection sqlcon = new SqlConnection(ChuoiKetNoi);
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlcon;
            cmd.CommandText = sql;
            cmd.CommandType = type;
            if (paras != null)
                cmd.Parameters.AddRange(paras);
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }


    }
}
