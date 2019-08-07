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
    public partial class Uj_Telefon : Form
    {
        static string MySQLConnectionString = "Datasource=localhost; port=3306; username=figlerr; password=Napsugar; database=szervizkeszletezorendszer ; SslMode=none";
        MySqlConnection con = new MySqlConnection(MySQLConnectionString);
        public Uj_Telefon()
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

        private void Keszletekdatum7_Click(object sender, EventArgs e)
        {
            Keszletekdatum8.Text = System.DateTime.Today.ToShortDateString();
        }

        private void Keszletekfelvitel4_Click(object sender, EventArgs e)
        {
            if (Keszletektipus8.SelectedItem == null || Keszletekimei4.Text == "" || Keszletekar8.Text == "" || Keszletekeladasar4.Text == "" || Keszletekdatum8.Text == "")
            {
                MessageBox.Show(this, "Nincs minden mező kitöltve!", "HIÁNYOS ŰRLAP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into telefonok(tipus,imei3,beszerzesiar,eladasiar,beszerzesdatuma,statusz) values (@tipus,@imei3,@beszerzesiar,@eladasiar,@beszerzesdatuma,@statusz)";
                cmd.Parameters.AddWithValue("@tipus", Keszletektipus8.SelectedItem);
                cmd.Parameters.AddWithValue("@imei3", Keszletekimei4.Text);
                cmd.Parameters.AddWithValue("@beszerzesiar", Keszletekar8.Text);
                cmd.Parameters.AddWithValue("@eladasiar", Keszletekeladasar4.Text);
                cmd.Parameters.AddWithValue("@beszerzesdatuma", Keszletekdatum8.Text);
                cmd.Parameters.AddWithValue("@statusz", "készleten");
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                MessageBox.Show("Sikeres mentés");
                Keszletekimei4.Text = "";
                Keszletekar8.Text = "";
                Keszletekeladasar4.Text = "";
                Keszletekdatum8.Text = "";
                con.Close();
            }
        }

        private void Uj_Telefon_Load(object sender, EventArgs e)
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
                    Keszletektipus8.Items.Add(reader.GetValue(i).ToString());
                }
            }

            con.Close();
        }
    }
}
