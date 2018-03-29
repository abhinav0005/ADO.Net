using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO.Net
{
    class ConnectionTest
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("Data Source=ABHINAV-RAJ-RAI\\SQLEXPRESS;Initial Catalog=Student1;Integrated Security=True");
                con.Open();
                Console.WriteLine("Connected successfully");
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine("Something went wrong.." + e);
               
            }
            finally
            {
                con.Close();
            }
        }
    }
}
