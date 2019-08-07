using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Szakdolgozat1
{
    public partial class Alkatresz_felvitel : Form
    {
        static string MySQLConnectionString = "Datasource=localhost; port=3306; username=figlerr; password=Napsugar; database=szervizkeszletezorendszer ; SslMode=none";
        MySqlConnection con = new MySqlConnection(MySQLConnectionString);
        public Alkatresz_felvitel()
        {
            InitializeComponent();
        }

        private void Alkatresz_felvitel_Load(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select imei1 from adatlapok where javitasdatuma = 0000-00-00";
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Alkfeljavravar2.Items.Add(reader.GetValue(i).ToString());
                }
            }

            con.Close();
        }

        private void Alkfelpdf2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               Alkfelpdf3.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void Alkfelalkatresz1_Click(object sender, EventArgs e)
        {

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

        private void Alkfeldatum1_Click(object sender, EventArgs e)
        {
            Alkfeldatum2.Text = System.DateTime.Today.ToShortDateString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Alkfeltipus3_Click(object sender, EventArgs e)
        {
            
        }

        private void Alkfelfodarab3_Click(object sender, EventArgs e)
        {
            

        }

        private void Alkfelalkatresz3_Click(object sender, EventArgs e)
        {
           

        }

        private void Alkfelalkatresz5_Click(object sender, EventArgs e)
        {
            
        }

        private void Alkfelmentes_Click(object sender, EventArgs e)
        {
            if (Alkfeljaveredmeny2.SelectedItem == null || Alkfeldatum2.Text == "" || Alkfeljavravar2.SelectedItem == null || Alkfeltipus2.SelectedItem == null || Alkfeljav2.SelectedItem == null)
            {
                MessageBox.Show(this, "Nincs minden mező kitöltve!", "HIÁNYOS ŰRLAP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update adatlapok set felhasznaltalkatresz=@felhasznaltalkatresz,felhasznaltfodarab=@felhasznaltfodarab,javitasieredmeny=@javitasieredmeny,sablonszoveg=@sablonszoveg,javitasdatuma=@javitasdatuma where imei1=@imei1";
                cmd.Parameters.AddWithValue("@felhasznaltalkatresz", Alkfelalkatresz4.SelectedItem);
                cmd.Parameters.AddWithValue("@felhasznaltfodarab", Alkfelfodarab2.SelectedItem);
                cmd.Parameters.AddWithValue("@javitasieredmeny", Alkfeljaveredmeny2.SelectedItem);
                cmd.Parameters.AddWithValue("@sablonszoveg", Alkfelpdf3.Text);
                cmd.Parameters.AddWithValue("@javitasdatuma", Alkfeldatum2.Text);
                cmd.Parameters.AddWithValue("@imei1", Alkfeljavravar2.SelectedItem);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                MySqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "update alkatreszek set felhasznalasdatuma=@felhasznalasdatuma,statusz=@statusz,felhasznalas=@felhasznalas where azonosito=@azonosito";
                cmd1.Parameters.AddWithValue("@felhasznalasdatuma", Alkfeldatum2.Text);
                cmd1.Parameters.AddWithValue("@statusz", "felhasznált");
                cmd1.Parameters.AddWithValue("@felhasznalas", Alkfeljav2.SelectedItem);
                cmd1.Parameters.AddWithValue("@azonosito", Alkfelalkatresz4.SelectedItem);
                DataTable dt1 = new DataTable();
                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
                da1.Fill(dt1);
                MySqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "update fodarabok set felhasznalasdatuma=@felhasznalasdatuma,statusz=@statusz,felhasznalas=@felhasznalas where imei2=@imei2";
                cmd2.Parameters.AddWithValue("@felhasznalasdatuma", Alkfeldatum2.Text);
                cmd2.Parameters.AddWithValue("@statusz", "felhasznált");
                cmd2.Parameters.AddWithValue("@felhasznalas", Alkfeljav2.SelectedItem);
                cmd2.Parameters.AddWithValue("@imei2", Alkfelfodarab2.SelectedItem);
                DataTable dt2 = new DataTable();
                MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
                da2.Fill(dt2);
                MessageBox.Show("Sikeres mentés");
                Alkatresz_felvitel.ActiveForm.Close();
                con.Close();
            }
        }

        private void Alkfeljavravar3_Click(object sender, EventArgs e)
        {

        }

        private void Alkfelalkatresz2_SelectedValueChanged(object sender, EventArgs e)
        {
            con.Open();
            Alkfelalkatresz4.Items.Clear();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select azonosito from alkatreszek where alkatreszkod=@alkatreszkod and statusz=@statusz";
            cmd.Parameters.AddWithValue("@alkatreszkod", Alkfelalkatresz2.SelectedItem);
            cmd.Parameters.AddWithValue("@statusz", "készleten");
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Alkfelalkatresz4.Items.Add(reader.GetValue(i).ToString());
                }
            }

            con.Close();
        }

        private void Alkfeljavravar2_SelectedValueChanged(object sender, EventArgs e)
        {
            Alkfeltipus2.Items.Clear();
            Alkfeljav2.Items.Clear();
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select tipus from adatlapok where imei1=@imei1";
            cmd.Parameters.AddWithValue("@imei1", Alkfeljavravar2.SelectedItem);
            MySqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select garancialisfizetos from adatlapok where imei1=@imei1";
            cmd1.Parameters.AddWithValue("@imei1", Alkfeljavravar2.SelectedItem);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Alkfeltipus2.Items.Add(reader.GetValue(i).ToString());
                }
            }
            reader.Close();

            reader = cmd1.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Alkfeljav2.Items.Add(reader.GetValue(i).ToString());
                }
            }


            con.Close();
        }

        private void Alkfeltipus2_SelectedValueChanged(object sender, EventArgs e)
        {
            con.Open();
            Alkfelfodarab2.Items.Clear();
            Alkfelalkatresz2.Items.Clear();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select imei2 from fodarabok where tipus=@tipus and statusz=@statusz";
            cmd.Parameters.AddWithValue("@tipus", Alkfeltipus2.Text);
            cmd.Parameters.AddWithValue("@statusz", "készleten");
            MySqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select alkatreszkod from alkatreszek where tipus=@tipus";
            cmd1.Parameters.AddWithValue("@tipus", Alkfeltipus2.Text);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Alkfelfodarab2.Items.Add(reader.GetValue(i).ToString());
                }
            }
            reader.Close();
           
            reader = cmd1.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Alkfelalkatresz2.Items.Add(reader.GetValue(i).ToString());
                }
            }


            con.Close();
        }
    }
}

