using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Login : Form
    {

        private int prop_1 = 1;

        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            if (userNameTxt.Text == "Nigansan" && passwordTxt.Text == "123" )
            {
                MessageBox.Show("Welcome");
                new Home().ShowDialog();
                //new Home().ShowDialog();
            }
            else
            {
                MessageBox.Show("login  : " + "Login Faliure");


            }

        }

        private void userNameTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }




}

