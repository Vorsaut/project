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
    public partial class MainWindow : Form
    {
        private Form activeWindow = null;
        private Button activeButton = null;
        private Workers workers = new Workers();
        private Vacations vacations = new Vacations();
        public MySqlConnection conn;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            string connStr = "server=chuc.sdlik.ru;port=33333;user=nikolaev_vkr;database=nikolaev_vkr;password=dj2o3mjj1ds;";
            conn = new MySqlConnection(connStr);
        }

        private void WindowLoad(Form window, Button presedButton)
        {
            if(activeButton != null)
            {
                activeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular);
                activeButton.BackColor = Color.DodgerBlue;
                activeWindow.Hide();
            }
            window.FormBorderStyle = FormBorderStyle.None;
            window.Dock = DockStyle.Fill;
            window.TopLevel = false;
            this.panelFront.Controls.Add(window);
            this.panelFront.Tag = window;
            window.BringToFront();  
            window.Show();
            activeWindow = window;
            activeButton = presedButton;
            activeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold);
            activeButton.BackColor= Color.OrangeRed;
        }

        private void workersButton_Click(object sender, EventArgs e)
        {
            WindowLoad(workers, workerButton);
        }

        private void vacationsButton_Click(object sender, EventArgs e)
        {
            WindowLoad(vacations, vacationsButton);
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
