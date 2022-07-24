using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Connect_Database
{
    internal class Dbcontion
    {
      
        // public String ConString = "Data Source=DESKTOP-TLCBGHU;Initial Catalog=MyTruck;Integrated Security=True";
        public SqlConnection Conn = new SqlConnection("Data Source=DESKTOP-63NGSLH;Initial Catalog=MyTruck;Integrated Security=True");
        
        public SqlDataAdapter Adapter;
        public DataSet ds;

        public void Query(String sql)
        {

            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();
            }
            Conn.Open();
            try
            {
                Adapter = new SqlDataAdapter(sql, Conn);
                ds = new DataSet();
                Adapter.Fill(ds, "EMP");
                Conn.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
