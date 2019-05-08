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
    public partial class Login : Form
    {

        private int prop_1 = 1;
        private MySqlConnection mysqlCon = dbConnection.getDBCon();

        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            checkUser();
            //if (userNameTxt.Text == "Nigansan" && passwordTxt.Text == "123" )
            /*
            if (mysqlCon != null)
            {
                MessageBox.Show("Welcome");
                new Home().Show();
                this.Hide();
                //new Home().ShowDialog();
            }
            else
            {
                MessageBox.Show("login  : " + "Login Faliure");


            }
            */
        }

        private void checkUser()
        {
            mysqlCon.Open();
            var userName = userNameTxt.Text;
            var password = passwordTxt.Text;
            MySqlCommand cmd = new MySqlCommand("select * from users where userName = @un and password = @ps", mysqlCon);
            cmd.Parameters.AddWithValue("@un", userName);
            cmd.Parameters.AddWithValue("@ps", password);

            MySqlDataReader reader = cmd.ExecuteReader();
            Console.WriteLine("called dataset");
            var res = reader.Read();
            Console.WriteLine(res);
            if (res == true)
            {
                MessageBox.Show("Welcome " + userName);
                new Home().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("login  : " + "Login Faliure");
                this.Hide();
            }
            mysqlCon.Close();


            //Console.WriteLine(ds.Tables[0].Rows[0]["userName"].ToString());

        }

        private void userNameTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }




}

