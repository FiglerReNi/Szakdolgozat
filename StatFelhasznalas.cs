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
    public partial class StatFelhasznalas : Form
    {
        static string MySQLConnectionString = "Datasource=localhost; port=3306; username=figlerr; password=Napsugar; database=szervizkeszletezorendszer ; SslMode=none";
        MySqlConnection con = new MySqlConnection(MySQLConnectionString);
       
        int fizetos1 = 0;
        int garancialis1 = 0;
        int fizetos2 = 0;
        int garancialis2 = 0;
        int osszdb1 = 0;
        int osszdb2 = 0;
        List<int> alkatreszfiz = new List<int>();
        List<int> alkatreszgar = new List<int>();
        List<int> fodarabfiz = new List<int>();
        List<int> fodarabgar = new List<int>();
        int osszegfiz1;
        int osszeggar1;
        int osszegfiz2;
        int osszeggar2;
        
        public StatFelhasznalas()
        {
            InitializeComponent();
        }

        private void Statalkatresz6_CheckedChanged(object sender, EventArgs e)
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

        private void Statszures1_Click(object sender, EventArgs e)
        {
            Statalkatresz4.Items.Clear();
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select azonosito from alkatreszek where felhasznalasdatuma between @datum1 and @datum2 and felhasznalas=@felhasznalas;"; 
            cmd.Parameters.AddWithValue("@datum1", Statalkatresz2.Text);
            cmd.Parameters.AddWithValue("@datum2", Statalkatresz3.Text);
            cmd.Parameters.AddWithValue("@felhasznalas", "Fizetős");
            MySqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandText = "select azonosito from alkatreszek where felhasznalasdatuma between @datum1 and @datum2 and felhasznalas=@felhasznalas;";
            cmd1.Parameters.AddWithValue("@datum1", Statalkatresz2.Text);
            cmd1.Parameters.AddWithValue("@datum2", Statalkatresz3.Text);
            cmd1.Parameters.AddWithValue("@felhasznalas", "Garanciális");
            MySqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select beszerzesiar from alkatreszek where felhasznalasdatuma between @datum1 and @datum2 and felhasznalas=@felhasznalas;";
            cmd2.Parameters.AddWithValue("@datum1", Statalkatresz2.Text);
            cmd2.Parameters.AddWithValue("@datum2", Statalkatresz3.Text);
            cmd2.Parameters.AddWithValue("@felhasznalas", "Fizetős");
            MySqlCommand cmd3 = con.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "select beszerzesiar from alkatreszek where felhasznalasdatuma between @datum1 and @datum2 and felhasznalas=@felhasznalas;";
            cmd3.Parameters.AddWithValue("@datum1", Statalkatresz2.Text);
            cmd3.Parameters.AddWithValue("@datum2", Statalkatresz3.Text);
            cmd3.Parameters.AddWithValue("@felhasznalas", "Garanciális");
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Statalkatresz4.Items.Add(reader.GetValue(i).ToString());
                    fizetos1++;
                }
            }
            reader.Close();
            reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Statalkatresz4.Items.Add(reader.GetValue(i).ToString());
                    garancialis1++;
                }
            }
            reader.Close();
            reader = cmd2.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    alkatreszfiz.Add(int.Parse(reader.GetValue(i).ToString()));
                }
            }
            reader.Close();
            reader = cmd3.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    alkatreszgar.Add(int.Parse(reader.GetValue(i).ToString()));
                }
            }
            reader.Close();
            Statalkatresz2.ResetText();
            Statalkatresz3.ResetText();
            con.Close();

            osszegfiz1 = 0;
            osszeggar1 = 0;
            for (int i = 0; i < alkatreszfiz.Count; i++)
            {
                osszegfiz1 = osszegfiz1 + alkatreszfiz[i];
            }
            for (int i = 0; i < alkatreszgar.Count; i++)
            {
                osszeggar1 = osszeggar1 + alkatreszgar[i];
            }
        }

        private void Statszures2_Click(object sender, EventArgs e)
        {
            
            Statfodarab4.Items.Clear();
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select imei2 from fodarabok where felhasznalasdatuma between @datum3 and @datum4 and felhasznalas=@felhasznalas";
            cmd.Parameters.AddWithValue("@datum3", Statfodarab2.Text);
            cmd.Parameters.AddWithValue("@datum4", Statfodarab3.Text);
            cmd.Parameters.AddWithValue("@felhasznalas", "Fizetős");
            MySqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select imei2 from fodarabok where felhasznalasdatuma between @datum3 and @datum4 and felhasznalas=@felhasznalas";
            cmd1.Parameters.AddWithValue("@datum3", Statfodarab2.Text);
            cmd1.Parameters.AddWithValue("@datum4", Statfodarab3.Text);
            cmd1.Parameters.AddWithValue("@felhasznalas", "Garanciális");
            MySqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select beszerzesiar from fodarabok where felhasznalasdatuma between @datum3 and @datum4 and felhasznalas=@felhasznalas";
            cmd2.Parameters.AddWithValue("@datum3", Statfodarab2.Text);
            cmd2.Parameters.AddWithValue("@datum4", Statfodarab3.Text);
            cmd2.Parameters.AddWithValue("@felhasznalas", "Fizetős");
            MySqlCommand cmd3 = con.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "select beszerzesiar from fodarabok where felhasznalasdatuma between @datum3 and @datum4 and felhasznalas=@felhasznalas";
            cmd3.Parameters.AddWithValue("@datum3", Statfodarab2.Text);
            cmd3.Parameters.AddWithValue("@datum4", Statfodarab3.Text);
            cmd3.Parameters.AddWithValue("@felhasznalas", "Garanciális");
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Statfodarab4.Items.Add(reader.GetValue(i).ToString());
                    fizetos2++;
                }
            }
            reader.Close();
            reader = cmd1.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Statfodarab4.Items.Add(reader.GetValue(i).ToString());
                    garancialis2++;
                }
            }
            reader.Close();
            reader = cmd2.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    fodarabfiz.Add(int.Parse(reader.GetValue(i).ToString()));
                }
            }
            reader.Close();
            reader = cmd3.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    fodarabgar.Add(int.Parse(reader.GetValue(i).ToString()));
                }
            }
            reader.Close();
            Statfodarab2.ResetText();
            Statfodarab3.ResetText();
            con.Close();

            osszegfiz2 = 0;
            osszeggar2 = 0;
            for (int i = 0; i < fodarabfiz.Count; i++)
            {
                osszegfiz2 = osszegfiz2 + fodarabfiz[i];
            }
            for (int i = 0; i < fodarabgar.Count; i++)
            {
                osszeggar2 = osszeggar2 + fodarabgar[i];
            }
        }

        private void Statlekerdezesdb1_Click(object sender, EventArgs e)
        {
                Megjelenites.Text = "";
                osszdb1 = fizetos1 + garancialis1;
                if (Statalkatresz5.Checked)
                {
                    Megjelenites.Text = "Összes felhasznált alkatrész darabszáma: " + osszdb1 + Environment.NewLine +
                        "Fizetős javításra felhasznált alkatrész darabszáma: " + fizetos1 + Environment.NewLine;
                }
                if (Statalkatresz6.Checked)
                {
                    Megjelenites.Text = "Összes felhasznált alkatrész darabszáma: " + osszdb1 + Environment.NewLine +
                        "Garanciális javításra felhasznált alkatrész darabszáma: " + garancialis1;
                }
        }

        private void Statlekerdezesdb2_Click(object sender, EventArgs e)
        {

            Megjelenites.Text = "";
            osszdb2 = fizetos2 + garancialis2;
            if (Statfodarab5.Checked)
            {
                Megjelenites.Text = "Összes felhasznált fődarab darabszáma: " + osszdb2 + Environment.NewLine +
                    "Fizetős javításra felhasznált fődarab darabszáma: " + fizetos2 + Environment.NewLine;
            }
            if (Statfodarab6.Checked)
            {
                Megjelenites.Text = "Összes felhasznált fődarab darabszáma: " + osszdb2 + Environment.NewLine +
                    "Garanciális javításra felhasznált fődarab darabszáma: " + garancialis2;
            }
        }

        private void Statlekerdezesft1_Click(object sender, EventArgs e)
        {
                Megjelenites.Text = "";
                if (Statalkatresz5.Checked)
                {
                    Megjelenites.Text = "Összes felhasznált alkatrész értéke: " + (osszegfiz1 + osszeggar1) + "Ft" + Environment.NewLine +
                        "Fizetős javításra felhasznált alkatrész értéke: " + osszegfiz1 + "Ft" + Environment.NewLine;
                }
                if (Statalkatresz6.Checked)
                {
                    Megjelenites.Text = "Összes felhasznált alkatrész értéke: " + (osszegfiz1 + osszeggar1) + "Ft" + Environment.NewLine +
                        "Garanciális javításra felhasznált alkatrész értéke: " + osszeggar1 + "Ft";
                }
        }

        private void Statlekerdezesft2_Click(object sender, EventArgs e)
        {
            
            Megjelenites.Text = "";
            if (Statfodarab5.Checked)
            {
                Megjelenites.Text = "Összes felhasznált fődarab értéke: " + (osszegfiz2  +osszeggar2) + "Ft" + Environment.NewLine +
                    "Fizetős javításra felhasznált fődarab értéke: " + osszegfiz2 + "Ft" + Environment.NewLine;
            }
            if (Statfodarab6.Checked)
            {
                Megjelenites.Text = "Összes felhasznált fődarab értéke: " + (osszegfiz2 + osszeggar2) + "Ft" + Environment.NewLine +
                    "Garanciális javításra felhasznált fődarab értéke: " + osszeggar2 + "Ft";
            }
        }

        private void Stathaszon1_Click(object sender, EventArgs e)
        {          
                double haszonfiz1 = (osszegfiz1 * 0.1);
                double haszongar1 = (osszeggar1 * 0.05);
                Megjelenites.Text = "";
                if (Statalkatresz5.Checked)
                {
                    Megjelenites.Text = "Összes felhasznált alkatrész haszon: " + (haszonfiz1 + haszongar1) + "Ft" + Environment.NewLine +
                        "Fizetős javításra felhasznált alkatrész haszon: " + haszonfiz1 + "Ft" + Environment.NewLine;
                }
                if (Statalkatresz6.Checked)
                {
                    Megjelenites.Text = "Összes felhasznált alkatrész haszon: " + (haszonfiz1 + haszongar1) + "Ft" + Environment.NewLine +
                        "Garanciális javításra felhasznált alkatrész haszon: " + haszongar1 + "Ft";
                }
        }

        private void Stathaszon2_Click(object sender, EventArgs e)
        {
            double haszonfiz2 = (osszegfiz2 * 0.1);
            double haszongar2 = (osszeggar2 * 0.05);
            if (Statfodarab5.Checked)
            {
                Megjelenites.Text = "Összes felhasznált fődarab haszon: " + (haszonfiz2 + haszongar2) + "Ft" + Environment.NewLine +
                    "Fizetős javításra felhasznált fődarab haszon: " + haszonfiz2 + "Ft" + Environment.NewLine;
            }
            if (Statfodarab6.Checked)
            {
                Megjelenites.Text = "Összes felhasznált fődarab haszon: " + (haszonfiz2 + haszongar2) + "Ft" + Environment.NewLine +
                    "Garanciális javításra felhasznált fődarab haszon: " + haszongar2 + "Ft";
            }
        }
    }
}
