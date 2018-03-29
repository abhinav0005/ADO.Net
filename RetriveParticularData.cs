using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO.Net
{
    class RetriveParticularData
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("Data Source=ABHINAV-RAJ-RAI\\SQLEXPRESS;Initial Catalog=Student1;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("SELECT * FROM STUDENT1", con);
                con.Open();
                SqlDataReader srdr = cmd.ExecuteReader();
                while(srdr.Read())
                {
                    Console.WriteLine(srdr["name"] + " " + srdr["email"]);
                }
                Console.ReadKey();
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
