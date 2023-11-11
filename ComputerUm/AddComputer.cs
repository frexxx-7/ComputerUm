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
    public partial class AddComputer : Form
    {
        private string idComputer;
        public AddComputer(string idComputer)
        {
            InitializeComponent();

            loadInfoModel();
            loadInfoOperatingSystem();
            this.idComputer = idComputer;

            if (idComputer != null)
            {
                label1.Text = "Изменить компьютер";
                AddButton.Text = "Изменить";
                loadInfoComputerIntoDb();
            }
        }

        private void loadInfoComputerIntoDb()
        {
            DB db = new DB();
            string queryInfo = $"SELECT * FROM computers WHERE id = '{idComputer}'";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < ModelComboBox.Items.Count; i++)
                {
                    if (reader[1].ToString() != "")
                    {
                        if (Convert.ToInt32((ModelComboBox.Items[i] as ComboBoxItem).Value) == Convert.ToInt32(reader[1]))
                        {
                            ModelComboBox.SelectedIndex = i;
                        }
                    }
                }

                dateTimePicker1.Value = Convert.ToDateTime(reader[2].ToString());

                for (int i = 0; i < OperatingSystemComboBox.Items.Count; i++)
                {
                    if (reader[3].ToString() != "")
                    {
                        if (Convert.ToInt32((OperatingSystemComboBox.Items[i] as ComboBoxItem).Value) == Convert.ToInt32(reader[3]))
                        {
                            OperatingSystemComboBox.SelectedIndex = i;
                        }
                    }
                }
            }
            reader.Close();

            db.closeConnection();
        }

        private void loadInfoOperatingSystem()
        {
            DB db = new DB();
            string queryInfo = $"SELECT * FROM operatingSystem ";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = $" {reader[1]}";
                item.Value = reader[0];
                OperatingSystemComboBox.Items.Add(item);
            }
            reader.Close();
        }

        private void loadInfoModel()
        {
            DB db = new DB();
            string queryInfo = $"SELECT * FROM models ";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = $" {reader[1]}";
                item.Value = reader[0];
                ModelComboBox.Items.Add(item);
            }
            reader.Close();
            reader.Close();

            db.closeConnection();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddModelButton_Click(object sender, EventArgs e)
        {
            new AddModel().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AddOperatingSystem().Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            if (idComputer == null)
            {
                MySqlCommand command = new MySqlCommand($"INSERT into computers (idModel, dateOfPurchase, idOperatingSystem) values(@idModel, @dateOfPurchase, @idOperatingSystem)", db.getConnection());
                command.Parameters.AddWithValue("@idModel", (ModelComboBox.SelectedItem as ComboBoxItem).Value);
                command.Parameters.AddWithValue("@dateOfPurchase", dateTimePicker1.Value.ToString("dd.MM.yyyy"));
                command.Parameters.AddWithValue("@idOperatingSystem", (OperatingSystemComboBox.SelectedItem as ComboBoxItem).Value);
                db.openConnection();

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Компьютер добавлен");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                db.closeConnection();
            }
            else
            {
                MySqlCommand command = new MySqlCommand($"Update computers set idModel = @idModel, dateOfPurchase = @dateOfPurchase, idOperatingSystem = @idOperatingSystem where id = {idComputer}", db.getConnection());
                command.Parameters.AddWithValue("@idModel", (ModelComboBox.SelectedItem as ComboBoxItem).Value);
                command.Parameters.AddWithValue("@dateOfPurchase", dateTimePicker1.Value.ToString("dd.MM.yyyy"));
                command.Parameters.AddWithValue("@idOperatingSystem", (OperatingSystemComboBox.SelectedItem as ComboBoxItem).Value);
                db.openConnection();

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Компьютер изменен");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                db.closeConnection();
            }
        }
    }
}
