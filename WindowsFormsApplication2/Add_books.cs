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
    public partial class Add_books : Form
    {
        private MySqlConnection mysqlCon = dbConnection.getDBCon();
        private bool editBook = false;
        int i = 0;
        public Add_books()
        {
            InitializeComponent();
            Load_Book_Data();
        }

        private void bookTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveBook_Click(object sender, EventArgs e)
        {
            addBook();
        }

        private void addBook()
        {
            if (bookTitle.Text != "" && isbn.Text != "" && authorName.Text != "" && language.SelectedItem != null && qty.Text != "")
            {
                mysqlCon.Open();
                var booktitle = bookTitle.Text;
                var isbnNo = isbn.Text;
                var authName = authorName.Text;
                var lang = language.SelectedItem.ToString();
                var quantity = qty.Text;
                var date = DateTime.Today.ToString("dd-mm-yyyy");
                var time = DateTime.Now.ToString("h:mm:ss tt");

                Console.WriteLine(date);
                Console.WriteLine(time);
                var timestamp = date + " " + time;

                MySqlCommand cmd = new MySqlCommand("INSERT INTO book (`Name`,`isbn`,`Author`,`Language`,`IniQty`,`CreatedAt`) VALUES (@bt,@is,@an,@lan,@qt,@ts)", mysqlCon);
                cmd.Parameters.AddWithValue("@bt", booktitle);
                cmd.Parameters.AddWithValue("@is", isbnNo);
                cmd.Parameters.AddWithValue("@an", authName);
                cmd.Parameters.AddWithValue("@lan", lang);
                cmd.Parameters.AddWithValue("@qt", quantity);
                cmd.Parameters.AddWithValue("@ts", timestamp);

                int res = cmd.ExecuteNonQuery();

                if (res < 0)
                {
                    MessageBox.Show("Insert Failed");
                    Console.WriteLine("Insert Failed");
                }
                else
                {
                    MessageBox.Show("Data Successfully Intersted!");
                }
            }
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

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked)
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
                else if (checkBox2.Checked)
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
                else if (checkBox3.Checked)
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

        private void Reset_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            textBox1.Text = "";
            Load_Book_Data();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            editBook = true;
            saveBook.Enabled = false;
            button1.Enabled = true;
            bookTitle.Text = dataGridView1.SelectedCells[1].Value.ToString();
            authorName.Text = dataGridView1.SelectedCells[2].Value.ToString();
            isbn.Text = dataGridView1.SelectedCells[3].Value.ToString();
            language.SelectedItem = dataGridView1.SelectedCells[4].Value.ToString();
            qty.Text = dataGridView1.SelectedCells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bookTitle.Text != "" && isbn.Text != "" && authorName.Text != "" && language.SelectedItem != null && qty.Text != "")
            {
                mysqlCon.Open();
                var booktitle = bookTitle.Text;
                var isbnNo = isbn.Text;
                var authName = authorName.Text;
                var lang = language.SelectedItem.ToString();
                var quantity = qty.Text;
                var date = DateTime.Today.ToString("dd-mm-yyyy");
                var time = DateTime.Now.ToString("h:mm:ss tt");

                Console.WriteLine(date);
                Console.WriteLine(time);
                var timestamp = date + " " + time;

                MySqlCommand cmd = new MySqlCommand("UPDATE `book` SET `Name`=@bt,`isbn`=@is,`Author`=@an,`Language`=@lan,`IniQty`=@qt,`CreatedAt`=@ts WHERE id=" + i + "", mysqlCon);
                cmd.Parameters.AddWithValue("@bt", booktitle);
                cmd.Parameters.AddWithValue("@is", isbnNo);
                cmd.Parameters.AddWithValue("@an", authName);
                cmd.Parameters.AddWithValue("@lan", lang);
                cmd.Parameters.AddWithValue("@qt", quantity);
                cmd.Parameters.AddWithValue("@ts", timestamp);

                int res = cmd.ExecuteNonQuery();

                if (res < 0)
                {
                    MessageBox.Show("Update Failed");
                    Console.WriteLine("Update Failed");
                }
                else
                {
                    MessageBox.Show("Data Successfully Updated!");
                }
                mysqlCon.Close();
            }
            else
            {
                MessageBox.Show("Please fill in all the fields");
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
