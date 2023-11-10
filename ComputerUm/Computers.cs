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
            new AddComputer(null).Show();
        }

        private void Computers_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Computers_Load(object sender, EventArgs e)
        {
            loadInfoComputersIntoDB();
        }
        private void loadInfoComputersIntoDB()
        {
            DB db = new DB();

            ComputersDataGridView.Rows.Clear();

            string query = $"select computers.id, models.name, computers.dateOfPurchase, operatingSystem.name from computers " +
                $"join models on models.id = computers.idModel " +
                $"join operatingSystem on operatingSystem.id = computers.idOperatingSystem";

            db.openConnection();
            using (MySqlCommand mySqlCommand = new MySqlCommand(query, db.getConnection()))
            {
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                List<string[]> dataDB = new List<string[]>();
                while (reader.Read())
                {
                    dataDB.Add(new string[reader.FieldCount]);

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        dataDB[dataDB.Count - 1][i] = reader[i].ToString();
                    }
                }
                reader.Close();
                foreach (string[] s in dataDB)
                    ComputersDataGridView.Rows.Add(s);
            }
            db.closeConnection();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            loadInfoComputersIntoDB();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            new AddComputer(ComputersDataGridView[0, ComputersDataGridView.SelectedCells[0].RowIndex].Value.ToString()).Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand($"delete from computers where id = {ComputersDataGridView[0, ComputersDataGridView.SelectedCells[0].RowIndex].Value}", db.getConnection());
            db.openConnection();

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Компьюетр удален");

            }
            catch
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.closeConnection();
            loadInfoComputersIntoDB();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            ComputersDataGridView.Rows.Clear();

            string searchString = $"select computers.id, models.name, computers.dateOfPurchase, operatingSystem.name from computers " +
                $"join models on models.id = computers.idModel " +
                $"join operatingSystem on operatingSystem.id = computers.idOperatingSystem " +
                $"where concat (models.name, computers.dateOfPurchase, operatingSystem.name)  like '%{SearchTextBox.Text}%'";

            db.openConnection();
            using (MySqlCommand mySqlCommand = new MySqlCommand(searchString, db.getConnection()))
            {
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                List<string[]> dataDB = new List<string[]>();
                while (reader.Read())
                {
                    dataDB.Add(new string[reader.FieldCount]);

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        dataDB[dataDB.Count - 1][i] = reader[i].ToString();
                    }
                }
                reader.Close();
                foreach (string[] s in dataDB)
                    ComputersDataGridView.Rows.Add(s);
            }
            db.closeConnection();
        }
    }
}
