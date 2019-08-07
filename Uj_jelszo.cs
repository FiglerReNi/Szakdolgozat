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
using System.Security.Cryptography;

namespace Szakdolgozat1
{
    public partial class Uj_jelszo : Form
    {
        static string MySQLConnectionString = "Datasource=localhost; port=3306; username=figlerr; password=Napsugar; database= belepes; SslMode=none";
        MySqlConnection con = new MySqlConnection(MySQLConnectionString);
        int i;
        public Uj_jelszo()
        {
            InitializeComponent();
            ujjelsz2.PasswordChar = '*';
        }

        
        public string Encrypt(string Text)
        {
            string EncryptionKey = "abc123";
            byte[] data = UTF8Encoding.UTF8.GetBytes(Text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(EncryptionKey));
                using (TripleDESCryptoServiceProvider trip = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = trip.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    Text = Convert.ToBase64String(results, 0, results.Length);
                }
            }
            return Text;
        }

        private void ujjelsz3_Click(object sender, EventArgs e)
        {   
            con.Open();
            i = 0;
            MySqlCommand cmd0 = con.CreateCommand();
            cmd0.CommandType = CommandType.Text;
            cmd0.CommandText = "select * from felhasznalok where felhasznalonev =@nev and jelszo=@jelszo";
            cmd0.Parameters.AddWithValue("@nev", ujfelh2.Text);
            cmd0.Parameters.AddWithValue("@jelszo", Encrypt(ujregi2.Text));
            cmd0.ExecuteNonQuery();
            DataTable dt0 = new DataTable();
            MySqlDataAdapter da0 = new MySqlDataAdapter(cmd0);
            da0.Fill(dt0);
            i = Convert.ToInt32(dt0.Rows.Count.ToString());
            if (i == 0)
            {
                MessageBox.Show("Nem helyes felhasználónév vagy jelszó.");

            }
            else
            {
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update felhasznalok set jelszo=@jelszo where felhasznalonev=@nev";
                cmd.Parameters.AddWithValue("@nev", ujfelh2.Text);
                cmd.Parameters.AddWithValue("@jelszo", Encrypt(ujjelsz2.Text));
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                MessageBox.Show("Módosította a jelszót. Lépjen be az új jelszavával.");
                this.Hide();
            }
                con.Close();
        }
    }
}

           

            




//     con.Open();
//            MySqlCommand cmd = con.CreateCommand();
//cmd.CommandType = CommandType.Text;
//            cmd.CommandText = "update felhasznalok set jelszo=@jelszo where felhasznalonev=@nev";
//            cmd.Parameters.AddWithValue("@nev", ujfelh2.Text);
//            cmd.Parameters.AddWithValue("@jelszo", Encrypt(ujjelsz2.Text));
//            cmd.ExecuteNonQuery();
//            DataTable dt = new DataTable();
//MySqlDataAdapter da = new MySqlDataAdapter(cmd);
//da.Fill(dt);
//            MessageBox.Show("Módosította a jelszót. Lépjen be az új jelszavával.");
//            this.Hide();
//con.Close();