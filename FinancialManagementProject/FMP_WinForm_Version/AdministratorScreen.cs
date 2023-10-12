using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FMP_WinForm_Version
{
    public partial class AdministratorScreen : Form
    {
        private SqlConnection sqlConnection = null;

        public AdministratorScreen()
        {
            InitializeComponent();
        }

        private void AdministratorScreen_Load(object sender, EventArgs e)
        {
            Entering_ComboBox();
        }

        private void Entering_ComboBox()
        {
            List<AdministratorScreenListItem> list = new List<AdministratorScreenListItem>();

            list.Add(new AdministratorScreenListItem("Все менеджеры", ReportOptions.Managers));
            list.Add(new AdministratorScreenListItem("Все клиенты", ReportOptions.Clients));
            list.Add(new AdministratorScreenListItem("Клиенты по менеджерам", ReportOptions.CLientsToManagers));
            list.Add(new AdministratorScreenListItem("Все товары", ReportOptions.Products));
            list.Add(new AdministratorScreenListItem("Клиенты по статусам", ReportOptions.ClientsToStatus));
            list.Add(new AdministratorScreenListItem("Товары по клиентам", ReportOptions.ProductsToClients));

            comboBox1_AdministratorScreen.DataSource = list;
        }

        private void button_Select_Click(object sender, EventArgs e)
        {
            string query = null;

            switch ((ReportOptions)comboBox1_AdministratorScreen.SelectedValue)
            {
                case ReportOptions.Managers:
                    query = "SELECT Login FROM Login_Password";
                    break;
                case ReportOptions.Clients:
                    query = "SELECT Client_Name FROM Clients";
                    break;
                case ReportOptions.CLientsToManagers:
                    query = "SELECT Login, Client_Name FROM Login_Password AS LP JOIN Clients AS C ON LP.Manager_ID = C.Manager_ID ";
                    break;
                case ReportOptions.Products:
                    query = "SELECT Product_Name FROM Products";
                    break;
                case ReportOptions.ClientsToStatus:
                    query = "SELECT Client_Name, Client_Status FROM Clients";
                    break;
                case ReportOptions.ProductsToClients:
                    query = "SELECT C.Client_name, D.Product FROM Clients AS C JOIN Deals AS D ON C.CLient_ID = D.CLient_ID";
                    break;
            }

            using (sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["UserDataConnectionString"].ConnectionString))
            {
                if (sqlConnection == null || sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                }

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView_AdminScreen.DataSource = dt;
                }
                sqlConnection.Close();
            }
        }


        private void button_NewClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new NewClientRegistrationScreen();
            form2.Closed += Form2Closed;
            form2.Show();
        }
        private void button_NewMeneger_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new RegistrationScreen();
            form2.Closed += Form2Closed;
            form2.Show();
        }
        private void Form2Closed(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class AdministratorScreenListItem
    {
        public string Text { get; set; }
        public ReportOptions Value { get; set; }

        public AdministratorScreenListItem(string text, ReportOptions value)
        {
            Text = text;
            Value = value;
        }
    }
}
