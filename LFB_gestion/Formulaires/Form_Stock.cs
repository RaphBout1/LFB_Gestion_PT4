using System;
using System.Drawing;
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

        #region Événements
        /// <summary>
        /// Autorise à taper des chiffres uniquement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (int)Keys.Back);
        }

        /// <summary>
        /// Affiche le petit formulaire interne pour créer un nouveau produit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nouveauProduitBouton_Click(object sender, EventArgs e)
        {
            panelNewProduit.Visible = !panelNewProduit.Visible;
            validerBouton.Visible = !validerBouton.Visible;
        }

        /// <summary>
        /// Valide la création d'un nouveau produit en stock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void validerBouton_Click(object sender, EventArgs e)
        {
            if (!auMoinsUnProduitSelectionne() || string.IsNullOrEmpty(nombreTextBox.Text))
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

        /// <summary>
        /// Permet de sélectionner et donner une image à un produit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imageBouton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                Image img = new Bitmap(openFileDialog1.FileName);
                Image img1 = (new Bitmap(img, new Size(90, 90)));
                imagePictureBox.Image = img1;
            }
        }

        /// <summary>
        /// Autorise à taper unisquement des lettres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nomProduitTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        /// <summary>
        /// Valide la création d'un nouveau produit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void validerBoutonProduit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nomProduitTextBox.Text))
            {
                Label nonValideLabel = new Label();
                nonValideLabel.Size = this.Size;
                nonValideLabel.Text = "Veuillez entrer un nom pour le produit";
                nonValideLabel.Location = new Point(validerBouton.Location.X, (validerBouton.Location.Y - 15));
                this.Controls.Add(nonValideLabel);
            }
            else
            {
                creationProduit();
                // this.stock.produitsListBox.Items.Add(nomProduitTextBox.Text);
                this.Controls.Clear();
                InitializeComponent();
                MessageBox.Show("Produit ajouté à la base avec succès !");
            }
        }
        #endregion

        #region Fonctions
        /// <summary>
        /// Vérifie si au moins un produit est sélectionné
        /// </summary>
        /// <returns>renvoie vrai si un produit est sélectionné</returns>
        private bool auMoinsUnProduitSelectionne()
        {
            return produitsListBox.SelectedItems.Count == 0;
        }
        #endregion

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

        /* MANIPULATION DE LA BASE */

        /*
         * Méthode permettant la création d'un produit dans la base
         * A FAIRE
         */
        private void creationProduit()
        {
        }
    }
}
