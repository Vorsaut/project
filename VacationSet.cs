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
        }
    }
}
