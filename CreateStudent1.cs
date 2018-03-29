using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO.Net
{
    class CreateStudent1
    {
        static void Main(string[] args)
        {
            new CreateStudent1().CreateTable();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("Data Source=ABHINAV-RAJ-RAI\\SQLEXPRESS;Initial Catalog=Student1;Integrated Security=True");
                // writing sql query  
                SqlCommand cm = new SqlCommand("create table student1(id int not null,name varchar(100), email varchar(50), join_date date)", con);  
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Table created Successfully");
                Console.Read();
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
    }
}
