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
    public partial class Kereses_urlapok : Form
    {
        static string MySQLConnectionString = "Datasource=localhost; port=3306; username=figlerr; password=Napsugar; database=szervizkeszletezorendszer ; SslMode=none";
        MySqlConnection con = new MySqlConnection(MySQLConnectionString);
        
        public Kereses_urlapok()
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

        private void Kereses_urlapok_Load(object sender, EventArgs e)
        {

        }

        private void Keresesimei3_Click(object sender, EventArgs e)
        {
            Keresesazonosito2.Items.Clear();
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select adatlapazonosito from adatlapok where imei1=@imei1";
            cmd.Parameters.AddWithValue("@imei1", Keresesimei2.Text);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {   
                    Keresesazonosito2.Items.Add(reader.GetValue(i).ToString());
                }
            }
            con.Close();
        }

        private void Keresesazonosito3_SelectedValueChanged(object sender, EventArgs e)
        {

            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select nev, cim, tipus, imei1, hiba, garancialisfizetos, felhasznaltalkatresz, felhasznaltfodarab,javitasieredmeny, sablonszoveg from adatlapok where adatlapazonosito=@adatlapazonosito";
            cmd.Parameters.AddWithValue("@adatlapazonosito", Keresesazonosito2.SelectedItem);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            Kereseseredmenylista1.DataSource = dt;
            con.Close();


        }

        private void Keresesimei4_Click(object sender, EventArgs e)
        {
            Keresesimei2.Text = "";
            Keresesazonosito2.SelectedItem = "";
            Keresesazonosito2.SelectedValue = "";
            Keresesazonosito2.ResetText();
            Keresesazonosito2.Items.Clear();
        }
    }
}
