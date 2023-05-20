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

        public void InsertWorker(TextBox fio, TextBox age, TextBox gender, TextBox number, TextBox place, TextBox snils, TextBox code, TextBox date ,ComboBox post)
        {
            MySqlCommand cmd = new MySqlCommand($"insert into Workers (FIO, Age, Gender, NumberPasport, LivePlace, Snils, CodePodrazdel, DataVidachi, IdPost) values ('{fio.Text}','{age.Text}','{gender.Text}','{number.Text}','{place.Text}','{snils.Text}','{code.Text}','{date.Text}','{post.Text}')", conn);
            MySqlCommand cmd1 = new MySqlCommand($"insert into Vacations (FIO) values ('{fio.Text}')", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
            conn.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            InsertWorker(fioText, ageText, genderText, numberpasportText, liveplaceText, snilsText, codeText, dateText, postCombo);
        }
    }
}
