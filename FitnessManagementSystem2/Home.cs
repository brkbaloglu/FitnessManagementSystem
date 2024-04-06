using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessManagementSystem2
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            UyeleriGoruntule uyeleriGoruntule = new UyeleriGoruntule();
            uyeleriGoruntule.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UyeEkle uyeEkle = new UyeEkle();
            uyeEkle.Show();
            this.Hide();
        }
    }
}
