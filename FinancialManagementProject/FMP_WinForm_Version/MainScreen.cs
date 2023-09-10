using System;
using System.Collections;
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
    public partial class MainScreen : Form
    {
        private SqlConnection sqlConnection = null;
      
        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            string query;
            
            using (sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["UserDataConnectionString"].ConnectionString))
            {
                if (sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                }

                query = "SELECT ColumnID, ColumnName FROM Columns WHERE UserID = '" + StartScreen.UserID + "'";
                List < string >  ColumnsList= ListCreation(query);

                query = "SELECT RowID, RowName FROM Rows WHERE UserID = '" + StartScreen.UserID + "'";
                List<string> RowsList = ListCreation(query);






                //using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection))
                //{
                //    DataTable dt = new DataTable();

                //    dataAdapter.Fill(dt);
                //dataGridView1.DataSource = dt;
                //dataGridView1.DataSource = ColumnsList;

                //}

            }
        }


        private List<string> ListCreation(string query)
        {
            List<string>Dict = new List<string>();
            ListViewItem item = null;

            using (SqlCommand command = new SqlCommand(query, sqlConnection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new ListViewItem();  

                      //  item.SubItems.Add(reader.GetString(0));


                       //Dict.Add(reader.GetString(0).ToString());
                    }
                }
            }
            return Dict;
        }
    }
}
