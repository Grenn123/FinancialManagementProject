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
    public partial class DeleteClientScreen : Form
    {
        private SqlConnection sqlConnection = null;

        public DeleteClientScreen()
        {
            InitializeComponent();
        }

        private void button_DeleteClient_Click(object sender, EventArgs e)
        {
            using (sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["UserDataConnectionString"].ConnectionString))
            {
                sqlConnection.Open();

                string query = "DELETE FROM Clients WHERE Client_Name = '" + textBox_CllientDeleteScreen.Text + "'";
                try
                {
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show($"Клиент {textBox_CllientDeleteScreen.Text} удален");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                }

                DialogResult res;
                res = MessageBox.Show("Вы хотите вернуться в основное окно?", "Вернуться", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    BackToMainScreen();
                }
                else
                {
                    this.Show();
                }
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            BackToMainScreen();
        }

        private void BackToMainScreen()
        {            
            this.Hide();
            var form2 = new ManagerScreen();
            form2.Closed += Form2Closed;
            form2.Show();
        }

        private void Form2Closed(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
