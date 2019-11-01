using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject
{
    class KetNoi
    {
        private static String kn = @"Data Source=DESKTOP-6S9SVVV\SQLEXPRESS;Initial Catalog=QLTHUOC;Integrated Security=True";
        private static SqlConnection TaoKetNoi()
        {
            return new SqlConnection(kn);
        }
        public static DataTable LayDL(String sql)
        {
            SqlConnection cnn = TaoKetNoi();
            cnn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sql, cnn);
            sda.Fill(dt);
            cnn.Close();
            sda.Dispose();
            return dt;
        }
        public static void Function(String sql)
        {
            SqlConnection cnn = TaoKetNoi();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
            cmd.Dispose();
        }
        public static SqlDataReader check(String sql)
        {
            SqlConnection cnn = TaoKetNoi();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public static void autocompleteTextbox(Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox a, String sql)
        {
            SqlConnection cnn = TaoKetNoi();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            AutoCompleteStringCollection myConnection = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                myConnection.Add(dr.GetString(0));
            }
            a.AutoCompleteCustomSource = myConnection;
            cnn.Close();
        }
        public static void autocompleteTextbox(TextBox a, String sql)
        {
            SqlConnection cnn = TaoKetNoi();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            AutoCompleteStringCollection myConnection = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                myConnection.Add(dr.GetString(0));
            }
            a.AutoCompleteCustomSource = myConnection;
            cnn.Close();
        }
    }
}
