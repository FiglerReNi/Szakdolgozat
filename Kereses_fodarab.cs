﻿using System;
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
    public partial class Kereses_fodarab : Form
    {
        static string MySQLConnectionString = "Datasource=localhost; port=3306; username=figlerr; password=Napsugar; database=szervizkeszletezorendszer ; SslMode=none";
        MySqlConnection con = new MySqlConnection(MySQLConnectionString);
        public Kereses_fodarab()
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

        private void Kereses_fodarab_Load(object sender, EventArgs e)
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
                    Keresesteltipus5.Items.Add(reader.GetValue(i).ToString());
                }
            }

            con.Close();
        }

        private void Keresesteltipus5_SelectedValueChanged(object sender, EventArgs e)
        {
            int db = 0;
            Kereseseredmenydb2.Text = "";
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select  tipus, imei2, beszerzesiar from fodarabok where tipus=@tipus and statusz=@statusz";
            cmd.Parameters.AddWithValue("@tipus", Keresesteltipus5.SelectedItem);
            cmd.Parameters.AddWithValue("@statusz", "készleten");
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            Kereseseredmenylista4.DataSource = dt;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    db++;
                }
            }
            reader.Close();
            Kereseseredmenydb2.Text = db/3 + "";
            con.Close();
        }
    }
}
