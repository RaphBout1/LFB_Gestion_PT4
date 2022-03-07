using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LFB_gestion.Formulaires
{
    public partial class Form_Client : Form
    {

        private static string connexionString = "Data Source=info-joyeux;Initial Catalog=PT4_Camping_S4AE2;User Id=ETD;Password=ETD;";

        private SqlConnection connexion = new SqlConnection(connexionString);

        private int admin = 0;

        public Form_Client()
        {
            InitializeComponent();
        }

        private void nomTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void prenomTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void emailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void creationDuClient(string nom, string prenom, string mail)
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
            } catch (Exception ex)
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

        /* MANIPULATION DE LA BASE */

        /*
         * Méthode permettant la création du client dans la base
         * A FAIRE
         */
        private void creationDuClient()
        {
            try
            {
                
                // Récupération de du dernier id
                SqlCommand idQuery = new SqlCommand("SELECT id FROM client");
                SqlDataReader sdr = idQuery.ExecuteReader();
                /*
                connexion.Open();
                string query = "INSERT INTO utilisateur VALUES (@id, @nom, @prenom, @email)";
                SqlCommand command = new SqlCommand(query, connexion);
                command.Parameters.AddWithValue("@id", prénom_TextBox.Text.ToLower()[0] + nom_textBox.Text.ToLower());
                command.Parameters.AddWithValue("@mail", mail_textBox.Text);
                command.Parameters.AddWithValue("@admin", admin);
                command.Parameters.AddWithValue("@prenom", prénom_TextBox.Text);
                command.Parameters.AddWithValue("@nom", nom_textBox.Text);
                command.Parameters.AddWithValue("@tel", tel_textBox.Text);
                command.Parameters.AddWithValue("@mdp", crypter(mdp_textBox.Text));
                command.ExecuteNonQuery();
                MessageBox.Show("Utilisateur crée avec succés"); */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /*
         * Méthode permettant de vérifier si un client est déjà présent dans la base.
         * A FAIRE
         */
        private bool clientDejaPresent()
        {
            return false;
        }

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
    }
}
