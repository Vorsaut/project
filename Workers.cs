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
        MySqlDataAdapter daAD = new MySqlDataAdapter();
        BindingSource bSource = new BindingSource();
        DataSet ds = new DataSet();
        DataTable table = new DataTable();
        public string idSelectedRow = "0";
        string fioSelectedRow;

        private void Workers_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection("server=chuc.sdlik.ru;port=33333;user=nikolaev_vkr;database=nikolaev_vkr;password=dj2o3mjj1ds;");
            GetListWorkers();
            if(ACData.data == 0)
            {
                toolStrip2.Enabled = false;
                toolStrip2.Visible = false;
            }

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
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;

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
            string commandStr = "SELECT ID AS 'ID', FIO AS 'ФИО', Age AS 'Возраст', Gender AS 'Пол', IdPost AS 'Должность', StajRaboti AS 'Стаж работы', Salary AS 'Зарплата' FROM Workers";
            conn.Open();
            daAD.SelectCommand = new MySqlCommand(commandStr, conn);
            daAD.Fill(table);
            bSource.DataSource = table;
            dataGridView1.DataSource = bSource;
            conn.Close();
        }

        public void ReloadList()
        {
            table.Clear();
            GetListWorkers();
        }

        public void DeleteRow(string deletedRow, string deletedFio)
        {
            MySqlCommand cmd = new MySqlCommand($"Delete from Workers where ID = '{deletedRow}'", conn);
            MySqlCommand cmd1 = new MySqlCommand($"Delete from Vacations where FIO = '{deletedFio}'", conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
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

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!e.RowIndex.Equals(-1) && !e.ColumnIndex.Equals(-1) && e.Button.Equals(MouseButtons.Right))
            {
                dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex, e.RowIndex];
                dataGridView1.CurrentCell.Selected = true;
                GetSelectedIDString();
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
            fioSelectedRow = dataGridView1.Rows[Convert.ToInt32(selectedRow)].Cells[1].Value.ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteRow(idSelectedRow, fioSelectedRow);
        }

        private void addWorkersButton_Click(object sender, EventArgs e)
        {
            AddWorker addWorker = new AddWorker();
            addWorker.ShowDialog();
            table.Clear();
            GetListWorkers();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (ACData.data == 0)
                return;
            else
            {
                WorkerEdit workerEdit = new WorkerEdit();
                workerEdit.id = idSelectedRow;
                workerEdit.ShowDialog();
                table.Clear();
                GetListWorkers();
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex, e.RowIndex];
            dataGridView1.CurrentCell.Selected = true;
            GetSelectedIDString();
        }
    }
}
