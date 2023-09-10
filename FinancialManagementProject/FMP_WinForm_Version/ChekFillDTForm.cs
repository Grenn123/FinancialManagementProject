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
    public partial class ChekFillDTForm : Form
    {
        public ChekFillDTForm()
        {
            InitializeComponent();
        }
        private void ChekFillDTForm_Load(object sender, EventArgs e)
        {

        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(
                ConfigurationManager.ConnectionStrings["UserDataConnectionString"].ConnectionString))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Login_Password", sqlConnection);

                //Объектное представление части реальной бд отфильтрованной по выборке описанной в SqlAdapter
                DataTable dt = new DataTable();

                sqlDataAdapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

    }
}
