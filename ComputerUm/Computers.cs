﻿using MySql.Data.MySqlClient;
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

            string query = $"select computers.id, models.name, computers.dateOfPurchase, operatingSystem.name, state.name from computers " +
                $"left join models on models.id = computers.idModel " +
                $"left join state on state.id = computers.idState " +
                $"left join operatingSystem on operatingSystem.id = computers.idOperatingSystem";

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

            string searchString = $"select computers.id, models.name, computers.dateOfPurchase, operatingSystem.name, state.name from computers " +
                $"join models on models.id = computers.idModel " +
                $"left join state on state.id = computers.idState " +
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

        private void OutputButton_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.ActiveSheet;
            for (int j = 0; j < ComputersDataGridView.Columns.Count; j++)
            {
                if (ComputersDataGridView.Columns[j].Visible)
                {
                    worksheet.Cells[1, j] = ComputersDataGridView.Columns[j].HeaderText;
                }
            }   
            for (int i = 0; i < ComputersDataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < ComputersDataGridView.Columns.Count; j++)
                {
                    if (ComputersDataGridView.Columns[j].Visible)
                    {
                        worksheet.Cells[i + 2, j] = ComputersDataGridView.Rows[i].Cells[j].Value;
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
