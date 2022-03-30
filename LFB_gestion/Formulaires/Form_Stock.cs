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
        /// Permet de sélectionner et donner une image à un produit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imageBouton_Click(object sender, EventArgs e)
        {
            if (UrlTextBox.Text != null)
            {
                Outils.afficherImage(UrlTextBox.Text, imageBox);
            }
            else
            {
                MessageBox.Show("Veuillez entrer un url");
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
            if(nomProduitTextBox.Text != null)
            {

                if(imageBox.BackgroundImage != null)
                {

                }
                else
                {
                    MessageBox.Show("L'image n'est pas ajouté");
                }

            }
            else
            {
                MessageBox.Show("Le nom du produit n'est pas rentré");
            };

                //creationProduit();
                // this.stock.produitsListBox.Items.Add(nomProduitTextBox.Text);
                this.Controls.Clear();
                InitializeComponent();
                MessageBox.Show("Produit ajouté à la base avec succès !");
            }
        }
        #endregion

        #region Fonctions
       
        #endregion




    
}
