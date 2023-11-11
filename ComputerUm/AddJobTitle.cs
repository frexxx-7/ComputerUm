using MySql.Data.MySqlClient;
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
    public partial class AddJobTitle : Form
    {
        public AddJobTitle()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand($"INSERT into jobtitle (name) values(@name)", db.getConnection());
            command.Parameters.AddWithValue("@name", NameTextBox.Text);
            db.openConnection();
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Должность добавлена");
                this.Close();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

            db.closeConnection();
        }

        private void CanceledButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
