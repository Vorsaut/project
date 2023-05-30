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
    public partial class WorkerEdit : Form
    {
        public WorkerEdit()
        {
            InitializeComponent();
        }

        MySqlConnection conn;
        public string id;

        private void WorkerEdit_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection("server=chuc.sdlik.ru;port=33333;user=nikolaev_vkr;database=nikolaev_vkr;password=dj2o3mjj1ds;");
            GetPosts();
            ageText.Text = GetInfo("Age");
            postCombo.Text = GetInfo("IdPost");
            expText.Text = GetInfo("StajRaboti");
            salaryText.Text = GetInfo("Salary");
        }

        public string GetInfo(string column)
        {
            MySqlCommand cmd = new MySqlCommand($"select {column} from Workers where ID = '{id}'", conn);
            conn.Open();
            string result = Convert.ToString(cmd.ExecuteScalar());
            conn.Close();
            return result;
        }

        public void WorkerUpdate()
        {
            MySqlCommand cmd = new MySqlCommand($"update Workers set Age = '{ageText.Text}', IdPost = '{postCombo.Text}', StajRaboti = '{expText.Text}', Salary = '{salaryText.Text}' ", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void GetPosts()
        {
            MySqlCommand cmd = new MySqlCommand("select Post from Posts", conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                postCombo.Items.Add(reader.GetString(0));
            conn.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            WorkerUpdate();
        }
    }
}
