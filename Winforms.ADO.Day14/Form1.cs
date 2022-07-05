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

namespace Winforms.ADO.Day14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SqlConnection con = null;
        private SqlCommand cmd = null;
        private SqlDataReader reader= null;
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source =(localdb)\mssqllocaldb; initial catalog=master;Integrated Security=true;";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select cEmployeeCode,vFirstName,cCity,cState from Employee";

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            TxtEmpCode.Text = reader["cEmployeeCode"].ToString();
            TxtFirstName.Text = reader["vFirstName"].ToString();
            TxtCity.Text = reader["cCity"].ToString();
            TxtState.Text = reader["cState"].ToString();

            reader.Close();

            cmd.Dispose();

            con.Close();

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            this.ClearText();
        }

        public void ClearText()
        {
            TxtEmpCode.Text = "";
            TxtFirstName.Clear();
            TxtCity.Text = "";
            TxtState.Text = "";
            TxtEmpCode.Focus();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            using(con = new SqlConnection(@"Data Source = (localdb)\mssqllocaldb;Initial Catalog = master;Integrated Security=true"))
            {
                using (cmd = new SqlCommand("Select vFirstName,cCity, cState from Employee Where cEmployeeCode=@EmployeeCode", con))
                {
                    cmd.Parameters.AddWithValue("@EmployeeCode", TxtEmpCode.Text);

                    if(con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    using(reader = cmd.ExecuteReader())
                    {
                        if(reader.HasRows)
                        {
                            reader.Read();
                            TxtFirstName.Text = reader["vFirstName"].ToString();
                            TxtCity.Text = reader["cCity"].ToString();
                            TxtState.Text = reader["cState"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No Record");
                            this.ClearText();
                        }
                    }
                }
            }
        }
    }
}
