using LFB_gestion.Entités;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LFB_gestion.Formulaires
{
    public partial class Form_Employe : Form
    {

        private SqlConnection connexion = Outils.Connexion();

        private int admin = 0;

        Entite_Utilisateur user;

        public Form_Employe(Entite_Utilisateur utilisateur )
        {
            this.user = utilisateur;
            InitializeComponent();

            if (utilisateur != null)
            {
                prénom_TextBox.Text = utilisateur.prenom;
                nom_textBox.Text = utilisateur.nom;
                tel_textBox.Text = utilisateur.tel;
                mail_textBox.Text = utilisateur.mail;
                mdp_textBox.Text = utilisateur.mdp;
                admin_checkBox.Checked = Convert.ToBoolean(utilisateur.admin);
                
            }
        }

        #region Événements
        /// <summary>
        /// Bouton pour créer un utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void créer_button_Click(object sender, EventArgs e)
        {
            // Si tous les champs sont remplis
            if (prénom_TextBox.Text != "" && nom_textBox.Text != "" && mdp_textBox.Text != "")
            {
                if (tel_textBox.Text.Length < 9)
                {
                    if (Outils.mailEstValide(mail_textBox.Text))
                    {
                       if(user != null)
                        {
                            modificationUser(prénom_TextBox.Text.ToLower()[0] + nom_textBox.Text.ToLower(), mail_textBox.Text, admin, prénom_TextBox.Text, nom_textBox.Text, tel_textBox.Text, Outils.chiffrer(mdp_textBox.Text), user);
                        }
                        else
                        {
                            creerUser(prénom_TextBox.Text.ToLower()[0] + nom_textBox.Text.ToLower(), mail_textBox.Text, admin, prénom_TextBox.Text, nom_textBox.Text, tel_textBox.Text, Outils.chiffrer(mdp_textBox.Text));
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email invalide.");
                    }
                }
                else
                {
                    MessageBox.Show("Numéro de téléphone invalide.");
                }
            }
            else
            {
                MessageBox.Show("Remplissez tous les champs s'il vous plaît.");
            }
        }

        /// <summary>
        ///  met l'attribut admin à 1 si on veut que l'utilisateur ait les droits d'administrateur et 0 sinon lorsque la case est cochée ou pas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void admin_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (admin_checkBox.Checked)
                admin = 1;
            else
                admin = 0;
        }

        /// <summary>
        /// modifie le label login dynamiquement lorsqu'on modifie le prénom
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void prénom_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (prénom_TextBox.Text != "")
            {
                nom_textBox_TextChanged(sender, e);
            }
        }

        /// <summary>
        /// modifie le label login dynamiquement lorsqu'on modifie le nom
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nom_textBox_TextChanged(object sender, EventArgs e)
        {

            if (nom_textBox.Text != "")
            {
                loginValue_label.Text = prénom_TextBox.Text.ToLower()[0] + nom_textBox.Text.ToLower();
            }
        }

        /// <summary>
        /// tant que le mail inséré n'est pas valide il sera de couleur rouge
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mail_textBox_TextChanged(object sender, EventArgs e)
        {
            if (!Outils.mailEstValide(mail_textBox.Text))
            {
                mail_textBox.ForeColor = Color.Red;
            }
            else
            {
                mail_textBox.ForeColor = Color.Black;
            }
        }

        private void creerUser(string login, string mail , int admin, string prenom, string nom,string tel, string mdp  )
        {
            try
            {
                connexion.Open();
                string query = "INSERT INTO utilisateur VALUES (@login, @mail, @admin, @prenom, @nom, @tel, @mdp)";
                SqlCommand command = new SqlCommand(query, connexion);
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@mail", mail);
                command.Parameters.AddWithValue("@admin", admin);
                command.Parameters.AddWithValue("@prenom", prenom);
                command.Parameters.AddWithValue("@nom",nom);
                command.Parameters.AddWithValue("@tel", tel);
                command.Parameters.AddWithValue("@mdp", mdp);
                command.ExecuteNonQuery();
                MessageBox.Show("Utilisateur crée avec succés");
                connexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void modificationUser(string login, string mail, int admin, string prenom, string nom, string tel, string mdp, Entite_Utilisateur userModif)
        {
            string requete = " UPDATE utilisateur SET login = @login, mail = @mail, admin = @admin, prenom = @prenom, nom = @nom, telephone = @tel, mdp = @mdp WHERE login = @condition";
            SqlCommand command = new SqlCommand(requete, connexion);
            command.Parameters.AddWithValue("@login", login);
            command.Parameters.AddWithValue("@mail", mail);
            command.Parameters.AddWithValue("@admin", admin);
            command.Parameters.AddWithValue("@prenom", prenom);
            command.Parameters.AddWithValue("@nom", nom);
            command.Parameters.AddWithValue("@tel", tel);
            command.Parameters.AddWithValue("@mdp", mdp);
            command.Parameters.AddWithValue("@condition", userModif.login);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Entretien modifié");
        }

        #endregion
    }
}
