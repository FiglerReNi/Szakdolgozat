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
    public partial class Uj : Form
    {
        static string MySQLConnectionString = "Datasource=localhost; port=3306; username=figlerr; password=Napsugar; database=szervizkeszletezorendszer ; SslMode=none";
        MySqlConnection con = new MySqlConnection(MySQLConnectionString);
        public Uj()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Uj_Load(object sender, EventArgs e)
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
                    Ujtipus2.Items.Add(reader.GetValue(i).ToString());
                }
            }

            con.Close();



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Gar_CheckedChanged(object sender, EventArgs e)
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

        private void Ujdatum1_Click(object sender, EventArgs e)
        {
            Ujdatum2.Text = System.DateTime.Today.ToShortDateString();
        }

        private void Ment_Click(object sender, EventArgs e)
        {
            if (Ujtipus2.SelectedItem == null || Ujjavitas2.SelectedItem == null || Ujdatum2.Text == "" || Ujnev2.Text == "" || Ujcim2.Text == "" || Ujemail2.Text == "" || Ujimei2.Text == "" || Ujhiba2.Text == "")
            {
                MessageBox.Show(this, "Nincs minden mező kitöltve!", "HIÁNYOS ŰRLAP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into adatlapok(nev,cim,telefonszam,email,tipus,imei1,hiba,garancialisfizetos,datum) values (@nev,@cim,@telefonszam,@email,@tipus,@imei1,@hiba,@garfiz,@datum)";
                cmd.Parameters.AddWithValue("@nev", Ujnev2.Text);
                cmd.Parameters.AddWithValue("@cim", Ujcim2.Text);
                cmd.Parameters.AddWithValue("@telefonszam", Ujtel2.Text);
                cmd.Parameters.AddWithValue("@email", Ujemail2.Text);
                cmd.Parameters.AddWithValue("@tipus", Ujtipus2.SelectedItem);
                cmd.Parameters.AddWithValue("@imei1", Ujimei2.Text);
                cmd.Parameters.AddWithValue("@hiba", Ujhiba2.Text);
                cmd.Parameters.AddWithValue("@datum", Ujdatum2.Text);
                cmd.Parameters.AddWithValue("@garfiz", Ujjavitas2.SelectedItem);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                MessageBox.Show("Sikeres mentés");
                Ujnev2.Clear();
                Ujcim2.Clear();
                Ujtel2.Clear();
                Ujemail2.Clear();
                Ujimei2.Clear();
                Ujhiba2.Clear();
                Ujdatum2.Clear();
                con.Close();
            }
        }

        private void Ujtel2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ((MaskedTextBox)sender).ForeColor = Color.Red;
            MessageBox.Show(this, "Hibás karakter!", "HIBÁS ADATBEVITEL", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Ujtel2_KeyDown(object sender, KeyEventArgs e)
        {
            ((MaskedTextBox)sender).ForeColor = Color.FromKnownColor(KnownColor.WindowText);
        }

        private void Ujimei2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ((MaskedTextBox)sender).ForeColor = Color.Red;
            MessageBox.Show(this, "Hibás karakter!", "HIBÁS ADATBEVITEL", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Ujimei2_KeyDown(object sender, KeyEventArgs e)
        {
            ((MaskedTextBox)sender).ForeColor = Color.FromKnownColor(KnownColor.WindowText);
        }

    }
}

