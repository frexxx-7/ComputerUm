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
    public partial class Computers : Form
    {
        public Computers()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            new AddComputer().Show();
            this.Hide();
        }
    }
}
