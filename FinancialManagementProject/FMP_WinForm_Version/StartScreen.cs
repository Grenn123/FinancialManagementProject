using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace FMP_WinForm_Version
{
    public partial class StartScreen : Form
    {
        internal static int ManagerID;
        internal static int UserType;

        private SqlConnection sqlConnection = null;

        public StartScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClearTextBoxesStartWindowForm();
        }

        private void button_Enter_Click(object sender, EventArgs e)
        {
            using (sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["UserDataConnectionString"].ConnectionString))
            {
                if (sqlConnection == null || sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                }

                try
                {
                    string querry = "SELECT * FROM Login_Password WHERE Login = '" + textBox_Login.Text + "' AND Password = '" + textBox_Password.Text + "'";

                    ///SqlDataAdapter представляет набор команд данных и подключение к базе данных,
                    ///которые используются для заполнения DataSet и обновления базы данных SQL Server.
                    ///Этот класс не наследуется.
                    SqlDataAdapter adapter = new SqlDataAdapter(querry, sqlConnection);

                    //DataTable предоставляет кэш в памяти для данных
                    DataTable dt = new DataTable();

                    adapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        using (SqlCommand com = new SqlCommand(querry, sqlConnection))
                        {
                            StartScreen.ManagerID = (Int32)com.ExecuteScalar();
                            StartScreen.UserType = (Int32)dt.Rows[0][3];

                            this.Hide();
                            
                            if (StartScreen.UserType == 0)
                            {
                                var form2 = new ManagerScreen();
                                form2.Closed += (s, args) => this.Close();
                                form2.Show();
                            }
                            else
                            {
                                var form2 = new AdministratorScreen();
                                form2.Closed += (s, args) => this.Close();
                                form2.Show();
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        ChekFillDTFormRunning();

                        ClearTextBoxesStartWindowForm();
                    }
                }
                catch
                {
                    MessageBox.Show("Критическая ошибка", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                    {
                        sqlConnection.Close();
                    }
                }
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            ClearTextBoxesStartWindowForm();
        }

        private void ClearTextBoxesStartWindowForm()
        {
            textBox_Login.Clear();
            textBox_Password.Clear();
        }
        private void ChekFillDTFormRunning()
        {
            ChekFillDTForm chekFill = new ChekFillDTForm();

            chekFill.Show();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Вы действительно хотите выйти из программы?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void button_Registration_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new RegistrationScreen();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
