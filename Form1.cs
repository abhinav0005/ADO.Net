using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO.NetForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("Data Source=ABHINAV-RAJ-RAI\\SQLEXPRESS;Initial Catalog=BizRunTime;Integrated Security=True");
                con.Open();
                MessageBox.Show("Connected");
            }
            catch(Exception)
            {
                Console.WriteLine("excp : " );
            }
            finally
            {
                con.Close();
            }
        }
    }
}
