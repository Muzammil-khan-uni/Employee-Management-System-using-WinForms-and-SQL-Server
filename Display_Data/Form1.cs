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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Display_Data
{
    public partial class Form1 : Form
    {
        private ConnectDB db;
        public Form1()
        {
            InitializeComponent();
            db = new ConnectDB();
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            load();
        }

        private void load()
        {
            string query = " Select * from Employees";
            DataTable dataTable = db.ExecuteQuery(query);
            dataGridView1.DataSource = dataTable;
        }



        private void btnadd_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Employees" + "(Name, Position, Salary, ID) VALUES" + "(@Name,@Position, @Salary, @ID)";
            db.ExecuteNonQuery(query,
                new SqlParameter("@ID", txtID.Text),
                new SqlParameter("@Name", txtname.Text),
                new SqlParameter("@Position", txtposition.Text),
                new SqlParameter("@Salary", decimal.Parse
                (txtsalary.Text)));
            load();


            MessageBox.Show("Employee added successfully!");
            btnload_Click(sender, e);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                string query = "UPDATE Employees SET Name = @Name, Position = @Position, Salary = @Salary WHERE ID = @ID";

                db.ExecuteNonQuery(query,
                    new SqlParameter("@ID", txtID.Text),
                    new SqlParameter("@Name", txtname.Text),
                    new SqlParameter("@Position", txtposition.Text),
                    new SqlParameter("@Salary", decimal.Parse(txtsalary.Text))
                );
                load();
                MessageBox.Show("Employee updated successfully!");
                
            }
            else
            {
                MessageBox.Show("Please enter a valid Employee ID.");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                string query = "DELETE FROM Employees WHERE ID = @ID";
                db.ExecuteNonQuery(query, new SqlParameter("@ID", txtID.Text));
                load();
                MessageBox.Show("Employee deleted successfully!");
               
            }
            else
            {
                MessageBox.Show("Please enter a valid Employee ID.");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtname.Text = "";
            txtposition.Text = "";
            txtsalary.Text = "";

        }

       
    }
}
