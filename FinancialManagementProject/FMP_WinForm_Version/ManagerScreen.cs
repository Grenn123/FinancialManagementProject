using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace FMP_WinForm_Version
{
    public partial class ManagerScreen : Form
    {
        private SqlConnection sqlConnection = null;
        private string query;

        public ManagerScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            using (sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["UserDataConnectionString"].ConnectionString))
            {
                if (sqlConnection == null || sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                }

                query =
                    "SELECT Client_Name, Client_Status, Client_Type_Of_Entity, Subscription " +
                    "FROM Clients " +
                    "WHERE Manager_ID = '" + StartScreen.ManagerID + "'";


                using (SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView_MainScreen.DataSource = dt;
                }

                Entering_ComboBox_ClientStatus();
            }

        }

        private void textBox_MainScreen_TextChanged(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["UserDataConnectionString"].ConnectionString);

            if (sqlConnection == null || sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }

            (dataGridView_MainScreen.DataSource as DataTable).DefaultView.RowFilter =
                $"Client_Name LIKE '%{textBox_MainScreen.Text}%' ";
        }

        private void comboBox_ClientStatus_MainScreen_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["UserDataConnectionString"].ConnectionString))
            {
                if (sqlConnection == null || sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                }

                string query = null;

                switch (comboBox_ClientStatus_MainScreen.SelectedIndex)
                {
                    case 0:
                        query = "";
                        break;
                    case 1:
                        query = $"Client_Status LIKE 'Обычный' ";
                        break;
                    case 2:
                        query = $"Client_Status LIKE 'Ключевой' ";
                        break;
                }
            (dataGridView_MainScreen.DataSource as DataTable).DefaultView.RowFilter = query;
            }

            sqlConnection.Close();
        }


        private void Entering_ComboBox_ClientStatus()
        {
            List<string> status = new List<string>
            {
                "Все",
                "Обычный",
                "Ключевой"
            };
            comboBox_ClientStatus_MainScreen.DataSource = status;
        }

        private void button_NewClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newClient = new NewClientRegistrationScreen();
            newClient.Closed += (s, args) => this.Close();
            newClient.Show();
        }

        private void button_ClientDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            var deleteClient = new DeleteClientScreen();
            deleteClient.Closed += (s, args) => this.Close();
            deleteClient.Show();
        }
    }
}
