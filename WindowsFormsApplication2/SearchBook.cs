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

namespace WindowsFormsApplication2
{
    public partial class SearchBooks : Form
    {
        private MySqlConnection mysqlCon = dbConnection.getDBCon();

        public SearchBooks()
        {
            InitializeComponent();
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mysqlCon.Open();
            MySqlCommand cmd = new MySqlCommand("select * from book", mysqlCon);

            cmd.ExecuteNonQuery();
            Console.WriteLine("searching books");
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            mysqlCon.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void bookTitle_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
