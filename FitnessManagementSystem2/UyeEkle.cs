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
    public partial class UyeEkle : Form
    {
        public UyeEkle()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-BURAK;Initial Catalog=FMSDatabase;Integrated Security=True;");

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

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            if (textBoxAdSoyad.Text == "" || textBoxTelefonNo.Text == "" || textBoxUcret.Text == "" || textBoxYas.Text == "" || comboBoxCinsiyet.Text == "")
            {
                MessageBox.Show("Eksik bilgi girdiniz.");   
            }
            else
            {
                sqlConnection.Open();
                string query = "INSERT INTO TableUye VALUES('" + textBoxAdSoyad.Text + "', '" + textBoxTelefonNo.Text + "', '" + textBoxYas.Text + "', '" + comboBoxCinsiyet.SelectedItem.ToString() + "', '" + textBoxUcret.Text + "')";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Üye başarıyla eklendi.");
                sqlConnection.Close();
                textBoxAdSoyad.Text = "";
                textBoxTelefonNo.Text = "";
                textBoxYas.Text = "";
                textBoxUcret.Text = "";
                comboBoxCinsiyet.Text = "";
            }
        }

        private void UyeEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
