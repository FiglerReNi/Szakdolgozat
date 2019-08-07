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
using System.IO;

namespace Szakdolgozat1
{
    public partial class Eladas : Form
    {
        static string MySQLConnectionString = "Datasource=localhost; port=3306; username=figlerr; password=Napsugar; database=szervizkeszletezorendszer ; SslMode=none";
        MySqlConnection con = new MySqlConnection(MySQLConnectionString);

        List<int> telefon = new List<int>();
        List<int> tartozek = new List<int>();
        int osszeg1;
        int osszeg2;
        int fizetendo;
        public Eladas()
        {
            InitializeComponent();
        }

        private void Eladás_Load(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select tipus from telefontipusok";
            MySqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select  fehertok, feketetok, pinktok, folia from telefontipusok";
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Eladastipus3.Items.Add(reader.GetValue(i).ToString());
                }
            }
            reader.Close();

            reader = cmd1.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Eladastipus2.Items.Add(reader.GetValue(i).ToString());
                }
            }
            reader.Close();
            con.Close();
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

        private void Eladasdatum1_Click(object sender, EventArgs e)
        {
            Eladasdatum2.Text = System.DateTime.Today.ToShortDateString();
        }

        private void Eladasdatum1_Click_1(object sender, EventArgs e)
        {
            Eladasdatum2.Text = System.DateTime.Today.ToShortDateString();
        }

        private void Eladasfizetendo1_Click(object sender, EventArgs e)
        {
            osszeg1 = 0;
            osszeg2 = 0;
            for (int i = 0; i < telefon.Count; i++)
            {
                osszeg1 = osszeg1 + telefon[i];
            }
            for (int i = 0; i < tartozek.Count; i++)
            {
                osszeg2 = osszeg2 + tartozek[i];
            }
            fizetendo = osszeg1 + osszeg2;
            Eladasfizetendo2.Text = (fizetendo + "");
        }



        private void Eladaskesz_Click(object sender, EventArgs e)
        {
            if (Eladasnev2.Text == "" || Eladascim2.Text == "" || Eladasfizetendo2.Text == "" || Eladasdatum2.Text == "")
            {
                MessageBox.Show(this, "Nincs minden mező kitöltve!", "HIÁNYOS ŰRLAP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string[] kiiras = new string[5];

                kiiras[0] = "Név: ;" + Eladasnev2.Text + " ;"; ;
                kiiras[1] = "Cím: ;" + Eladascim2.Text + ";";
                kiiras[2] = "Fizetendő: ;" + Eladasfizetendo2.Text + "Ft;";
                kiiras[3] = "Dátum: ;" + Eladasdatum2.Text + ";";
                kiiras[4] = Environment.NewLine;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.AppendAllLines(saveFileDialog1.FileName, kiiras, Encoding.Default);
                }
                //MessageBox.Show("Mentve")
            }
        }

        private void Eladasmegnevezes6_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select eladasiar from telefonok where imei3=@imei3";
            cmd.Parameters.AddWithValue("@imei3", Eladasmegnevezes6.SelectedItem);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    telefon.Add(int.Parse(reader.GetValue(i).ToString()));
                    MessageBox.Show("Sikeresen kosárba tetted");
                }
            }
            reader.Close();
            MySqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select imei3 from telefonok where imei3=@imei3";
            cmd1.Parameters.AddWithValue("@imei3", Eladasmegnevezes6.SelectedItem);
            reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Eladaskeszletrol2.Items.Add(reader.GetValue(i).ToString());
                }
            }
            con.Close();
        }

        private void Eladasmegnevezes4_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select eladasiar from tartozekok where tartozekazonosito=@tartozekazonosito";
            cmd.Parameters.AddWithValue("@tartozekazonosito", Eladasmegnevezes4.SelectedItem);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    tartozek.Add(int.Parse(reader.GetValue(i).ToString()));
                    MessageBox.Show("Sikeresen kosárba tetted");
                }
            }
            reader.Close();
            MySqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select tartozekazonosito from tartozekok where tartozekazonosito=@tartozekazonosito";
            cmd1.Parameters.AddWithValue("@tartozekazonosito", Eladasmegnevezes4.SelectedItem);
            reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Eladaskeszletrol2.Items.Add(reader.GetValue(i).ToString());
                }
            }
            con.Close();
        }

        private void Eladaskeszletrol2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update telefonok set statusz=@statusz,eladasdatuma=@eladasdatuma where imei3=@imei3";
            cmd.Parameters.AddWithValue("@statusz", "eladva");
            cmd.Parameters.AddWithValue("@eladasdatuma", System.DateTime.Today.ToShortDateString());
            cmd.Parameters.AddWithValue("@imei3", Eladaskeszletrol2.SelectedItem);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            MessageBox.Show("Sikeres eladás");
            MySqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "update tartozekok set statusz=@statusz,eladasdatuma=@eladasdatuma where tartozekazonosito=@tartozekazonosito";
            cmd1.Parameters.AddWithValue("@statusz", "eladva");
            cmd1.Parameters.AddWithValue("@eladasdatuma", System.DateTime.Today.ToShortDateString());
            cmd1.Parameters.AddWithValue("@tartozekazonosito", Eladaskeszletrol2.SelectedItem);
            DataTable dt1 = new DataTable();
            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
            da1.Fill(dt1);
            con.Close();
        }

        private void Eladastipus2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Eladasmegnevezes4.Items.Clear();
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select tartozekazonosito from tartozekok where megnevezes=@megnevezes and statusz=@statusz";
            cmd.Parameters.AddWithValue("@megnevezes", Eladastipus2.SelectedItem);
            cmd.Parameters.AddWithValue("@statusz", "készleten");
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Eladasmegnevezes4.Items.Add(reader.GetValue(i).ToString());
                }
            }

            con.Close();
        }

        private void Eladastipus3_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Eladasmegnevezes6.Items.Clear();
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select imei3 from telefonok where tipus=@tipus and statusz=@statusz";
            cmd.Parameters.AddWithValue("@tipus", Eladastipus3.SelectedItem);
            cmd.Parameters.AddWithValue("@statusz", "készleten");
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Eladasmegnevezes6.Items.Add(reader.GetValue(i).ToString());
                }
            }

            con.Close();
        }
    }
}

