using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessManagementSystem2
{
    public partial class UyeleriGoruntule : Form
    {
        public UyeleriGoruntule()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-BURAK;Initial Catalog=FMSDatabase;Integrated Security=True;");

        private void getDataFromDatabase()
        {
            sqlConnection.Open();
            string query = "SELECT * FROM TableUye";
            SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder();
            var dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridViewUyeleriGoruntule.DataSource = dataSet.Tables[0];
            sqlConnection.Close();
        }

        private void filterName()
        {
            sqlConnection.Open();
            string query = "SELECT * FROM TableUye WHERE AdSoyad='"+ textBoxAra.Text +"';";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);   
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder();
            var dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridViewUyeleriGoruntule.DataSource = dataSet.Tables[0];
            sqlConnection.Close();
        }
        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Home home = new Home(); 
            home.Show();
            this.Hide();
        }

        private void dataGridViewUyeleriGoruntule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UyeleriGoruntule_Load(object sender, EventArgs e)
        {
            getDataFromDatabase();
        }

        private void textBoxAra_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            filterName();
            textBoxAra.Text = "";
        }
    }
}
