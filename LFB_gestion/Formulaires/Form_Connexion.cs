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
    public partial class Connexion : Form
    {

        SqlConnection connexion;



        public Connexion()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Bouton se connecter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void seConnecter_button_Click(object sender, EventArgs e)
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
                            command.Parameters.AddWithValue("@login", reader.GetValue(0).ToString());
                            
                            try
                            {
                                DbDataReader reader2 = command.ExecuteReader();
                                // Si c'est le mot de passe est valide
                                if (reader2.HasRows)
                                {
                                     reader2.Read();
                                    if (reader2.GetValue(0).ToString() == Outils.crypter(motDePasse_textBox.Text)) // si le mot de passe crypté est égal au mot de passe inséré puis crypté
                                    {


                                        Classes.Utilisateur u = Classes.Utilisateur.CreationUtilisateur(reader.GetValue(0).ToString());
                                        MessageBox.Show(u.login + " " + u.mail + " " + u.mdp);
                                        
                                        this.Hide();
                                        Form formAcceuil = new Interfaces.Interface_Accueil();

                                        formAcceuil.ShowDialog();
                                        this.Close();

                                        reader.Close();
                                        reader2.Close();
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
                        MessageBox.Show("Utilisateur introuvable");
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
