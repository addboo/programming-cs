using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String myConnectionString = "password = student.123; " +
                                        "userid = student; " +
                                        "server = nyc.openlab.gr; " +
                                        "database = school";

            try
            {
                string query = "insert into school.students(firstname, lastname, tel) values('" + 
                                this.tbFname.Text + "','" + 
                                this.tbLname.Text + "','" + 
                                this.tbTel.Text + "');";

                 
                MySqlConnection myConn = new MySqlConnection(myConnectionString);
                  
                MySqlCommand myCommand = new MySqlCommand(query, myConn);
                MySqlDataReader MyReader2;

                myConn.Open();
                MyReader2 = myCommand.ExecuteReader();
                
                MessageBox.Show("Save Data");

                while (MyReader2.Read())
                {
                }

                myConn.Close();

                this.tbFname.Text = "";
                this.tbLname.Text = "";
                this.tbTel.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
