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


        public Form_Client()
        {
            InitializeComponent();
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
                if (Outils.isValidMail(emailTextBox.Text))
                {
                    if (Outils.isValidCodePostal(textBoxCodePostal.Text))
                    {
                        if (Outils.isValidTel(textBoxTel.Text))
                        {
                            if (!clientDejaPresent(prenomTextBox.Text, nomTextBox.Text))
                            {
                                creationDuClient(nomTextBox.Text, prenomTextBox.Text, emailTextBox.Text, textBoxAdresse.Text, textBoxCodePostal.Text, textBoxVille.Text, textBoxTel.Text);
                            }
                            else
                            {
                                MessageBox.Show("Le client existe déjà");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Le numéros de téléphone est inconnu");

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
        }

        /// <summary>
        /// Affiche le teste écrit en rouge si le mail n'est pas valide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Outils.isValidMail(emailTextBox.Text))
            {
                emailTextBox.ForeColor = Color.Red;
            }
            else
            {
                emailTextBox.ForeColor = Color.Black;
            }
        }
        #endregion

        #region Fonctions
        /// <summary>
        /// Création d'un nouveau client
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="mail"></param>
        private void creationDuClient(string nom, string prenom, string mail, string adresse, string codePostal, string ville, string tel)
        {
            connexion.Open();
            int id = 0;
            string query = "select max (id) from client";
            SqlCommand command = new SqlCommand(query, connexion);
            DbDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                id = reader.GetInt32(0);
                id++;
                reader.Close();
            }
            try
            {
                query = "insert into client values (@id, @nom, @prenom, @mail, @adresse,@codePostal,@ville,@tel)";
                command = new SqlCommand(query, connexion);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@nom", nom);
                command.Parameters.AddWithValue("@prenom", prenom);
                command.Parameters.AddWithValue("@mail", mail);
                command.Parameters.AddWithValue("@mail", adresse);
                command.Parameters.AddWithValue("@mail", codePostal);
                command.Parameters.AddWithValue("@mail", ville);
                command.Parameters.AddWithValue("@mail", tel);
                command.ExecuteNonQuery();
                MessageBox.Show("Client bien ajouté");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connexion.Close();
        }

        /// <summary>
        /// Vérifie si le client qu'on veut créer n'existe pas déjà dans la base de données par le nom et le prénom
        /// </summary>
        /// <param name="prenom"></param>
        /// <param name="nom"></param>
        /// <returns></returns>
        private bool clientDejaPresent(string prenom, string nom)
        {
            bool present = false;
            connexion.Open();
            string query = "select prenom, nom from client where prenom = @prenom and nom = @nom";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@prenom", prenom);
            command.Parameters.AddWithValue("@nom", nom);
            DbDataReader reader = null;
            try
            {
                reader = command.ExecuteReader();
                if (reader.HasRows)
                    present = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connexion.Close();
            return present;
        }
        public void TestCreationClient(string nom, string prenom, string mail)
        {
            creationDuClient(nom, prenom, mail);
        }
        #endregion
    }

   
}
