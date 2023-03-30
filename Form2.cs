using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace project
{
    public partial class Form2 : Form
    {
        private Form activeWindow = null;
        private Button activeButton = null;
        private Workers workers = new Workers();
        private PlaceHolder placeHolder = new PlaceHolder();
        public MySqlConnection conn;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string connStr = "server=chuc.sdlik.ru;port=33333;user=nikolaev_vkr;database=nikolaev_vkr;password=dj2o3mjj1ds;";
            conn = new MySqlConnection(connStr);
            activeButton = button1;
            activeWindow = placeHolder;
            placeHolder.Show();
        }

        private void WindowLoad(Form window, Button presedButton)
        {
            activeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular);
            activeWindow.Close();
            window.FormBorderStyle = FormBorderStyle.None;
            window.Dock = DockStyle.Fill;
            window.TopLevel = false;
            this.panelFront.Controls.Add(window);
            this.panelFront.Tag = window;
            window.BringToFront();  
            window.Show();
            activeButton = presedButton;
            activeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowLoad(workers, workerButton);
        }
    }
}
