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

namespace ADOFormDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=ABHINAV-RAJ-RAI\\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True");
        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    x.Text = "";
                }
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into emp2 values(" + txtId.Text + ",'" + txtName.Text + "'," + txtSalary.Text + ")", con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record inserted");
            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update emp2 set name ='" + txtName.Text + "',Salary =" + txtSalary.Text + " where Id=" + txtId.Text + "", con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record updated");
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from Emp2 where id=" + txtId.Text + "", con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record deleted");
            con.Close();
        }
    }
}
