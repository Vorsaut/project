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
    public partial class Auth : Form
    {
        MySqlConnection conn;
        MainWindow mainWindow = new MainWindow();
        MySqlDataAdapter daAd = new MySqlDataAdapter();
        DataTable dT = new DataTable();

        public Auth()
        {
            InitializeComponent();
        }

        private void WindowLoad(Form window)
        {
            window.FormBorderStyle = FormBorderStyle.None;
            window.Dock = DockStyle.Fill;
            window.TopLevel = false;
            this.panelWindow.Controls.Add(window);
            this.panelWindow.Tag = window;
            window.BringToFront();
            window.Show();
        }

        bool ConnCheck()
        {
            try
            {
                conn.Open();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения " + ex.Message);
                return false;
            }
        }

        bool Authorization()
        {
            bool result;
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            MySqlCommand cmd = new MySqlCommand("select ACCName from AccauntsData where login = @aL and password = @aP", conn);
            cmd.Parameters.Add("@aL", MySqlDbType.VarChar).Value = login;
            cmd.Parameters.Add("@aP", MySqlDbType.VarChar).Value = password;
            conn.Open();
            daAd.SelectCommand = cmd;
            daAd.Fill(dT);
            conn.Close();
            if (dT.Rows.Count > 0)
                result = true;
            else
                result = false;
            return result;
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection("server=chuc.sdlik.ru;port=33333;user=nikolaev_vkr;database=nikolaev_vkr;password=dj2o3mjj1ds;");
            bool status = ConnCheck();
            if (status == true)
            {
                buttonConnStatus.BackColor = Color.Green;
                labelConnStatus.Text = "Статус подключения: подключено";
            }
            else
            {
                buttonConnStatus.BackColor = Color.Red;
                labelConnStatus.Text = "Статус подключения: отключено";
            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            bool result = Authorization();
            /*
            if (result == true)
                WindowLoad(mainWindow);
            */
            if (result == true)
            {
                this.Hide();
                mainWindow.Show();
            }
            else
                MessageBox.Show("неправильно блять");
            
        }
    }
}
