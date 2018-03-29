using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO.Net
{
    class ConnectionTest1
    {
        static void Main(string[] args)
        {
            using (SqlConnection con = new SqlConnection("Data Source=ABHINAV-RAJ-RAI\\SQLEXPRESS;Initial Catalog=Student1;Integrated Security=True"))
            {
                con.Open();
                Console.WriteLine("Connected to server");
                Console.ReadKey();
            }

        }
    }
}
