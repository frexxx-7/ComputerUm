using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerUm
{
    public partial class Main : Form
    {
        public static string idUser, login;

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ComputersButton_Click(object sender, EventArgs e)
        {
            new Computers().Show();
            this.Hide();
        }

        public Main()
        {
            InitializeComponent();
        }
    }
}
