using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LFB_gestion
{
    public partial class CréerEmployé : Form
    {
        private static string connexionString = "Data Source=info-joyeux;Initial Catalog=PT4_Camping_S4AE2;User Id=ETD;Password=ETD;";

        private SqlConnection connexion = new SqlConnection(connexionString);

        private int admin = 0;

        public CréerEmployé()
        {
            InitializeComponent();
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
            if (prénom_TextBox.Text != "" && nom_textBox.Text != "" && adresse_textBox.Text != "" && mdp_textBox.Text != "")
            {
                if (tel_textBox.Text.Length > 9)
                {
                    if (isValidMail(mail_textBox.Text))
                    {
                        try
                        {
                            connexion.Open();
                            string query = "INSERT INTO utilisateur VALUES (@login, null, @mail, @admin, @prenom, @nom, @tel, @mdp)";
                            SqlCommand command = new SqlCommand(query, connexion);
                            command.Parameters.AddWithValue("@login", prénom_TextBox.Text.ToLower()[0] + nom_textBox.Text.ToLower());
                            command.Parameters.AddWithValue("@mail", mail_textBox.Text);
                            command.Parameters.AddWithValue("@admin", admin);
                            command.Parameters.AddWithValue("@prenom", prénom_TextBox.Text);
                            command.Parameters.AddWithValue("@nom", nom_textBox.Text);
                            command.Parameters.AddWithValue("@tel", tel_textBox.Text);
                            command.Parameters.AddWithValue("@mdp", Outils.crypter(mdp_textBox.Text));
                            command.ExecuteNonQuery();
                            MessageBox.Show("Utilisateur crée avec succés");
                            connexion.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
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
            if (!isValidMail(mail_textBox.Text))
            {
                mail_textBox.ForeColor = Color.Red;
            }
            else
            {
                mail_textBox.ForeColor = Color.Black;
            }
        }
        #endregion

        /// <summary>
        /// Vérifie si une adresse mail contient un '.' après un '@'
        /// </summary>
        /// <param name="eMail"></param>
        /// <returns>renvoie vrai si l'adresse mail est valide</returns>
        bool isValidMail(string eMail)
        {
            bool Result = false;
            try
            {
                var eMailValidator = new System.Net.Mail.MailAddress(eMail);

                Result = (eMail.LastIndexOf(".") > eMail.LastIndexOf("@"));
            }
            catch
            {
                Result = false;
            };
            return Result;
        }
    }
}
