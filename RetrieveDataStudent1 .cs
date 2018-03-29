using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO.Net
{
    class RetrieveDataStudent1
    {
        static void Main(string[] args)
        {
            new RetrieveDataStudent1().CreateTable();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("Data Source=ABHINAV-RAJ-RAI\\SQLEXPRESS;Initial Catalog=Student1;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("select * from student1", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while(rdr.Read())
                {
                    Console.WriteLine(rdr["id"] + " " + rdr["name"] + " " + rdr["email"] + " " + rdr["join_date"]);
                }
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine("Something went wrong.. " + e);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
