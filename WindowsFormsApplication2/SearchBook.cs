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
using Microsoft.VisualBasic;

namespace WindowsFormsApplication2
{
    public partial class SearchBooks : Form
    {
        private MySqlConnection mysqlCon = dbConnection.getDBCon();
        int i = 0;
        public SearchBooks()
        {
            InitializeComponent();
            lend.Enabled = false;
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lend_Click(object sender, EventArgs e)
        {
            String value = Interaction.InputBox("Insert Member ID", "Member ID", "", -1, -1);
            try
            {
                mysqlCon.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Lends (`memberID`,`bookID`,`lendDate`) VALUES (@bt,@is,@an)", mysqlCon);
                cmd.Parameters.AddWithValue("@bt", value);
                cmd.Parameters.AddWithValue("@is", i);
                cmd.Parameters.AddWithValue("@an", DateTime.Today.ToString("dd-mm-yyyy"));

                cmd.ExecuteNonQuery();
                Console.WriteLine("lending books");
                mysqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            lend.Enabled = true;
        }
    }
}
