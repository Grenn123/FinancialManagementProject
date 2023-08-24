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
    public partial class StartWindow : Form
    {
        private SqlConnection sqlConnection = null;

        public StartWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(
                ConfigurationManager.ConnectionStrings["UserDataConnectionString"].ConnectionString);

            sqlConnection.Open();

            //  ConfirmationOfConnectionToDatabase();

        }

        private void button_Enter_Click(object sender, EventArgs e)
        {
            try
            {
                string querry = "SELECT * FROM Login_Password WHERE UserLogin = '" + textBox_Login.Text + "' AND Password = '" + textBox_Password.Text + "'";

                //SqlDataAdapter представляет набор команд данных и подключение к базе данных,
                //которые используются для заполнения DataSet и обновления базы данных SQL Server.
                //Этот класс не наследуется.
                SqlDataAdapter adapter = new SqlDataAdapter(querry, sqlConnection);

                //DataTable предоставляет кэш в памяти для данных
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MainScreen screen = new MainScreen();
                    screen.Show();
                    this.Hide();
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
                sqlConnection.Close();
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

        private void ConfirmationOfConnectionToDatabase()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                MessageBox.Show("Поключение установлено");
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Вы действительно хотите выйти из программы?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                this.Show();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
