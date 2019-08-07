using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szakdolgozat1
{
    public partial class Fooldal___Bejelentkezve : Form
    {
        public Fooldal___Bejelentkezve()
        {
            InitializeComponent();
        }

        private void Fooldal___Bejelentkezve_Load(object sender, EventArgs e)
        {
            Fooldaludvozlo.Text = "Üdvözöljük az alkalmazásban. " + Environment.NewLine + System.DateTime.Today.ToShortDateString();
        }
        private void Urlapokuj_Click(object sender, EventArgs e)
        {
            Uj uj = new Uj();
            uj.ShowDialog();
        }

        private void Urlapokalkatreszfelvitel_Click(object sender, EventArgs e)
        {
            Alkatresz_felvitel alkatresz_felvitel = new Alkatresz_felvitel();
            alkatresz_felvitel.ShowDialog();
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

        private void Fooldalkilepes_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
