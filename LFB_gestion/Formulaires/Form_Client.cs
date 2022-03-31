using LFB_gestion.Classes;
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
                if (Outils.mailEstValide(emailTextBox.Text))
                {
                    if (Outils.isValidCodePostal(textBoxCodePostal.Text))
                    {
                        if (Outils.isValidTel(textBoxTel.Text))
                        {
                            if (!ClientMéthodes.clientDejaPresent(prenomTextBox.Text, nomTextBox.Text))
                            {
                                ClientMéthodes.creationDuClient(nomTextBox.Text, prenomTextBox.Text, emailTextBox.Text, textBoxAdresse.Text, textBoxCodePostal.Text, textBoxVille.Text, textBoxTel.Text);
                                this.DialogResult = DialogResult.OK;
                            }
                            else
                            {
                                MessageBox.Show("Le client existe déjà");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Le numéro de téléphone n'est pas valide");
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
            if (!Outils.mailEstValide(emailTextBox.Text))
            {
                emailTextBox.ForeColor = Color.Red;
            }
            else
            {
                emailTextBox.ForeColor = Color.Black;
            }
        }
        #endregion
    }

   
}
