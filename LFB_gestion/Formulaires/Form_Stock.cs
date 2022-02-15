using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LFB_gestion.Formulaires
{
    public partial class Form_Stock : Form
    {
        public Form_Stock()
        {
            InitializeComponent();
        }

        private void nomTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void nombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (int)Keys.Back);
        }

        private void nouveauProduitBouton_Click(object sender, EventArgs e)
        {
            Form_Produit nouveauProduit = new Form_Produit();
            nouveauProduit.Show();
        }
    }
}
