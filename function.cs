using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;


namespace examination_system
{
    internal class function
    {
        protected SqlConnection getConnection()
        {
            SqlConnection com=new SqlConnection();
            com.ConnectionString = "Server=DESKTOP-ROH2RC0; Database=examnation system; user=sa; password=Bb606@ali ";
            return com;
        }
        public DataSet getData(String query)
        {
            SqlConnection com = getConnection();
            SqlCommand cmd = com.CreateCommand();   
            cmd.Connection = com;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet(); 
            da.Fill(ds);
            return ds;
        }
        public void setData(String query, String msg) 
        {
            SqlConnection com = getConnection();
            SqlCommand cmd= new SqlCommand();
            cmd.Connection = com;
            com.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            com.Close();
            MessageBox.Show(msg,"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public SqlDataAdapter getForCombo(String query)
        {
            SqlConnection com = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = com;
            com.Open();
            cmd = new SqlCommand(query,com);
            SqlDataReader sdr= cmd.ExecuteReader();
            return (SqlDataAdapter)sdr[0];

        }
    }
}
