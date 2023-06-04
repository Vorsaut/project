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
    public partial class EditVacation : Form
    {
        public EditVacation()
        {
            InitializeComponent();
        }
        MySqlConnection conn;

        private void EditVacation_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection("server=chuc.sdlik.ru;port=33333;user=nikolaev_vkr;database=nikolaev_vkr;password=dj2o3mjj1ds;");
            MySqlCommand cmd = new MySqlCommand("select FIO from Vacations", conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                fioComboBox.Items.Add(reader.GetString(0));
            conn.Close();
            dateTimePicker1.MinDate = DateTime.Today;
        }

        public int DateMath()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand($"select Otpusk from Vacations where FIO = '{fioComboBox.Text}'", conn);
                conn.Open();
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
                return result;
            }
            catch (Exception ex)
            {
                return 1;
            }
        }

        public void CalendarEdit()
        {
            try
            {
                dateTimePicker2.MaxDate = dateTimePicker1.Value.AddDays(DateMath() - 1);
                dateTimePicker2.MinDate = dateTimePicker1.Value;
            }
            catch (Exception ex)
            {
                dateTimePicker2.MinDate = dateTimePicker1.Value;
                dateTimePicker2.MaxDate = dateTimePicker1.Value.AddDays(DateMath() - 1);
            }
        }

        private void fioComboBox_TextChanged(object sender, EventArgs e)
        {
            //MySqlCommand cmd = new MySqlCommand("select FIO from Vacations where");
            CalendarEdit();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand($"update Vacations set WorkedMonths = '{comboBox1.Text}', Otpusk = '{Convert.ToInt32(comboBox1.Text) * 2}' where FIO = '{fioComboBox.Text}'", conn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            cmd.ExecuteScalar();
            conn.Close();
            CalendarEdit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand($"update Vacations set WorkedMonths = '{comboBox1.Text}', Otpusk = '{Convert.ToInt32(comboBox1.Text) * 2}' where FIO = '{fioComboBox.Text}'", conn);
            conn.Open();
            cmd.ExecuteScalar();
            conn.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            CalendarEdit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand($"update Vacations set Calendar = ('с {dateTimePicker1.Value.ToShortDateString()} по {dateTimePicker2.Value.ToShortDateString()}') where FIO = '{fioComboBox.Text}'", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
