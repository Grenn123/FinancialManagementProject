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
//using System.Xml.Schema;



namespace FMP_WinForm_Version
{
    public partial class RegistrationScreen : Form
    {
        SqlConnection conn = null;

        const int loginMinLength = 3;
        const int passwordMinLength = 5;

        public RegistrationScreen()
        {
            InitializeComponent();
        }

        private void RegistrationScreen_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UserDataConnectionString"].ConnectionString);
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
                                    if (conn.State == ConnectionState.Closed)
                                    {
                                        conn.Open();
                                    }

                                    using (SqlCommand sqlCommand = new SqlCommand(
                                        "INSERT INTO [Login_Password] (Login, Password) VALUES (@Login, @Password)", conn))
                                    {
                                        sqlCommand.Parameters.AddWithValue("Login", textBox_NewLogin.Text);
                                        sqlCommand.Parameters.AddWithValue("Password", textBox_NewPassword.Text);

                                        textBox_NewLogin.Clear();
                                        textBox_NewPassword.Clear();
                                        textBox_CofirmPassword.Clear();

                                        sqlCommand.ExecuteNonQuery();

                                        MessageBox.Show("Регистрация прошла успешно");

                                        StartScreen startScreen = new StartScreen();
                                        startScreen.Show();
                                        this.Hide();
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
                if (conn != null && conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }


        private bool CheckLogin(string login)
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UserDataConnectionString"].ConnectionString);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            string querry = "SELECT * FROM Login_Password WHERE Login = '" + textBox_NewLogin.Text + "'";

            using (SqlDataAdapter adapter = new SqlDataAdapter(querry, conn))
            {
                //DataTable предоставляет кэш в памяти для данных
                DataTable dt = new DataTable();

                adapter.Fill(dt);

                bool checkResult = true;

                if (dt.Rows.Count > 0)
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                    checkResult = false;
                }
                return checkResult;
            }
        }
    }
}
