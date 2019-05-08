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
        public Add_books()
        {
            InitializeComponent();
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
            mysqlCon.Open();
            var booktitle = bookTitle.Text;
            var isbnNo  = isbn.Text;
            var authName = authorName.Text;
            var lang = language.SelectedItem.ToString();
            var quantity = qty.Text;
            var date = DateTime.Today.ToString("dd-mm-yyyy");
            var time = DateTime.Now.ToString("h:mm:ss tt");

            Console.WriteLine(date);
            Console.WriteLine(time);
            var timestamp = date + " " + time;

            MySqlCommand cmd = new MySqlCommand("INSERT INTO book (`Name`,`isbn`,`Author`,`Language`,`IniQty`,`CreatedAt`) VALUES (@bt,@is,@an,@lan,@qt,@ts)",mysqlCon);
            cmd.Parameters.AddWithValue("@bt", booktitle);
            cmd.Parameters.AddWithValue("@is", isbnNo);
            cmd.Parameters.AddWithValue("@an", authName);
            cmd.Parameters.AddWithValue("@lan", lang);
            cmd.Parameters.AddWithValue("@qt", quantity);
            cmd.Parameters.AddWithValue("@ts", timestamp);

            int res = cmd.ExecuteNonQuery();

            if(res < 0)
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
}
