using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace CRUD_Sample1
{
    internal class Program
    {
        private const string ConnectionString = "sqlsever.database";
      
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = con.CreateCommand();
            IDataReader reader = null;

            string query = "SELECT * FROM production.brands WHERE brand_id > @id";
            cmd.CommandText = query;
            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = 5;

            con.Open();
            Console.WriteLine("Database Connected!");
            reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                Console.WriteLine("{0} -{1}", reader.GetInt32(0), reader.GetString(1));
            }
            
            con.Close();

            Console.ReadLine();
        }
    }
}
