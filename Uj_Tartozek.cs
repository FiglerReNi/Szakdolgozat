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
    public partial class Uj_Tartozek : Form
    {
        static string MySQLConnectionString = "Datasource=localhost; port=3306; username=figlerr; password=Napsugar; database=szervizkeszletezorendszer ; SslMode=none";
        MySqlConnection con = new MySqlConnection(MySQLConnectionString);
        public Uj_Tartozek()
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

        private void Keszletekdatum5_Click(object sender, EventArgs e)
        {
            Keszletekdatum6.Text = System.DateTime.Today.ToShortDateString();
        }

        private void Uj_Tartozek_Load(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select fehertok, feketetok, pinktok, folia from telefontipusok";
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Keszletektipus6.Items.Add(reader.GetValue(i).ToString());
                }
            }

            con.Close();
        }

        private void Keszletekfelvitel3_Click(object sender, EventArgs e)
        {
            if (Keszletektipus6.SelectedItem == null || Keszletektartazonosito2.Text == "" || Keszletekar6.Text == "" || Keszletekeladasar2.Text == "" || Keszletekdatum6.Text == "")
            {
                MessageBox.Show(this, "Nincs minden mező kitöltve!", "HIÁNYOS ŰRLAP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into tartozekok(megnevezes,tartozekazonosito,beszerzesiar,eladasiar,beszerzesdatuma,statusz) values (@megnevezes,@tartozekazonosito,@beszerzesiar,@eladasiar,@beszerzesdatuma,@statusz)";
                cmd.Parameters.AddWithValue("@megnevezes", Keszletektipus6.SelectedItem);
                cmd.Parameters.AddWithValue("@tartozekazonosito", Keszletektartazonosito2.Text);
                cmd.Parameters.AddWithValue("@beszerzesiar", Keszletekar6.Text);
                cmd.Parameters.AddWithValue("@eladasiar", Keszletekeladasar2.Text);
                cmd.Parameters.AddWithValue("@beszerzesdatuma", Keszletekdatum6.Text);
                cmd.Parameters.AddWithValue("@statusz", "készleten");
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                MessageBox.Show("Sikeres mentés");
                Keszletektartazonosito2.Text = "";
                Keszletekar6.Text = "";
                Keszletekeladasar2.Text = "";
                Keszletekdatum6.Text = "";
                con.Close();
            }
        }
    }
}
