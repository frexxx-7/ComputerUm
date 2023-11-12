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
    public partial class Components : Form
    {
        public Components()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Hide();
        }
        private void loadInfoComponentsIntoDB()
        {
            DB db = new DB();

            ComponentsDataGridView.Rows.Clear();

            string query = $"select components.id, components.name, components.serialNumber, state.name from components " +
                $"join state on state.id = components.idState ";

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
                    ComponentsDataGridView.Rows.Add(s);
            }
            db.closeConnection();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            loadInfoComponentsIntoDB();
        }

        private void Components_Load(object sender, EventArgs e)
        {
            loadInfoComponentsIntoDB();
        }

        private void Components_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            new AddComponents(null).Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            new AddComponents(ComponentsDataGridView[0, ComponentsDataGridView.SelectedCells[0].RowIndex].Value.ToString()).Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand($"delete from components where id = {ComponentsDataGridView[0, ComponentsDataGridView.SelectedCells[0].RowIndex].Value}", db.getConnection());
            db.openConnection();

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Комплектующее удалено");

            }
            catch
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.closeConnection();
            loadInfoComponentsIntoDB();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            ComponentsDataGridView.Rows.Clear();

            string searchString = $"select components.id, components.name, components.serialNumber, state.name from components " +
                $"join state on state.id = components.idState " +
                $"where concat (components.id, components.name, components.serialNumber, state.name) like '%" + SearchTextBox.Text + "%'";

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
                    ComponentsDataGridView.Rows.Add(s);
            }
            db.closeConnection();
        }

        private void OutputButton_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.ActiveSheet;
            for (int j = 0; j < ComponentsDataGridView.Columns.Count; j++)
            {
                if (ComponentsDataGridView.Columns[j].Visible)
                {
                    worksheet.Cells[1, j] = ComponentsDataGridView.Columns[j].HeaderText;
                }
            }
            for (int i = 0; i < ComponentsDataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < ComponentsDataGridView.Columns.Count; j++)
                {
                    if (ComponentsDataGridView.Columns[j].Visible)
                    {
                        worksheet.Cells[i + 2, j] = ComponentsDataGridView.Rows[i].Cells[j].Value;
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
