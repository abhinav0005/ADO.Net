using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO.Net
{
    class InsertRecordStudent1
    {
        static void Main(string[] args)
        {
            new InsertRecordStudent1().CreateTable();
        }
        public void CreateTable()
        {
            SqlConnection con = new SqlConnection("Data Source=ABHINAV-RAJ-RAI\\SQLEXPRESS;Initial Catalog=Student1;Integrated Security=True");

            try
            {
                SqlCommand cmd = 
                new SqlCommand("insert into student1 values('105','Abhinav Raj','Abhinav@raj.com','12/03/2018')", con);
                
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Record inserted");
                Console.Read();
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong.."+e);
                Console.Read();
            }
            finally
            {
                con.Close();
            }
        }
    }
}
