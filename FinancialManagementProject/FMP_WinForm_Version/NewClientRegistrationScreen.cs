using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace FMP_WinForm_Version
{
    public partial class NewClientRegistrationScreen : Form
    {
        SqlConnection sqlConnection = null;

        const int nameMinLenght = 2;

        public NewClientRegistrationScreen()
        {
            InitializeComponent();
        }
        private void NewClientRegistrationScreen_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["UserDataConnectionString"].ConnectionString);

            EnteringComboBox_Status();
            EnteringComboBox_Entity();
            EnteringComboBox_Subscription();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_Name.Text != "" && textBox_Name.Text != "" && textBox_Name.Text != "")
            {
                if (textBox_Name.Text.Length > nameMinLenght)
                {
                    if (comboBox_Status.SelectedIndex != 0)
                    {
                        if (comboBox_Entity.SelectedIndex != 0)
                        {
                            if (comboBox_Subscription.SelectedIndex != 0)
                            {
                                bool newClientNameChecked = CheckNewClientName();
                                if (newClientNameChecked)
                                {
                                    using (sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["UserDataConnectionString"].ConnectionString))
                                    {
                                        sqlConnection.Open();

                                        string query =
                                            "INSERT INTO " +
                                            "[Clients] (Client_Name, Client_Status, Client_Type_Of_Entity, Subscription, Manager_ID) " +
                                            "VALUES (" +
                                            "@Client_Name," +
                                            "@Client_Status," +
                                            "@Client_Type_Of_Entity," +
                                            "@Subscription," +
                                            "@Manager_ID)";

                                        using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                                        {
                                            sqlCommand.Parameters.AddWithValue("Client_Name", textBox_Name.Text);
                                            sqlCommand.Parameters.AddWithValue("Client_Status", comboBox_Status.Text);
                                            sqlCommand.Parameters.AddWithValue("Client_Type_Of_Entity", comboBox_Entity.Text);
                                            sqlCommand.Parameters.AddWithValue("Subscription", comboBox_Subscription.Text);
                                            sqlCommand.Parameters.AddWithValue("Manager_ID", StartScreen.ManagerID);

                                            sqlCommand.ExecuteNonQuery();

                                            MessageBox.Show("Новый клиент добавлен");

                                            ExitThisForm();
                                        }
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Не выбран тип лицензии");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Не выбран вид Юр. лица");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Не выбран статус клиента");
                    }
                }
                else
                {
                    MessageBox.Show($"Название клиента должно быть более {nameMinLenght} символов");
                }
            }
            else
            {
                MessageBox.Show("Необходимо указать название клиента");
            }
        }

        private void EnteringComboBox_Status()
        {
            List<string> status = new List<string>
            {
                "Выберите статус клиента",
                "Обычный",
                "Ключевой"
            };
            comboBox_Status.DataSource = status;
        }

        private void EnteringComboBox_Entity()
        {
            List<string> entity = new List<string>
            {
                "Выберите вид юр. лица",
                "ИП",
                "ООО",
                "АО",
                "ОАО",
                "ЗАО",
                "ПАО",
                "НКО"
            };
            comboBox_Entity.DataSource = entity;
        }

        private void EnteringComboBox_Subscription()
        {
            List<string> subscription = new List<string>
            {
                "Выберите тип лицензии",
                "Тестовый период",
                "Подписка",
                "Лицензия"
            };

            comboBox_Subscription.DataSource = subscription;
        }

        private bool CheckNewClientName()
        {
            using (sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["UserDataConnectionString"].ConnectionString))
            {
                sqlConnection.Open();

                string query = "SELECT * FROM Clients WHERE Client_Name = '" + textBox_Name.Text + "'";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection))
                {
                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    bool checkResult = true;

                    if (dt.Rows.Count > 0)
                    {
                        if (sqlConnection.State == ConnectionState.Open)
                        {
                            sqlConnection.Close();
                        }
                        checkResult = false;
                    }
                    return checkResult;
                }
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            ExitThisForm();
        }

        private void ExitThisForm()
        {
            this.Hide();
                        
            if (StartScreen.UserType == 0)
            {                
                var form2 = new ManagerScreen();
                form2.Closed += Form2Closed;
                form2.Show();
            }
            else
            {                
                var form2 = new AdministratorScreen();
                form2.Closed += Form2Closed;
                form2.Show();
            }
        }

        private void Form2Closed(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
