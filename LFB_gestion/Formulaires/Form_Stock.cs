using LFB_gestion.Classes;
using LFB_gestion.Entités;
using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LFB_gestion.Formulaires
{
    public partial class Form_Stock : Form
    {
        Entite_Stock produit;
        public Form_Stock(Entite_Stock produit)
        {
            this.produit = produit;
            InitializeComponent();
            if (produit != null)
            {
                validerBoutonProduit.Text = "Modifier";
                UrlTextBox.Text = produit.image;
                numericUpDown1.Value = produit.quantite;
                nomProduitTextBox.Text = produit.name;

            }

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
            if (nomProduitTextBox.Text != null)
            {

                if (imageBox.BackgroundImage != null)
                { 
                    AjouterStock(nomProduitTextBox.Text, UrlTextBox.Text, Int32.Parse(numericUpDown1.Value.ToString()));
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

            
        }

        #endregion

        #region Fonctions

        /// <summary>
        /// Ajouter un produit au stock
        /// </summary>
        private void AjouterStock(string name, string urlImage, int quantite)
        {
            SqlConnection connexion = Outils.Connexion();
            connexion.Open();

            if (produit == null)
            {

                string query = "insert into produit values ((select coalesce(MAX(id),0)+1 from produit), @nom, @image, @quantite)";
                SqlCommand command = new SqlCommand(query, connexion);
                command.Parameters.AddWithValue("@nom", name);
                command.Parameters.AddWithValue("@image", urlImage);
                command.Parameters.AddWithValue("@quantite", quantite);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("Produit rajouté");
                connexion.Close();
            }
            else
            {
                string requete = " UPDATE produit SET id = @id, nom = @name, image = @image, quantite = @quantite where id = @id";
                SqlCommand command = new SqlCommand(requete, connexion);
                command.Parameters.AddWithValue("@id", produit.id);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@image", urlImage);
                command.Parameters.AddWithValue("@quantite", quantite);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("Produit modifié");
                connexion.Close();

            }

            dataBase.refreshDataBase();
            this.Close();
        }

        #endregion



    }

}
