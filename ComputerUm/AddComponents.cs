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
    public partial class AddComponents : Form
    {
        private string idComponent;
        public AddComponents(string idComponent)
        {
            InitializeComponent();
            this.idComponent = idComponent;
            loadInfoState();

            if(idComponent != null)
            {
                label1.Text = "Изменить комплектующее";
                AddButton.Text = "Изменить";
                loadInfoComponent();
            }
        }

        private void loadInfoComponent()
        {
            DB db = new DB();
            string queryInfo = $"SELECT * FROM components WHERE id = '{idComponent}'";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                NameTextBox.Text = reader[1].ToString();
                SerialNumberTextBox.Text = reader[2].ToString();

                for (int i = 0; i < StateComboBox.Items.Count; i++)
                {
                    if (reader["idState"].ToString() != "")
                    {
                        if (Convert.ToInt32((StateComboBox.Items[i] as ComboBoxItem).Value) == Convert.ToInt32(reader["idState"]))
                        {
                            StateComboBox.SelectedIndex = i;
                        }
                    }
                }
            }
            reader.Close();

            db.closeConnection();
        }

        private void loadInfoState()
        {
            DB db = new DB();
            string queryInfo = $"SELECT * FROM state";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = $" {reader[1]}";
                item.Value = reader[0];
                StateComboBox.Items.Add(item);
            }
            reader.Close();

            db.closeConnection();
        }

        private void CanceledButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddStateButton_Click(object sender, EventArgs e)
        {
            new AddState().Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            if (idComponent == null)
            {
                MySqlCommand command = new MySqlCommand($"INSERT into components (name, serialNumber, idState) values(@name, @serialNumber, @idState)", db.getConnection());
                command.Parameters.AddWithValue("@name", NameTextBox.Text);
                command.Parameters.AddWithValue("@serialNumber", SerialNumberTextBox.Text);
                command.Parameters.AddWithValue("@idState", (StateComboBox.SelectedItem as ComboBoxItem).Value);

                db.openConnection();

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Комплектующее добавлено");
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
                MySqlCommand command = new MySqlCommand($"update components set name=@name, serialNumber=@serialNumber, idState=@idState where id ={idComponent}", db.getConnection());
                command.Parameters.AddWithValue("@name", NameTextBox.Text);
                command.Parameters.AddWithValue("@serialNumber", SerialNumberTextBox.Text);
                command.Parameters.AddWithValue("@idState", (StateComboBox.SelectedItem as ComboBoxItem).Value);

                db.openConnection();

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Комплектующее изменено");
                    this.Close();

                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }

                db.closeConnection();
            }
        }
    }
}
