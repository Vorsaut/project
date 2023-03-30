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
    public partial class Workers : Form
    {
        public Workers()
        {
            InitializeComponent();
        }

        MySqlConnection conn;
        MySqlDataAdapter MyDA = new MySqlDataAdapter();
        BindingSource bSource = new BindingSource();
        DataSet ds = new DataSet();
        DataTable table = new DataTable();
        string idSelectedRow = "0";

        private void Workers_Load(object sender, EventArgs e)
        {
            string connStr = "server=chuc.sdlik.ru;port=33333;user=nikolaev_vkr;database=nikolaev_vkr;password=dj2o3mjj1ds;";
            conn = new MySqlConnection(connStr);
            GetListWorkers();

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

        public void GetListWorkers()
        {
            string commandStr = "SELECT ID AS 'ID', FIO AS 'ФИО', Obrazovanie AS 'Образование', Doljnost AS 'Должность', Kvalifikaciya AS 'Квалификация', Cnils AS 'Снилс', zarplata AS 'Зарплата' FROM Sotr";
            conn.Open();
            MyDA.SelectCommand = new MySqlCommand(commandStr, conn);
            MyDA.Fill(table);
            bSource.DataSource = table;
            dataGridView1.DataSource = bSource;
            conn.Close();
            int count_rows = dataGridView1.RowCount - 1;
        }

        public void ReloadList()
        {
            table.Clear();
            GetListWorkers();
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!e.RowIndex.Equals(-1) && !e.ColumnIndex.Equals(-1) && e.Button.Equals(MouseButtons.Right))
            {
                dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex, e.RowIndex];
                dataGridView1.CurrentCell.Selected = true;
                GetSelectedIDString();
            }
        }

        public void DeleteRow(string deletedRow)
        {
            MySqlCommand comm = new MySqlCommand($"Delete from Sotr where ID = '{deletedRow}'", conn);
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
                MessageBox.Show("Удаление прошло успешно", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления строки \n" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            finally
            {
                conn.Close();
                ReloadList();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ReloadList();
        }

        public void GetSelectedIDString()
        {
            string selectedRow;
            selectedRow = dataGridView1.SelectedCells[0].RowIndex.ToString();
            idSelectedRow = dataGridView1.Rows[Convert.ToInt32(selectedRow)].Cells[0].Value.ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteRow(idSelectedRow);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
