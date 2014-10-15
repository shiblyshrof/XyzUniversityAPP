using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XyzUniversityAPP
{
    public partial class StudentEntryUI : Form
    {
        public StudentEntryUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string email = emailTextBox.Text;
            string address = addressTextBox.Text;

            string conn = @"server=SHIBLY-PC; database=XyzUniversity; integrated security=true";

            SqlConnection Connection = new SqlConnection();

            Connection.ConnectionString = conn;
            Connection.Open();

            string query = string.Format("INSERT INTO t_Student VALUES ('{0}','{1}','{2}')", name, email, address);

            SqlCommand command = new SqlCommand(query, Connection);
            int affectedrow = command.ExecuteNonQuery();
            if (affectedrow > 0)

                MessageBox.Show("insert success");

            else

                MessageBox.Show("problem");

        }
    }
}
