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
            if (!String.IsNullOrEmpty(prenomTextBox.Text) && !String.IsNullOrEmpty(nomTextBox.Text) && !String.IsNullOrEmpty(emailTextBox.Text))
            {
                if (Outils.isValidMail(emailTextBox.Text))
                {
                    if (!clientDejaPresent(prenomTextBox.Text, nomTextBox.Text))
                    {
                        creationDuClient(nomTextBox.Text, prenomTextBox.Text, emailTextBox.Text);
                    }
                    else
                    {
                        MessageBox.Show("Le client existe déjà");
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
        public static void creationDuClient(string nom, string prenom, string mail)
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
                query = "insert into client values (@id, @nom, @prenom, @mail)";
                command = new SqlCommand(query, connexion);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@nom", nom);
                command.Parameters.AddWithValue("@prenom", prenom);
                command.Parameters.AddWithValue("@mail", mail);
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
