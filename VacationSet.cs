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
    public partial class VacationSet : Form
    {
        public VacationSet()
        {
            InitializeComponent();
        }

        
        public string fio;
        MySqlConnection conn;

        private void VacationSet_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection("server=chuc.sdlik.ru;port=33333;user=nikolaev_vkr;database=nikolaev_vkr;password=dj2o3mjj1ds;");
            dateTimePicker1.MinDate = DateTime.Today;
        }

        public int DateMath()
        {
            try
            {
                conn = new MySqlConnection("server=chuc.sdlik.ru;port=33333;user=nikolaev_vkr;database=nikolaev_vkr;password=dj2o3mjj1ds;");
                MySqlCommand cmd = new MySqlCommand($"select Otpusk from Vacations where FIO = '{fio}'", conn);
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
                dateTimePicker2.MaxDate = dateTimePicker1.Value.AddDays(DateMath()-1);
                dateTimePicker2.MinDate = dateTimePicker1.Value;
            }
            catch (Exception ex)
            {
                dateTimePicker2.MinDate = dateTimePicker1.Value;
                dateTimePicker2.MaxDate = dateTimePicker1.Value.AddDays(DateMath()-1);
            }
        }

        private void dateSetButton_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand($"update Vacations set Calendar = ('с {dateTimePicker1.Value.ToShortDateString()} по {dateTimePicker2.Value.ToShortDateString()}') where FIO = '{fio}'", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            CalendarEdit();
        }
    }
}
