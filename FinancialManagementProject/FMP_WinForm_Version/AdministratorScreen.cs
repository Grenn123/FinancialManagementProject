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
        private string query;
        private int reportNumber;
        List<string> list = new List<string>();

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
            //list.Add(GetDescription(ReportOptions.Managers));
            list.Add("Все менеджеры");
            list.Add("Все клиенты");
            list.Add("Клиенты по менеджерам");
            list.Add("Все товары");
            list.Add("Клиенты по статусам");
            list.Add("Товары по клиентам");

            comboBox1.DataSource = list;
        }

        //internal string GetDescription(Enum enumElement)
        //{
        //    // Type type = enumElement.GetType();
        //    var type = enumElement.GetType();

        //    MemberInfo[] memInfo = type.GetMember(enumElement.ToString());
        //    if (memInfo != null && memInfo.Length > 0)
        //    {
        //        object[] attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
        //        if (attrs != null && attrs.Length > 0)
        //            return ((DescriptionAttribute)attrs[0]).Description;
        //    }
        //    return enumElement.ToString();
        //}





        private void button_Select_Click(object sender, EventArgs e)
        {
            //var t = GetValueFromDescription<ReportOptions>(comboBox1.Text);
            //MessageBox.Show(t.ToString());

            switch (comboBox1.Text)
            {
                case "Все менеджеры":
                    query = "SELECT Login FROM Login_Password";
                    break;
                case "Все клиенты":
                    query = "SELECT Client_Name FROM Clients";
                    break;
                case "Клиенты по менеджерам":
                    query = "SELECT Login, Client_Name FROM Login_Password AS LP JOIN Clients AS C ON LP.Manager_ID = C.Manager_ID ";
                    break;
                case "Все товары":
                    query = "SELECT Product_Name FROM Products";
                    break;
                case "Товары по клиентам":
                    query = "SELECT C.Client_name, D.Product FROM Clients AS C JOIN Deals AS D ON C.CLient_ID = D.CLient_ID";
                    break;
                case "Клиенты по статусам":
                    query = "SELECT Client_Name, Client_Status FROM Clients";
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


        //public T GetValueFromDescription<T>(string description) where T : Enum
        //{
        //    foreach (var field in typeof(T).GetFields())
        //    {
        //        if (Attribute.GetCustomAttribute(field,
        //        typeof(DescriptionAttribute)) is DescriptionAttribute attribute)
        //        {
        //            if (attribute.Description == description)
        //                return (T)field.GetValue(null);
        //        }
        //        else
        //        {
        //            if (field.Name == description)
        //                return (T)field.GetValue(null);
        //        }
        //    }
        //    throw new ArgumentException("Not found.", nameof(description));
        //    // Or return default(T);
        //}


        private void button_NewClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new NewClientRegistrationScreen();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void button_NewMeneger_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new RegistrationScreen();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
