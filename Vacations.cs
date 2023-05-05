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
    public partial class Vacations : Form
    {
        public Vacations()
        {
            InitializeComponent();
        }

        Background background = new Background();
        MySqlConnection conn;
        MySqlDataAdapter daAD = new MySqlDataAdapter();
        BindingSource bSource = new BindingSource();
        DataSet ds = new DataSet();
        DataTable table = new DataTable();

        private void Vacations_Load(object sender, EventArgs e)
        {
            //background.ChainUpdate();
            conn = new MySqlConnection("server=chuc.sdlik.ru;port=33333;user=nikolaev_vkr;database=nikolaev_vkr;password=dj2o3mjj1ds;");
            GetList();

            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[1].Visible = true;
            dataGridView1.Columns[2].Visible = true;
            dataGridView1.Columns[3].Visible = true;
            dataGridView1.Columns[4].Visible = true;

            dataGridView1.Columns[0].FillWeight = 15;
            dataGridView1.Columns[1].FillWeight = 40;
            dataGridView1.Columns[2].FillWeight = 15;
            dataGridView1.Columns[3].FillWeight = 15;
            dataGridView1.Columns[4].FillWeight = 15;

            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = false;
            dataGridView1.Columns[2].ReadOnly = false;
            dataGridView1.Columns[3].ReadOnly = false;
            dataGridView1.Columns[4].ReadOnly = false;

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = true;
        }

        public void GetList()
        {
            string commandStr = "SELECT ID AS 'ID', FIO AS 'ФИО', WorkedHours AS 'Отработанные часы', Salary AS 'Деньги', Days AS 'Дни' FROM Vacations";
            conn.Open();
            daAD.SelectCommand = new MySqlCommand(commandStr, conn);
            daAD.Fill(table);
            bSource.DataSource = table;
            dataGridView1.DataSource = bSource;
            conn.Close();
        }


        //public string Salary(string aue)
        //{
        //    string post;
        //    conn.Open();
        //    MySqlCommand cmd = new MySqlCommand("select Post from workers");
        //    switch (post = )
        //    {

        //    }
        //}

        //public string Vacations()
        //{

        //}

    }
}
