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
    public partial class Components : Form
    {
        public Components()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Close();
        }
        private void loadInfoComponentsIntoDB()
        {
            DB db = new DB();

            ComponentsDataGridView.Rows.Clear();

            string query = $"select components.id, components.serialNumber, state.name from components " +
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
    }
}
