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
    public partial class Kereses_alkatresz : Form
    {
        static string MySQLConnectionString = "Datasource=localhost; port=3306; username=figlerr; password=Napsugar; database=szervizkeszletezorendszer ; SslMode=none";
        MySqlConnection con = new MySqlConnection(MySQLConnectionString);
        public Kereses_alkatresz()
        {
            InitializeComponent();
        }

        private void Kereses_alkatresz_Load(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select tipus from telefontipusok";
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Keresesteltipus2.Items.Add(reader.GetValue(i).ToString());
                }
            }

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

        private void Keresesteltipus2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Keresesalkkod2.Items.Clear();
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select elolapkod, kamerakod, hatlapkod, akku from telefontipusok where tipus=@tipus";
            cmd.Parameters.AddWithValue("@tipus", Keresesteltipus2.SelectedItem);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Keresesalkkod2.Items.Add(reader.GetValue(i).ToString());
                }
            }


            con.Close();
        }

        private void Keresesalkkod2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int db = 0;
            Kereseseredmenydb1.Text = "";
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select azonosito, tipus, alkatreszkod, beszerzesiar from alkatreszek where alkatreszkod=@alkatreszkod and statusz=@statusz";
            cmd.Parameters.AddWithValue("@alkatreszkod", Keresesalkkod2.SelectedItem);
            cmd.Parameters.AddWithValue("@statusz", "készleten");
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            Kereseseredmenylista2.DataSource = dt;
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    db++;
                }
            }
            reader.Close();
            Kereseseredmenydb1.Text = db/4 + "";
            con.Close();
        }
    }
}
