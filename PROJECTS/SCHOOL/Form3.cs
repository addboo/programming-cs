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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "password = student.123; " +
                                       "userid = student; " +
                                       "server = nyc.openlab.gr; " +
                                       "database = school";

                string query = "select * from school.students;";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand myCommand = new MySqlCommand(query, myConn);
                  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                
                MyAdapter.SelectCommand = myCommand;
                
                DataTable dTable = new DataTable();

                MyAdapter.Fill(dTable);

                dataGridView1.DataSource = dTable;   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
