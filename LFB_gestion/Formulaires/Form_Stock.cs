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
            remplirProduits();
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
            Form_Produit nouveauProduit = new Form_Produit(this);
            nouveauProduit.Show();
        }

        private bool auMoinsUnProduitSelectionne()
        {
            if (produitsListBox.SelectedItems.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void validerBouton_Click(object sender, EventArgs e)
        {
            if (!auMoinsUnProduitSelectionne() || String.IsNullOrEmpty(nombreTextBox.Text))
            {
                Label nonValideLabel = new Label();
                nonValideLabel.Size = this.Size;
                nonValideLabel.Text = "Les champs du formulaires ont mal été remplis";
                nonValideLabel.Location = new Point(validerBouton.Location.X, (validerBouton.Location.Y - 15));
                this.Controls.Add(nonValideLabel);
            }
            else
            {
                creationStock();
                this.Controls.Clear();
                InitializeComponent();
                remplirProduits();
                MessageBox.Show("Stock ajouté à la base avec succès !");
            }
        }


        /* MANIPULATION DE LA BASE */

        /*
         * Méthode permettant la création d'un emplacement dans la base
         * A FAIRE
         */
        private void creationStock()
        {
        }
        public void remplirProduits()
        {
            for (int i = 0; i < 30; i++)
            {
                produitsListBox.Items.Add("produit " + i);
            }
        }
    }
}
