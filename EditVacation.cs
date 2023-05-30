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


        private Form activeWindow = null;
        private Button activeButton = null;
        VacationSet vacationSet = new VacationSet();
        VacationDateEdit vacationDateEdit = new VacationDateEdit();
        public string fio;
        MySqlConnection conn;

        private void EditVacation_Load(object sender, EventArgs e)
        {
            editDataButton.Enabled = false;
            vacationSetButton.Enabled = false;
            conn = new MySqlConnection("server=chuc.sdlik.ru;port=33333;user=nikolaev_vkr;database=nikolaev_vkr;password=dj2o3mjj1ds;");
            MySqlCommand cmd = new MySqlCommand("select FIO from Vacations", conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                fioComboBox.Items.Add(reader.GetString(0));
            conn.Close();
        }

        private void WindowLoad(Form window, Button presedButton)
        {
            if (activeButton != null)
            {
                activeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
                activeButton.BackColor = Color.Transparent;
                activeWindow.Hide();
            }
            window.FormBorderStyle = FormBorderStyle.None;
            window.Dock = DockStyle.Fill;
            window.TopLevel = false;
            this.windowPanel.Controls.Add(window);
            this.windowPanel.Tag = window;
            window.BringToFront();
            window.Show();
            activeWindow = window;
            activeButton = presedButton;
            activeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            activeButton.BackColor = Color.LightGray;
        }

        private void editData_Click(object sender, EventArgs e)
        {
           WindowLoad(vacationDateEdit, editDataButton);
        }

        private void vacationSet_Click(object sender, EventArgs e)
        {
            WindowLoad(vacationSet, vacationSetButton);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fioComboBox_TextChanged(object sender, EventArgs e)
        {
            vacationSet.fio = fioComboBox.Text;
            vacationSet.CalendarEdit();
            vacationDateEdit.fio = fioComboBox.Text;
            editDataButton.Enabled = true;
            vacationSetButton.Enabled = true;
        }
    }
}
