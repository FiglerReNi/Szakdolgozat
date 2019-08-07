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
using MySql.Data;


namespace Szakdolgozat1
{
    public partial class Selejtezes : Form
    {
        static string MySQLConnectionString = "Datasource=localhost; port=3306; username=figlerr; password=Napsugar; database=szervizkeszletezorendszer ; SslMode=none";
        MySqlConnection con = new MySqlConnection(MySQLConnectionString);
        public Selejtezes()
        {
            InitializeComponent();
        }

        private void Urlapokuj_Click(object sender, EventArgs e)
        {
            Uj uj = new Uj();
            uj.ShowDialog();
        }

        private void Fooldaleladas_Click(object sender, EventArgs e)
        {
            Eladas eladas = new Eladas();
            eladas.ShowDialog();
        }

        private void Selejtezes_Load(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select elolapkod, kamerakod, hatlapkod, akku from telefontipusok";
            MySqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select tipus from telefontipusok";
            MySqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select  fehertok, feketetok, pinktok, folia from telefontipusok";
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Selejtezesalkatresz2.Items.Add(reader.GetValue(i).ToString());
                }
            }
            reader.Close();

            reader = cmd1.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Selejtezesfodarab2.Items.Add(reader.GetValue(i).ToString());
                    Selejtezestelefon2.Items.Add(reader.GetValue(i).ToString());
                }
            }
            reader.Close();
            reader = cmd2.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Selejtezestartozek2.Items.Add(reader.GetValue(i).ToString());
                }
            }
            reader.Close();


            con.Close();
        }

        private void Selejtezesalkatresz2_SelectedValueChanged(object sender, EventArgs e)
        {
            Selejtezesalkatresz3.Items.Clear();
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select azonosito from alkatreszek where alkatreszkod=@alkatreszkod and statusz=@statusz";
            cmd.Parameters.AddWithValue("@alkatreszkod", Selejtezesalkatresz2.SelectedItem);
            cmd.Parameters.AddWithValue("@statusz", "készleten");
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Selejtezesalkatresz3.Items.Add(reader.GetValue(i).ToString());
                }
            }

            con.Close();
        }

        private void Selejtezesfodarab2_SelectedValueChanged(object sender, EventArgs e)
        {
            Selejtezesfodarab3.Items.Clear();
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select imei2 from fodarabok where tipus=@tipus and statusz=@statusz";
            cmd.Parameters.AddWithValue("@tipus", Selejtezesfodarab2.SelectedItem);
            cmd.Parameters.AddWithValue("@statusz", "készleten");
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Selejtezesfodarab3.Items.Add(reader.GetValue(i).ToString());
                }
            }

            con.Close();
        }

        private void Selejtezestartozek2_SelectedValueChanged(object sender, EventArgs e)
        {
            Selejtezestartozek3.Items.Clear();
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select tartozekazonosito from tartozekok where megnevezes=@megnevezes and statusz=@statusz";
            cmd.Parameters.AddWithValue("@megnevezes", Selejtezestartozek2.SelectedItem);
            cmd.Parameters.AddWithValue("@statusz", "készleten");
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Selejtezestartozek3.Items.Add(reader.GetValue(i).ToString());
                }
            }

            con.Close();
        }

        private void Selejtezestelefon2_SelectedValueChanged(object sender, EventArgs e)
        {
            Selejtezestelefon3.Items.Clear();
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select imei3 from telefonok where tipus=@tipus and statusz=@statusz";
            cmd.Parameters.AddWithValue("@tipus", Selejtezestelefon2.SelectedItem);
            cmd.Parameters.AddWithValue("@statusz", "készleten");
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Selejtezestelefon3.Items.Add(reader.GetValue(i).ToString());
                }
            }

            con.Close();
        }

        private void Selejtezesalkatresz4_Click(object sender, EventArgs e)
        {        
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update alkatreszek set statusz=@statusz,selejt=@selejt where azonosito=@azonosito";
            cmd.Parameters.AddWithValue("@statusz", "selejt");
            cmd.Parameters.AddWithValue("@selejt", System.DateTime.Today.ToShortDateString());
            cmd.Parameters.AddWithValue("@azonosito", Selejtezesalkatresz3.SelectedItem);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            MessageBox.Show("Sikeres mentés");
            Selejtezesalkatresz3.Items.Clear();
            con.Close();
        }

        private void Selejtezesfodarab4_Click(object sender, EventArgs e)
        {          
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update fodarabok set statusz=@statusz,selejt=@selejt where imei2=@imei2";
            cmd.Parameters.AddWithValue("@statusz", "selejt");
            cmd.Parameters.AddWithValue("@selejt", System.DateTime.Today.ToShortDateString());
            cmd.Parameters.AddWithValue("@imei2", Selejtezesfodarab3.SelectedItem);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            MessageBox.Show("Sikeres mentés");
            Selejtezesfodarab3.Items.Clear();
            con.Close();
        }

        private void Selejtezestartozek4_Click(object sender, EventArgs e)
        {           
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update tartozekok set statusz=@statusz,selejt=@selejt where tartozekazonosito=@tartozekazonosito";
            cmd.Parameters.AddWithValue("@statusz", "selejt");
            cmd.Parameters.AddWithValue("@selejt", System.DateTime.Today.ToShortDateString());
            cmd.Parameters.AddWithValue("@tartozekazonosito", Selejtezestartozek3.SelectedItem);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            MessageBox.Show("Sikeres mentés");
            Selejtezestartozek3.Items.Clear();
            con.Close();
        }

        private void Selejtezestelefon4_Click(object sender, EventArgs e)
        {        
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update telefonok set statusz=@statusz,selejt=@selejt where imei3=@imei3";
            cmd.Parameters.AddWithValue("@statusz", "selejt");
            cmd.Parameters.AddWithValue("@selejt", System.DateTime.Today.ToShortDateString());
            cmd.Parameters.AddWithValue("@imei3", Selejtezestelefon3.SelectedItem);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            MessageBox.Show("Sikeres mentés");
            Selejtezestelefon3.Items.Clear();
            con.Close();
        }
    }
}
