using LFB_gestion.Entités;
using LFB_gestion.Interfaces;
using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LFB_gestion
{
    public partial class Connexion : Form
    {
        SqlConnection connexion;
        bool motDePassVisible = false;
        bool clickLogin = false;
        bool clickMdp = false;

        public Connexion()
        {
            InitializeComponent();
        }

        #region Événements
        /// <summary>
        /// Bouton se connecter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void seConnecter_button_Click(object sender, EventArgs e)
        {
            seConnecter();
        }

        /// <summary>
        /// Au premier clique le texte de base disparait
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nomUtilisateur_textBox_Click(object sender, EventArgs e)
        {
            if(clickLogin == false)
            {
                nomUtilisateur_textBox.Text = string.Empty;
                nomUtilisateur_textBox.ForeColor = SystemColors.InfoText;
                clickLogin = true;
            }
        }

        /// <summary>
        /// Au premier clique le texte de base disparait
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void motDePasse_textBox_Click(object sender, EventArgs e)
        {
            motDePasse_textBox.Text = string.Empty;
            motDePasse_textBox.ForeColor = SystemColors.InfoText;
            clickLogin = true;
        }

        /// <summary>
        /// Connecter quand la touche entre est appuyé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Connexion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                seConnecter();
            }
        }


        /// <summary>
        /// Voir le mot de passe caché
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void visionMDP_Click(object sender, EventArgs e)
        {
            motDePasse_textBox.UseSystemPasswordChar = !motDePasse_textBox.UseSystemPasswordChar;
            if (motDePassVisible == true)
            {
                motDePassVisible = false;
                visionMDP.BackgroundImage = Properties.Resources.oeilFermer;
            }
            else
            {
                motDePassVisible = true;
                visionMDP.BackgroundImage = Properties.Resources.oeilOuvert;
            }
        }

        #endregion

        #region Fonctions
        private void seConnecter()
        {
            connexion = Outils.Connexion();
            //Se connecter à la base de données
            try
            {
                connexion.Open();
                if (nomUtilisateur_textBox.Text != "" && motDePasse_textBox.Text != "")
                {
                    // Chercher le login dans la base de données
                    string query = "SELECT login FROM utilisateur WHERE login = @login";
                    SqlCommand command = new SqlCommand(query, connexion);
                    command.Parameters.AddWithValue("@login", nomUtilisateur_textBox.Text);
                    try
                    {
                        DbDataReader reader = command.ExecuteReader();
                        if (reader.HasRows) // L'utilisateur existe
                        {
                            reader.Read();
                            // Vérifier la correspondance du mot de passe
                            query = "SELECT mdp FROM utilisateur WHERE login = @login";
                            command = new SqlCommand(query, connexion);
                            string login = (string)reader["login"];
                            command.Parameters.AddWithValue("@login", login);
                            reader.Close();
                            try
                            {
                                reader = command.ExecuteReader();
                                // Si c'est le mot de passe est valide
                                if (reader.HasRows)
                                {
                                    reader.Read();
                                    if ((string)reader["mdp"] == Outils.chiffrer(motDePasse_textBox.Text)) // si le mot de passe crypté est égal au mot de passe inséré puis crypté
                                    {


                                        Entite_Utilisateur user = Entite_Utilisateur.setUtilisateurCourant(login);
                                        Entite_Utilisateur.courant = user;


                                        this.Hide();
                                        Interface_Accueil formAcceuil = new Interface_Accueil();
                                        formAcceuil.FormClosed += (s, args) => this.Close();
                                        formAcceuil.ShowDialog();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Mot de passe incorrect");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Aucun mot de passe dans la base données pour l'utilisateur " + reader.GetValue(0).ToString());
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Utilisateur inconnu");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Utilisateur introuvable" + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez remplir tous les champs");
                }
                connexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion




    }
}
