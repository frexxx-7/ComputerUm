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
using Excel = Microsoft.Office.Interop.Excel;

namespace ComputerUm
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Hide();
        }
        private void loadInfoEmployeeIntoDB()
        {
            DB db = new DB();

            EmployeesDataGridView.Rows.Clear();

            string query = $"select employees.id, employees.name, employees.patronymic, employees.surname, employees.employmentDate, employees.salary, jobtitle.name from employees " +
                $"join jobtitle on jobtitle.id = employees.idJobTitle ";

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
                    EmployeesDataGridView.Rows.Add(s);
            }
            db.closeConnection();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            loadInfoEmployeeIntoDB();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            loadInfoEmployeeIntoDB();
        }

        private void Employees_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            new AddEmployee(null).Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            new AddEmployee(EmployeesDataGridView[0, EmployeesDataGridView.SelectedCells[0].RowIndex].Value.ToString()).Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand($"delete from employees where id = {EmployeesDataGridView[0, EmployeesDataGridView.SelectedCells[0].RowIndex].Value}", db.getConnection());
            db.openConnection();

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Сотрудник удален");

            }
            catch
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.closeConnection();
            loadInfoEmployeeIntoDB();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            EmployeesDataGridView.Rows.Clear();

            string searchString = $"select employees.id, employees.name, employees.patronymic, employees.surname, employees.employmentDate, employees.salary, jobtitle.name from employees " +
                $"join jobtitle on jobtitle.id = employees.idJobTitle " +
            $"where concat (employees.id, employees.name, employees.patronymic, employees.surname, employees.employmentDate, employees.salary, jobtitle.name) like '%" + SearchTextBox.Text + "%'";

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
                    EmployeesDataGridView.Rows.Add(s);
            }
            db.closeConnection();
        }

        private void OutputButton_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.ActiveSheet;
            for (int j = 0; j < EmployeesDataGridView.Columns.Count; j++)
            {
                if (EmployeesDataGridView.Columns[j].Visible)
                {
                    worksheet.Cells[1, j] = EmployeesDataGridView.Columns[j].HeaderText;
                }
            }
            for (int i = 0; i < EmployeesDataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < EmployeesDataGridView.Columns.Count; j++)
                {
                    if (EmployeesDataGridView.Columns[j].Visible)
                    {
                        worksheet.Cells[i + 2, j] = EmployeesDataGridView.Rows[i].Cells[j].Value;
                    }
                }
            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel File|*.xlsx";
            saveFileDialog1.Title = "Сохранить Excel файл";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                workbook.SaveAs(saveFileDialog1.FileName);
            }
            workbook.Close();
            excelApp.Quit();
        }
    }
}
