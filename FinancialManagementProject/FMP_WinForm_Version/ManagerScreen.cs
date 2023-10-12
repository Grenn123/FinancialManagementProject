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
                $"Client_Name LIKE '%{textBox_ManagerScreen.Text}%' ";
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

                switch (comboBox_ClientStatus_ManagerScreen.SelectedIndex)
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
            List<ManagerScreenListStatus> status = new List<ManagerScreenListStatus>();

            status.Add(new ManagerScreenListStatus("Все", ClientsStatuses.all));
            status.Add(new ManagerScreenListStatus("Обычный", ClientsStatuses.usual));
            status.Add(new ManagerScreenListStatus("Ключевой", ClientsStatuses.vip));

            comboBox_ClientStatus_ManagerScreen.DataSource = status;
        }

        private void button_NewClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new NewClientRegistrationScreen();
            form2.Closed += Form2Closed;
            form2.Show();
        }

        private void button_ClientDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new DeleteClientScreen();
            form2.Closed += Form2Closed;
            form2.Show();
        }

        private void Form2Closed(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class ManagerScreenListStatus
    {
        public string Text { get; set; }
        public ClientsStatuses Value { get; set; }

        public ManagerScreenListStatus(string text, ClientsStatuses value)
        {
            Text = text;
            Value = value;
        }
    }
}
