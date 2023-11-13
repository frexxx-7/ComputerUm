using MySql.Data.MySqlClient;
using Mysqlx.Expr;
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
    public partial class AddEmployee : Form
    {
        private string idEmployee;
        public AddEmployee(string idEmployee)
        {
            InitializeComponent();
            this.idEmployee = idEmployee;

            loadInfoJobTitle();
            loadInfoUser();

            if (idEmployee != null)
            {
                label1.Text = "Изменить сотрудника";
                AddButton.Text = "Изменить";
                loadInfoEmployeeIntoDb();
            }
        }
        private void loadInfoUser()
        {
            DB db = new DB();
            string queryInfo = $"SELECT id, login FROM users";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = $" {reader[1]}";
                item.Value = reader[0];
                UserComboBox.Items.Add(item);
            }
            reader.Close();
            reader.Close();

            db.closeConnection();
        }
        private void loadInfoJobTitle()
        {
            DB db = new DB();
            string queryInfo = $"SELECT * FROM jobtitle ";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = $" {reader[1]}";
                item.Value = reader[0];
                JobTitleComboBox.Items.Add(item);
            }
            reader.Close();
            reader.Close();

            db.closeConnection();
        }
        private void loadInfoEmployeeIntoDb()
        {
            DB db = new DB();
            string queryInfo = $"SELECT * FROM employees " +
                $"join jobtitle on jobtitle.id = employees.idJobTitle " +
                $"WHERE employees.id = '{idEmployee}'";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < JobTitleComboBox.Items.Count; i++)
                {
                    if (reader["idJobTitle"].ToString() != "")
                    {
                        if (Convert.ToInt32((JobTitleComboBox.Items[i] as ComboBoxItem).Value) == Convert.ToInt32(reader["idJobTitle"]))
                        {
                            JobTitleComboBox.SelectedIndex = i;
                        }
                    }
                }

                dateTimePicker1.Value = Convert.ToDateTime(reader["employmentDate"].ToString());
                NameTextBox.Text = reader["name"].ToString();
                PatronymicTextBox.Text = reader["patronymic"].ToString();
                SurnameTextBox.Text = reader["surname"].ToString();
                SalaryTextBox.Text = reader["salary"].ToString();

                for (int i = 0; i < UserComboBox.Items.Count; i++)
                {
                    if (reader["idUser"].ToString() != "")
                    {
                        if (Convert.ToInt32((UserComboBox.Items[i] as ComboBoxItem).Value) == Convert.ToInt32(reader["idUser"]))
                        {
                            UserComboBox.SelectedIndex = i;
                        }
                    }
                }
            }
            reader.Close();

            db.closeConnection();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            if (idEmployee == null)
            {
                MySqlCommand command = new MySqlCommand($"INSERT into employees (name, patronymic, surname, idJobTitle, employmentDate, salary, idUser) values(@name, @patronymic, @surname, @idJobTitle, @employmentDate, @salary, @idUser)", db.getConnection());
                command.Parameters.AddWithValue("@name", NameTextBox.Text);
                command.Parameters.AddWithValue("@patronymic", PatronymicTextBox.Text);
                command.Parameters.AddWithValue("@surname", SurnameTextBox.Text);
                command.Parameters.AddWithValue("@salary", SalaryTextBox.Text);
                command.Parameters.AddWithValue("@employmentDate", dateTimePicker1.Value.ToString("dd.MM.yyyy"));
                command.Parameters.AddWithValue("@idJobTitle", (JobTitleComboBox.SelectedItem as ComboBoxItem).Value);
                command.Parameters.AddWithValue("@idUser", (UserComboBox.SelectedItem as ComboBoxItem).Value);
                db.openConnection();

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Сотрудник добавлен");
                    this.Close();
                }
                catch(Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }

                db.closeConnection();
            }
            else
            {
                MySqlCommand command = new MySqlCommand($"Update employees set name = @name, patronymic = @patronymic, surname = @surname, idJobTitle = @idJobTitle, employmentDate = @employmentDate, salary = @salary, idUser = @idUser where id = {idEmployee}", db.getConnection());
                command.Parameters.AddWithValue("@name", NameTextBox.Text);
                command.Parameters.AddWithValue("@patronymic", PatronymicTextBox.Text);
                command.Parameters.AddWithValue("@surname", SurnameTextBox.Text);
                command.Parameters.AddWithValue("@salary", SalaryTextBox.Text);
                command.Parameters.AddWithValue("@employmentDate", dateTimePicker1.Value.ToString("dd.MM.yyyy"));
                command.Parameters.AddWithValue("@idJobTitle", (JobTitleComboBox.SelectedItem as ComboBoxItem).Value);
                command.Parameters.AddWithValue("@idUser", (UserComboBox.SelectedItem as ComboBoxItem).Value);
                db.openConnection();

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Сотрудник изменен");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                db.closeConnection();
            }
        }

        private void CanceledButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddJobTitleButton_Click(object sender, EventArgs e)
        {
            new AddJobTitle().Show();
        }
    }
}
