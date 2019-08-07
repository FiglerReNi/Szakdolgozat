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
    public partial class Uj_Fodarab : Form
    {
        static string MySQLConnectionString = "Datasource=localhost; port=3306; username=figlerr; password=Napsugar; database=szervizkeszletezorendszer ; SslMode=none";
        MySqlConnection con = new MySqlConnection(MySQLConnectionString);
        public Uj_Fodarab()
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

        private void Keszletekdatum3_Click(object sender, EventArgs e)
        {
            Keszletekdatum4.Text = System.DateTime.Today.ToShortDateString();
        }

        private void Uj_Fodarab_Load(object sender, EventArgs e)
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
                    Keszletektipus4.Items.Add(reader.GetValue(i).ToString());
                }
            }

            con.Close();
        }

        private void Keszletekfelvitel2_Click(object sender, EventArgs e)
        {
            if (Keszletektipus4.SelectedItem == null || Keszletekimei2.Text == "" || Keszletekar4.Text == "" || Keszletekdatum4.Text == "")
            {
                MessageBox.Show(this, "Nincs minden mező kitöltve!", "HIÁNYOS ŰRLAP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into fodarabok(tipus,imei2,beszerzesiar,beszerzesdatuma,statusz) values (@tipus,@imei2,@beszerzesiar,@beszerzesdatuma,@statusz)";
                cmd.Parameters.AddWithValue("@tipus", Keszletektipus4.SelectedItem);
                cmd.Parameters.AddWithValue("@imei2", Keszletekimei2.Text);
                cmd.Parameters.AddWithValue("@beszerzesiar", Keszletekar4.Text);
                cmd.Parameters.AddWithValue("@beszerzesdatuma", Keszletekdatum4.Text);
                cmd.Parameters.AddWithValue("@statusz", "készleten");
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                MessageBox.Show("Sikeres mentés");
                Keszletekimei2.Text = "";
                Keszletekar4.Text = "";
                Keszletekdatum4.Text = "";
                con.Close();
            }
        }
    }
}
