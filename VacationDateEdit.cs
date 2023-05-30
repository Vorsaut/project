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
    public partial class VacationDateEdit : Form
    {
        public VacationDateEdit()
        {
            InitializeComponent();
        }

        MySqlConnection conn;
        public string fio;

        private void VacationDateEdit_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection("server=chuc.sdlik.ru;port=33333;user=nikolaev_vkr;database=nikolaev_vkr;password=dj2o3mjj1ds;");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand($"update Vacations set WorkedMonths = '{comboBox1.Text}', Otpusk = '{Convert.ToInt32(comboBox1.Text)*2}' where FIO = '{fio}'", conn);
            conn.Open();
            cmd.ExecuteScalar();
            conn.Close();
        }
    }
}
