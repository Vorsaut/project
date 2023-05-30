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

        static string sha256(string value)
        {
            var crypt = new System.Security.Cryptography.SHA256Managed();
            var hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(value));
            foreach (byte bt in crypto)
            {
                hash.Append(bt.ToString("x2"));
            }
            return hash.ToString();
        }

        bool Authorization()
        {
            bool result;
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            MySqlCommand cmd = new MySqlCommand("select ACCName, Role from AccauntsData where login = @aL and password = @aP", conn);
            cmd.Parameters.Add("@aL", MySqlDbType.VarChar, 25).Value = login;
            cmd.Parameters.Add("@aP", MySqlDbType.VarChar, 25).Value = sha256(textBoxPassword.Text);
            conn.Open();
            daAd.SelectCommand = cmd;
            daAd.Fill(dT);
            conn.Close();
            if (dT.Rows.Count > 0)
            {
                MySqlCommand com = new MySqlCommand($"select Role from AccauntsData where login = '{login}'", conn);
                conn.Open();
                ACData.data = Convert.ToInt32(com.ExecuteScalar());
                conn.Close();
                result = true;
            }
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
            if (result == true)
            {
                this.Hide();
                mainWindow.Show();
            }
            else
                MessageBox.Show("Логин или пароль не правельны","Error");
            
        }
    }
}
