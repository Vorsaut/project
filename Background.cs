using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace project
{
    internal class Background
    {

        MySqlConnection conn = new MySqlConnection("server=chuc.sdlik.ru;port=33333;user=nikolaev_vkr;database=nikolaev_vkr;password=dj2o3mjj1ds;");

        //метод для вставки фио в таблицу vacations
        public void ChainInsert(string fio)
        {
            MySqlCommand cmd = new MySqlCommand($"insert into Vacations (FIO) values ({fio})", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void IDJoin()
        {
            MySqlCommand cmd = new MySqlCommand("select Workers.ID, Vacations.FIO from Workers join Vacations on Vacations.FIO = Workers.FIO", conn);
        }


        //метод обновления строк
        public void ChainUpdate(string fio)
        {
            //int ID;
            //string FIO;
            //MySqlDataAdapter daAD = new MySqlDataAdapter();
            //DataSet ds = new DataSet();
            //DataTable table = new DataTable();
            //MySqlCommand cmd;
            //conn.Open();
            //daAD.SelectCommand = new MySqlCommand("select ID, FIO from Workers", conn);
            //daAD.Fill(table);
            //int count = table.Rows.Count;
            //for (int i = 0; i < count; i++)
            //{
            //    cmd = new MySqlCommand($"insert into Vacations (ID, FIO) values ('{Convert.ToInt32(table.Rows[0][i].ToString())}', '{table.Rows[1][i].ToString()}'", conn);
            //}
            //MySqlCommand cmd = new MySqlCommand("insert into Vacations (ID, FIO) select ID, FIO from Workers", conn);
            MySqlCommand cmd = new MySqlCommand($"update Vacations set FIO = '{fio}'", conn) ;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        
    }
}
