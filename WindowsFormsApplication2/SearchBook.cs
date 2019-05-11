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
            Load_Book_Data();
        }
        private void Load_Book_Data()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (bookTitle.Checked)
                {
                    if (textBox1.Text != "")
                    {
                        mysqlCon.Open();
                        MySqlCommand cmd = new MySqlCommand("select * from book where Name like('" + textBox1.Text + "')", mysqlCon);
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("searching books");
                        DataTable dt = new DataTable();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                        mysqlCon.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please type book name in the search box");
                    }
                }
                else if(byAuthor.Checked) {
                    if (textBox1.Text != "")
                    {
                        mysqlCon.Open();
                        MySqlCommand cmd = new MySqlCommand("select * from book where Author like('" + textBox1.Text + "')", mysqlCon);
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("searching books");
                        DataTable dt = new DataTable();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                        mysqlCon.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please type Author name in the search box");
                    }
                }
                else if (byIsbn.Checked)
                {
                    if (textBox1.Text != "")
                    {
                        mysqlCon.Open();
                        MySqlCommand cmd = new MySqlCommand("select * from book where isbn like('" + textBox1.Text + "')", mysqlCon);
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("searching books");
                        DataTable dt = new DataTable();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                        mysqlCon.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please type ISBN number in the search box");
                    }
                }
                else
                {
                    MessageBox.Show("Please select one checkbox");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            bookTitle.Checked = false;
            byAuthor.Checked = false;
            byIsbn.Checked = false;
            textBox1.Text = "";
            Load_Book_Data();

        }
    }
}
