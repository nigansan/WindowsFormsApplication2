using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication2
{
    public partial class AddMembers : Form
    {
        private MySqlConnection mysqlCon = dbConnection.getDBCon();
        private bool editBook = false;

        int i = 0;
        public AddMembers()
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
            Load_Member_Data();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void qty_TextChanged(object sender, EventArgs e)
        {

        }

        private void addMember()
        {
            if (memberName.Text != "" && memberID.Text != "" && address.Text != "" && contact.Text != "")
            {
                mysqlCon.Open();
                var membername = memberName.Text;
                var memID = memberID.Text;
                var Addre = address.Text;
                var conNo = contact.Text;

                MySqlCommand cmd = new MySqlCommand("INSERT INTO member (`Name`,`MemberID`,`Address`,`ContactNo`) VALUES (@bt,@is,@an,@qt)", mysqlCon);
                cmd.Parameters.AddWithValue("@bt", membername);
                cmd.Parameters.AddWithValue("@is", memID);
                cmd.Parameters.AddWithValue("@an", Addre);
                cmd.Parameters.AddWithValue("@qt", conNo);

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
                Load_Member_Data();
                mysqlCon.Close();
            }
            else
            {
                MessageBox.Show("Please fill in all the fields");
            }
        }

        private void Load_Member_Data()
        {
            try
            {
                mysqlCon.Open();
                MySqlCommand cmd = new MySqlCommand("select * from member", mysqlCon);

                cmd.ExecuteNonQuery();
                Console.WriteLine("searching members");
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

        private void saveBook_Click(object sender, EventArgs e)
        {
            addMember();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            editBook = true;
            AddMemberButton.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            memberName.Text = dataGridView1.SelectedCells[1].Value.ToString();
            memberID.Text = dataGridView1.SelectedCells[2].Value.ToString();
            address.Text = dataGridView1.SelectedCells[3].Value.ToString();
            contact.Text = dataGridView1.SelectedCells[4].Value.ToString();
        }


        private void Reset_Click(object sender, EventArgs e)
        {
            Reset_Command();
        }
        private void Reset_Command()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            textBox1.Text = "";
            Load_Member_Data();
            editBook = false;
            AddMemberButton.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            memberName.Text = "";
            memberID.Text = "";
            address.Text = "";
            contact.Text = "";
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
                        MySqlCommand cmd = new MySqlCommand("select * from member where Name like('" + textBox1.Text + "')", mysqlCon);
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("searching member");
                        DataTable dt = new DataTable();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                        mysqlCon.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please type member name in the search box");
                    }
                }
                else if (checkBox2.Checked)
                {
                    if (textBox1.Text != "")
                    {
                        mysqlCon.Open();
                        MySqlCommand cmd = new MySqlCommand("select * from member where MemberID like('" + textBox1.Text + "')", mysqlCon);
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("searching member");
                        DataTable dt = new DataTable();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                        mysqlCon.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please type member id in the search box");
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (i != 0)
            {

                try
                {
                    mysqlCon.Open();
                    MySqlCommand cmd = new MySqlCommand("delete from member where id=" + i + "", mysqlCon);

                    cmd.ExecuteNonQuery();
                    Console.WriteLine("deleting members");
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    mysqlCon.Close();
                    Reset_Command();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
