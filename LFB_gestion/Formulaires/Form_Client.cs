using LFB_gestion.Classes;
using LFB_gestion.Entités;
using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LFB_gestion.Formulaires
{
    public partial class Form_Client : Form
    {

        private static string connexionString = "Data Source=info-joyeux;Initial Catalog=PT4_Camping_S4AE2;User Id=ETD;Password=ETD;";

        private static SqlConnection connexion = new SqlConnection(connexionString);

        Entite_Client client;


        public Form_Client(Entite_Client client)
        {
            this.client = client;
            InitializeComponent();
            if (client != null)
            {
                nomTextBox.Text = client.nom;
                prenomTextBox.Text = client.prenom;
                emailTextBox.Text = client.mail;
                textBoxAdresse.Text = client.adresse;
                textBoxCodePostal.Text = client.codePostal.ToString();
                textBoxVille.Text = client.ville;
                textBoxTel.Text = client.tel.ToString();
                creerBouton.Text = "Modifier";
            }
        }

        #region Événements
        /// <summary>
        /// Autorise à mettre que des caractères dans la textBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nomTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        /// <summary>
        /// Autorise à mettre que des caractères dans la textBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void prenomTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void creerBouton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(prenomTextBox.Text) && !String.IsNullOrEmpty(nomTextBox.Text) && !String.IsNullOrEmpty(emailTextBox.Text) && !String.IsNullOrEmpty(textBoxAdresse.Text)
                && !String.IsNullOrEmpty(textBoxCodePostal.Text) && !String.IsNullOrEmpty(textBoxVille.Text) && !String.IsNullOrEmpty(textBoxTel.Text))
            {
                if (Outils.mailEstValide(emailTextBox.Text))
                {
                    if (Outils.isValidCodePostal(textBoxCodePostal.Text))
                    {


                        if (client != null)
                        {
                            modifierClient(nomTextBox.Text, prenomTextBox.Text, emailTextBox.Text, textBoxAdresse.Text, textBoxCodePostal.Text, textBoxVille.Text, textBoxTel.Text, client);
                        }
                        else
                        {
                            creationDuClient(nomTextBox.Text, prenomTextBox.Text, emailTextBox.Text, textBoxAdresse.Text, textBoxCodePostal.Text, textBoxVille.Text, textBoxTel.Text);
                        }



                    }
                    else
                    {
                        MessageBox.Show("Le code Postal est incorrect");
                    }
                }
                else
                {
                    MessageBox.Show("Email non valide.");
                }
            }
            else
            {
                MessageBox.Show("Remplissez tous les champs.");
            }
            dataBase.selectClients();
        }

        /// <summary>
        /// Affiche le teste écrit en rouge si le mail n'est pas valide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Outils.mailEstValide(emailTextBox.Text))
            {
                emailTextBox.ForeColor = Color.Red;
            }
            else
            {
                emailTextBox.ForeColor = Color.Green;
            }
        }


        /// <summary>
        /// Creer le client 
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="mail"></param>
        /// <param name="adresse"></param>
        /// <param name="codePostal"></param>
        /// <param name="ville"></param>
        /// <param name="tel"></param>
        public void creationDuClient(string nom, string prenom, string mail, string adresse, string codePostal, string ville, string tel)
        {
            connexion.Open();
            try
            {
                string query = "insert into client values ((select coalesce(MAX(id),0)+1 from client), @nom, @prenom, @mail, @adresse, @codePostal, @ville, @tel)";
                SqlCommand command = new SqlCommand(query, connexion);
                command.Parameters.AddWithValue("@nom", nom);
                command.Parameters.AddWithValue("@prenom", prenom);
                command.Parameters.AddWithValue("@mail", mail);
                command.Parameters.AddWithValue("@adresse", adresse);
                command.Parameters.AddWithValue("@codePostal", codePostal);
                command.Parameters.AddWithValue("@ville", ville);
                command.Parameters.AddWithValue("@tel", tel);
                command.ExecuteNonQuery();
                MessageBox.Show("Client bien ajouté");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connexion.Close();
            this.Close();
        }

        /// <summary>
        /// Modifier le client
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="mail"></param>
        /// <param name="adresse"></param>
        /// <param name="codePostal"></param>
        /// <param name="ville"></param>
        /// <param name="tel"></param>
        /// <param name="client"></param>
        public void modifierClient(string nom, string prenom, string mail, string adresse, string codePostal, string ville, string tel, Entite_Client client)
        {
            connexion.Open();
            string requete = " UPDATE client SET id = @id, nom = @nom, prenom = @prenom, mail = @mail, adresse = @adresse , codePostal = @codePostal, ville = @ville , telephone = @tel WHERE id = @id";
            SqlCommand command = new SqlCommand(requete, connexion);
            command.Parameters.AddWithValue("@id", client.id);
            command.Parameters.AddWithValue("@nom", nom);
            command.Parameters.AddWithValue("@prenom", prenom);
            command.Parameters.AddWithValue("@mail", mail);
            command.Parameters.AddWithValue("@adresse", adresse);
            command.Parameters.AddWithValue("@codePostal", codePostal);
            command.Parameters.AddWithValue("@ville", ville);
            command.Parameters.AddWithValue("@tel", tel);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Client modifié");
            connexion.Close();
            this.Close();

        }

        #endregion
    }


}
