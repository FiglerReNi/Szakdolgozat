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
    public partial class Fooldal : Form
    {
        int i;
        static string MySQLConnectionString = "Datasource=localhost; port=3306; username=figlerr; password=Napsugar; database= belepes; SslMode=none";
        MySqlConnection con = new MySqlConnection(MySQLConnectionString);

       
        
        
        public Fooldal()
        {          
            InitializeComponent();
            Fooldaludvozlo4.PasswordChar ='*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Fooldaludvozlo.Text = "Üdvözöljük az alkalmazásban. " + Environment.NewLine + System.DateTime.Today.ToShortDateString();
            
        }

        //private void label2_Click(object sender, EventArgs e)
        //{
        //
       // }

       

        private void Urlapokalkatreszfelvitel_Click(object sender, EventArgs e)
        {
            Alkatresz_felvitel alkatresz_felvitel = new Alkatresz_felvitel();
            alkatresz_felvitel.ShowDialog();
        }
        private void Urlapokuj_Click(object sender, EventArgs e)
        {
            Uj uj = new Uj();
            uj.ShowDialog();
        }
        private void ujalkatresz_Click(object sender, EventArgs e)
        {
            Uj_Alkatresz uj_Alkatresz = new Uj_Alkatresz();
            uj_Alkatresz.ShowDialog();
        }

        private void ujfodarab_Click(object sender, EventArgs e)
        {
            Uj_Fodarab uj_Fodarab = new Uj_Fodarab();
            uj_Fodarab.ShowDialog();
        }

        private void ujtartozek_Click(object sender, EventArgs e)
        {
            Uj_Tartozek uj_Tartozek = new Uj_Tartozek();
            uj_Tartozek.ShowDialog();
        }

        private void ujtelefon_Click(object sender, EventArgs e)
        {
            Uj_Telefon uj_Telefon = new Uj_Telefon();
            uj_Telefon.ShowDialog();
        }

        private void Fooldaleladas_Click(object sender, EventArgs e)
        {
            Eladas eladas = new Eladas();
            eladas.ShowDialog();
           
        }

        private void Statisztikakfelhasznalas_Click(object sender, EventArgs e)
        {
            StatFelhasznalas statFelhasznalas = new StatFelhasznalas();
            statFelhasznalas.ShowDialog();
        }

        private void Statisztikakeladas_Click(object sender, EventArgs e)
        {
            StatEladas statEladas = new StatEladas();
            statEladas.ShowDialog();
        }

        private void Keresesurlapok_Click(object sender, EventArgs e)
        {
            Kereses_urlapok kereses_urlapok = new Kereses_urlapok();
            kereses_urlapok.ShowDialog();
        }

        private void Keresesalkatresz_Click(object sender, EventArgs e)
        {
            Kereses_alkatresz kereses_alkatresz = new Kereses_alkatresz();
            kereses_alkatresz.ShowDialog();
        }

        private void Keresesfodarab_Click(object sender, EventArgs e)
        {
            Kereses_fodarab kereses_fodarab = new Kereses_fodarab();
            kereses_fodarab.ShowDialog();
        }

        private void Keresestartozek_Click(object sender, EventArgs e)
        {
            Kereses_tartozek kereses_tartozek = new Kereses_tartozek();
            kereses_tartozek.ShowDialog();
        }

        private void Keresestelefon_Click(object sender, EventArgs e)
        {
            Kereses_telefon kereses_telefon = new Kereses_telefon();
            kereses_telefon.ShowDialog();
        }

        private void Fooldalkilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Fooldalfelhasznalonev1_Click(object sender, EventArgs e)
        {

        }

        private void Keszletekselejtezes_Click(object sender, EventArgs e)
        {
            Selejtezes selejtezes = new Selejtezes();
            selejtezes.ShowDialog();
        }

       private void Fooldaludvozlo_TextChanged(object sender, EventArgs e)
        {


      }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void Fooldaludvozlo1_Click(object sender, EventArgs e)
        {
            
            con.Open();
            i = 0;
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from felhasznalok where felhasznalonev =@nev and jelszo=@jelszo";
            cmd.Parameters.AddWithValue("@nev", Fooldaludvozlo3.Text);
            cmd.Parameters.AddWithValue("@jelszo", Encrypt(Fooldaludvozlo4.Text));
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
            {
                MessageBox.Show("Nem helyes felhasználónév vagy jelszó.");

            }
            else
            {
                this.Hide();
                Fooldal fo = new Fooldal();
                fo.Hide();
                Fooldal___Bejelentkezve fooldal = new Fooldal___Bejelentkezve();
                fooldal.ShowDialog();

            }
            con.Close();
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

        private void Fooldaludvozlo9_Click(object sender, EventArgs e)
        {
            Uj_jelszo elfelejtett_jelszo = new Uj_jelszo();
            elfelejtett_jelszo.ShowDialog();
        }
        //public string Decrypt(string Etext)
        //{
        //    string EncryptionKey = "abc123";
        //    //Etext = Etext.Replace(" ", "+");
        //    byte[] data = Convert.FromBase64String(Etext);
        //    using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
        //    {
        //        byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(EncryptionKey));
        //        using (TripleDESCryptoServiceProvider trip = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
        //        {
        //            ICryptoTransform transform = trip.CreateDecryptor();
        //            byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
        //            Etext = UTF8Encoding.UTF8.GetString(results);
        //        }
        //    }
        //    return Etext;
    }
    }
    

