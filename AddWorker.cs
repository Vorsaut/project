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
    public partial class AddWorker : Form
    {
        public AddWorker()
        {
            InitializeComponent();
        }

        MySqlConnection conn;

        private void AddWorker_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection("server=chuc.sdlik.ru;port=33333;user=nikolaev_vkr;database=nikolaev_vkr;password=dj2o3mjj1ds;");
            GetPosts();
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

        public void InsertWorker(TextBox fio, TextBox qualification, ComboBox post, TextBox education)
        {
            MySqlCommand cmd = new MySqlCommand($"insert into Workers (FIO, Qualification, Post, Education) values ('{fio.Text}','{qualification.Text}','{post.Text}','{education.Text}')", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            InsertWorker(fioText, qualificationText, postCombo, educationText);
        }
    }
}
