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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addBooks_Click(object sender, EventArgs e)
        {
            new Add_books().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new SearchBooks().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new RemoveBook().ShowDialog();
        }
    }
}
