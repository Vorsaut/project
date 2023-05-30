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

        MySqlConnection conn;
        MySqlDataAdapter daAD = new MySqlDataAdapter();
        BindingSource bSource = new BindingSource();
        DataSet ds = new DataSet();
        DataTable table = new DataTable();
        public string fioSelectedRow;

        private void Vacations_Load(object sender, EventArgs e)
        {
            if (ACData.data == 0)
            {
                toolStrip1.Enabled = false;
                toolStrip1.Visible = false;
            }
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

        public void GetSelectedIDString()
        {
            string selectedRow;
            selectedRow = dataGridView1.SelectedCells[0].RowIndex.ToString();
            fioSelectedRow = dataGridView1.Rows[Convert.ToInt32(selectedRow)].Cells[0].Value.ToString();
        }

        public void GetList()
        {
            string commandStr = "SELECT FIO AS 'ФИО', WorkedMonths AS 'Отработанные Месяца', Salary AS 'Деньги', Otpusk AS 'Количество отпускых дней', Calendar AS 'Календарь' FROM Vacations";
            conn.Open();
            daAD.SelectCommand = new MySqlCommand(commandStr, conn);
            daAD.Fill(table);
            bSource.DataSource = table;
            dataGridView1.DataSource = bSource;
            conn.Close();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            table.Clear();
            GetList();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            EditVacation editVacation = new EditVacation();
            editVacation.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
                dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex, e.RowIndex];
                dataGridView1.CurrentCell.Selected = true;
                GetSelectedIDString();
            
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex, e.RowIndex];
            dataGridView1.CurrentCell.Selected = true;
            GetSelectedIDString();
        }
    }
}
