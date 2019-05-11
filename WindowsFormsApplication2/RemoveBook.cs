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
    public partial class RemoveBook : Form
    {
        private MySqlConnection mysqlCon = dbConnection.getDBCon();
        int i=0;
        public RemoveBook()
        {
            InitializeComponent();
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

        private void remove_Click(object sender, EventArgs e)
        {
            if(i != 0)
            {

                try
                {
                    mysqlCon.Open();
                    MySqlCommand cmd = new MySqlCommand("delete from book where id="+i+"", mysqlCon);

                    cmd.ExecuteNonQuery();
                    Console.WriteLine("deleting books");
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    mysqlCon.Close();
                    Load_Book_Data();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
     
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (byBooktitle.Checked)
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
                else if (byBookauthor.Checked)
                {
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
            byBookauthor.Checked = false;
            byBooktitle.Checked = false;
            byIsbn.Checked = false;
            textBox1.Text = "";
            Load_Book_Data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
