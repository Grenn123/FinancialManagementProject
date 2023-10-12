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
    public partial class RegistrationScreen : Form
    {
        SqlConnection sqlConnection = null;


        const int administrator = 1;
        const int manager = 2;
        const int loginMinLength = 3;
        const int passwordMinLength = 5;

        public RegistrationScreen()
        {
            InitializeComponent();
        }

        private void RegistrationScreen_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["UserDataConnectionString"].ConnectionString);
        }

        private void button_Registry_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_NewPassword.Text != "" && textBox_NewLogin.Text != "" && textBox_CofirmPassword.Text != "")
                {
                    if (textBox_NewLogin.Text.Length > loginMinLength)
                    {
                        if (textBox_NewPassword.Text.Length > passwordMinLength)
                        {
                            if (textBox_NewPassword.Text == textBox_CofirmPassword.Text)
                            {
                                bool newLoginChecked = CheckLogin(textBox_NewLogin.Text);

                                if (newLoginChecked)
                                {
                                    if (sqlConnection == null || sqlConnection.State != ConnectionState.Open)
                                    {
                                        sqlConnection.Open();
                                    }

                                    using (SqlCommand sqlCommand = new SqlCommand(
                                        "INSERT INTO [Login_Password] (Login, Password, Type) VALUES (@Login, @Password, @Type)", sqlConnection))
                                    {
                                        sqlCommand.Parameters.AddWithValue("Login", textBox_NewLogin.Text);
                                        sqlCommand.Parameters.AddWithValue("Password", textBox_NewPassword.Text);

                                        if (checkBox_Admin.Checked)
                                        {
                                            sqlCommand.Parameters.AddWithValue("Type", administrator);
                                        }
                                        else
                                        {
                                            sqlCommand.Parameters.AddWithValue("Type", manager);
                                        }
                                        textBox_NewLogin.Clear();
                                        textBox_NewPassword.Clear();
                                        textBox_CofirmPassword.Clear();

                                        sqlCommand.ExecuteNonQuery();

                                        MessageBox.Show("Регистрация прошла успешно");

                                        ExitThisForm();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Пользователь с таким именем уже зарегестрирован");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Пароли не совпадают");
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Пароль должен быть не менее {passwordMinLength} символов");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Логин должен быть не менее {loginMinLength} символов");
                    }
                }
                else
                {
                    MessageBox.Show("Нужно запонить все обязательные поля");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                {
                    sqlConnection.Close();
                }
            }
        }

        private bool CheckLogin(string login)
        {
            using (sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["UserDataConnectionString"].ConnectionString))
            {

                if (sqlConnection == null || sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                }

                string query = "SELECT * FROM Login_Password WHERE Login = '" + textBox_NewLogin.Text + "'";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection))
                {
                    //DataTable предоставляет кэш в памяти для данных
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

        private void button_Back_Click(object sender, EventArgs e)
        {
            ExitThisForm();
        }

        private void ExitThisForm()
        {
            this.Hide();

            if (StartScreen.UserType == 0)
            {
                var form2 = new StartScreen();
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
