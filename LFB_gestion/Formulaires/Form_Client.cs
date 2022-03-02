using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public static bool EmailEstValide(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                string DomainMapper(Match match)
                {
                    var idn = new IdnMapping();
                    string domainName = idn.GetAscii(match.Groups[2].Value);
                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private void creerBouton_Click(object sender, EventArgs e)
        {
            if (EmailEstValide(emailTextBox.Text) && !clientDejaPresent() 
                && !String.IsNullOrEmpty(nomTextBox.Text) && !String.IsNullOrEmpty(prenomTextBox.Text))
            {
                creationDuClient();
                this.Controls.Clear();
                InitializeComponent();
                MessageBox.Show("ajout du nouveau client dans la base");
            } else
            {
                Label nonValideLabel = new Label();
                nonValideLabel.Size = this.Size; 
                nonValideLabel.Text = "Adresse mail non valide";
                nonValideLabel.Location = new Point(emailTextBox.Location.X, (emailTextBox.Location.Y - 15));
                this.Controls.Add(nonValideLabel);
                emailTextBox.Text = "";
                nomTextBox.Text = "";
                prenomTextBox.Text = "";
                this.Refresh();
            }
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
    }
}
