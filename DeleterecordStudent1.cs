using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO.Net
{
    class DeleterecordStudent1
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("Data Source=ABHINAV-RAJ-RAI\\SQLEXPRESS;Initial Catalog=Student1;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("DELETE FROM STUDENT1 WHERE ID ='105'",con);
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Record deleted..");
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine("Something went wront.." + e);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
