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

namespace Exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jayani\Documents\School..mdf;Integrated Security=True;Connect Timeout=30";
            string query = "SELECT * FROM Student";

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataSet set = new DataSet();

            adapter.Fill(set, "Student");
            

            DataRow row = set.Tables["Student"].NewRow();
            row["Id"] =txtid.Text;
            row["Student_Name"] =txtstuname.Text;
            row["DOB"] = txtdob.Text;
            row["Address"] = txtaddresss.Text;
            row["Contact.No"] = txtconNo.Text;
            set.Tables["Student"].Rows.Add(row);

            dataGridView1.DataSource = set.Tables["Student"];
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Update(set.Tables["Student"]);
            MessageBox.Show("Date saved in database successfully");
        }
    }
}
