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
    
    public partial class Uj_Alkatresz : Form
    {
        static string MySQLConnectionString = "Datasource=localhost; port=3306; username=figlerr; password=Napsugar; database=szervizkeszletezorendszer ; SslMode=none";
        MySqlConnection con = new MySqlConnection(MySQLConnectionString);
        public Uj_Alkatresz()
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

        private void Keszletekdatum1_Click(object sender, EventArgs e)
        {
            Keszletekdatum2.Text = System.DateTime.Today.ToShortDateString();
        }

        private void Uj_Alkatresz_Load(object sender, EventArgs e)
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
                    Keszletektipus2.Items.Add(reader.GetValue(i).ToString());
                }
            }

            con.Close();
        }

        private void Keszletektipus2_SelectedValueChanged(object sender, EventArgs e)
        {
            Keszletekalkkod2.Items.Clear();
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select elolapkod, kamerakod, hatlapkod, akku from telefontipusok where tipus=@tipus";
            cmd.Parameters.AddWithValue("@tipus", Keszletektipus2.SelectedItem);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Keszletekalkkod2.Items.Add(reader.GetValue(i).ToString());
                }
            }


            con.Close();
        }

        private void Keszletekfelvitel1_Click(object sender, EventArgs e)
        {
            if (Keszletektipus2.SelectedItem == null || Keszletekalkkod2.SelectedItem == null || Keszletekalkkod4.Text == "" || Keszletekar2.Text == "" || Keszletekdatum2.Text == "")
            {
                MessageBox.Show(this, "Nincs minden mező kitöltve!", "HIÁNYOS ŰRLAP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into alkatreszek(azonosito,alkatreszkod,tipus,beszerzesiar,beszerzesdatuma,statusz) values (@azonosito,@alkatreszkod,@tipus,@beszerzesiar,@beszerzesdatuma,@statusz)";
                cmd.Parameters.AddWithValue("@azonosito", Keszletekalkkod4.Text);
                cmd.Parameters.AddWithValue("@alkatreszkod", Keszletekalkkod2.SelectedItem);
                cmd.Parameters.AddWithValue("@tipus", Keszletektipus2.SelectedItem);
                cmd.Parameters.AddWithValue("@beszerzesiar", Keszletekar2.Text);
                cmd.Parameters.AddWithValue("@beszerzesdatuma", Keszletekdatum2.Text);
                cmd.Parameters.AddWithValue("@statusz", "készleten");
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                MessageBox.Show("Sikeres mentés");
                Keszletekalkkod4.Text = "";
                Keszletekar2.Text = "";
                Keszletekdatum2.Text = "";
                con.Close();
            }
        }
    }
}
