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
    public partial class StatEladas : Form
    {
        static string MySQLConnectionString = "Datasource=localhost; port=3306; username=figlerr; password=Napsugar; database=szervizkeszletezorendszer ; SslMode=none";
        MySqlConnection con = new MySqlConnection(MySQLConnectionString);

        int tartozek;
        int telefon;
        List<int> tartozekbeszerar = new List<int>();
        List<int> tartozekeladar = new List<int>();
        List<int> telefonbeszerar = new List<int>();
        List<int> telefoneladar = new List<int>();
        int osszegbe1;
        int osszegel1;
        int osszegbe2;
        int osszegel2;
        public StatEladas()
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

        private void Statszures3_Click(object sender, EventArgs e)
        {   
            Stattartozek4.Items.Clear();
            tartozek = 0;
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select tartozekazonosito from tartozekok where eladasdatuma between @datum1 and @datum2;";
            cmd.Parameters.AddWithValue("@datum1", Stattartozek2.Text);
            cmd.Parameters.AddWithValue("@datum2", Stattartozek3.Text);
            MySqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select beszerzesiar from tartozekok where eladasdatuma between @datum1 and @datum2;";
            cmd1.Parameters.AddWithValue("@datum1", Stattartozek2.Text);
            cmd1.Parameters.AddWithValue("@datum2", Stattartozek3.Text);
            MySqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select eladasiar from tartozekok where eladasdatuma between @datum1 and @datum2;";
            cmd2.Parameters.AddWithValue("@datum1", Stattartozek2.Text);
            cmd2.Parameters.AddWithValue("@datum2", Stattartozek3.Text);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Stattartozek4.Items.Add(reader.GetValue(i).ToString());
                    tartozek++;
                }
            }
            reader.Close();
            reader = cmd1.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    tartozekbeszerar.Add(int.Parse(reader.GetValue(i).ToString()));
                }
            }
            reader.Close();
            reader = cmd2.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    tartozekeladar.Add(int.Parse(reader.GetValue(i).ToString()));
                }
            }
            reader.Close();
            Stattartozek2.ResetText();
            Stattartozek3.ResetText();
            con.Close();
            osszegbe1 = 0;
            osszegel1 = 0;
            for (int i = 0; i < tartozekbeszerar.Count; i++)
            {
                osszegbe1 = osszegbe1 + tartozekbeszerar[i];
            }
            for (int i = 0; i < tartozekeladar.Count; i++)
            {
                osszegel1 = osszegel1 + tartozekeladar[i];
            }
        }

        private void Statszures4_Click(object sender, EventArgs e)
        {
            Stattelefon4.Items.Clear();
            telefon = 0;
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select imei3 from telefonok where eladasdatuma between @datum1 and @datum2;";
            cmd.Parameters.AddWithValue("@datum1", Stattelefon2.Text);
            cmd.Parameters.AddWithValue("@datum2", Stattelefon3.Text);
            MySqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select beszerzesiar from telefonok where eladasdatuma between @datum1 and @datum2;";
            cmd1.Parameters.AddWithValue("@datum1", Stattelefon2.Text);
            cmd1.Parameters.AddWithValue("@datum2", Stattelefon3.Text);
            MySqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select eladasiar from telefonok where eladasdatuma between @datum1 and @datum2;";
            cmd2.Parameters.AddWithValue("@datum1", Stattelefon2.Text);
            cmd2.Parameters.AddWithValue("@datum2", Stattelefon3.Text);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Stattelefon4.Items.Add(reader.GetValue(i).ToString());
                    telefon++;
                }
            }
            reader.Close();
            reader = cmd1.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    telefonbeszerar.Add(int.Parse(reader.GetValue(i).ToString()));
                }
            }
            reader.Close();
            reader = cmd2.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    telefoneladar.Add(int.Parse(reader.GetValue(i).ToString()));
                }
            }
            reader.Close();
            Stattelefon3.ResetText();
            Stattelefon3.ResetText();
            con.Close();
            osszegbe2 = 0;
            osszegel2 = 0;
            for (int i = 0; i < telefonbeszerar.Count; i++)
            {
                osszegbe2 = osszegbe2 + telefonbeszerar[i];
            }
            for (int i = 0; i < telefoneladar.Count; i++)
            {
                osszegel2 = osszegel2 + telefoneladar[i];
            }
        }

        private void Statlekerdezesdb3_Click(object sender, EventArgs e)
        {
            Megjelenites1.Text = "";
            Megjelenites1.Text = "Összes eladott tartozék darabszáma: " + tartozek;

        }

        private void Statlekerdezesdb4_Click(object sender, EventArgs e)
        {
            Megjelenites1.Text = "";
            Megjelenites1.Text = "Összes eladott telefon darabszáma: " + telefon;
        }

        private void Statlekerdezesft3_Click(object sender, EventArgs e)
        {
            Megjelenites1.Text = "";
            Megjelenites1.Text = "Összes eladott tartozék beszerzési áron: " + osszegbe1 + "Ft" + Environment.NewLine +
                    "Összes eladott tartozék eladási áron: " + osszegel1 + "Ft";
        }

        private void Statlekerdezesft4_Click(object sender, EventArgs e)
        {
            Megjelenites1.Text = "";
            Megjelenites1.Text = "Összes eladott telefon beszerzési áron: " + osszegbe2 + "Ft" + Environment.NewLine +
                    "Összes eladott telefon eladási áron: " + osszegel2 + "Ft";
        }

        private void Stathaszon3_Click(object sender, EventArgs e)
        {
            Megjelenites1.Text = "";
            Megjelenites1.Text = "Összes eladott tartozék haszon: " + (osszegel1 - osszegbe1) + "Ft";
                    
        }

        private void Stathaszon4_Click(object sender, EventArgs e)
        {
            Megjelenites1.Text = "";
            Megjelenites1.Text = "Összes eladott telefon haszon: " + (osszegel2 - osszegbe2) + "Ft";
        }
    }
    }

