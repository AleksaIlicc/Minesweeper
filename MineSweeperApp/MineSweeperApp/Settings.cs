using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Podaci;

namespace MineSweeperApp
{
    public partial class Settings : Form
    {
        #region Atributes

        private int kolona,red,bomba;

        #endregion

        #region Constructors

        public Settings()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        public bool Validacija()
        {
            if (string.IsNullOrEmpty(TbBrojRedova.Text) || string.IsNullOrEmpty(TbBrojKolona.Text) || string.IsNullOrEmpty(TbBrojMina.Text)) {
                MessageBox.Show("Sva polja moraju biti popunjena.",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return false;
            }
            int.TryParse(TbBrojRedova.Text, out red);
            if (red < 9 || red > 20 )
            {
                MessageBox.Show("Minimalna vrednost polja za red je 9 a maksimalna 20.",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return false;
            }
            int.TryParse(TbBrojKolona.Text, out kolona);
            if (kolona < 9 || kolona > 20)
            {
                MessageBox.Show("Minimalna vrednost polja za kolonu je 9 a maksimalna 20.",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return false;
            }
            int.TryParse(TbBrojMina.Text, out bomba);
            int maxBomba = red * kolona;
            if (bomba < 1 || bomba > --maxBomba)
            {
                MessageBox.Show("Minimalna vrednost polja za bombu je 1 a maksimalna " + maxBomba + ".",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void PostaviPodatke(string red, string kolona, string bomba)
        {
            TbBrojRedova.Text = red ;
            TbBrojKolona.Text = kolona ;
            TbBrojMina.Text = bomba ;
        }

        #endregion

        #region EventHandlers

        private void BtnProsledi_Click(object sender, EventArgs e)
        {
            if (Validacija())
            {
                GameSettings.BrojRedova = red;
                GameSettings.BrojKolona = kolona;
                GameSettings.BrojBombi = bomba;
                this.Close();
                this.DialogResult= DialogResult.OK;
            }
        }

        private void BtnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }


        private void TbBrojRedova_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TbBrojKolona_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TbBrojMina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void BtnEasy_Click(object sender, EventArgs e)
        {
            PostaviPodatke("9", "9", "10");
        }

        private void BtnNormal_Click(object sender, EventArgs e)
        {
            PostaviPodatke("14", "14", "40");
        }

        private void BtnHard_Click(object sender, EventArgs e)
        {
            PostaviPodatke("20", "20", "99");
        }

        #endregion

    }
}
