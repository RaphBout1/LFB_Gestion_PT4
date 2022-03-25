using LFB_gestion.Entités;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LFB_gestion.Interfaces
{
    public partial class Interface_Utilisateurs : Interface_Abstraite
    {
        private SqlConnection connexion = Outils.Connexion();
        public Interface_Utilisateurs()
        {
            // On redéfini le nom du module
            nomModuleLabel.Text = "Utilisateurs";
            //On affiche les utilisateurs présents dans la base
            InitializeComponent();
            afficherUsers();
        }

        #region Événements
        /// <summary>
        /// Méthode permettant de construire une liste d'utilisateurs présents dans la base en fonction d'une chaine de caractères. Elle appelle ensuite le méthode d'affichage en passant cette liste en paramètres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rechercheBouton_Click(object sender, EventArgs e)
        {
            connexion.Open();
            reader(rechercheTextBox.Text);
            connexion.Close();
        }

        /// <summary>
        /// Ouvre un formulaire pour créer un nouvel utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ajoutBouton_Click_1(object sender, EventArgs e)
        {
            Form formUtilisateur = new Formulaires.Form_Employe();

            formUtilisateur.ShowDialog();
        }
        /// <summary>
        /// Appelle la fonction qui affichera tous les utilisateurs
        /// </summary>
        private void afficherUsers()
        {
            reader("");
        }
        #endregion

        #region Fonctions


        /// <summary>
        /// Permet de créer une liste d'Entités_Utilisateur selon un identifiant recherché et appelle la fonction qui les affiche
        /// </summary>
        /// <param name="recherche"></param>
        private void reader(string recherche)
        {
            List<Entite_Utilisateur> listeUtilisateur = new List<Entite_Utilisateur>();
            foreach (Entite_Utilisateur user in Interface_Accueil.users)
            {
                if (user.login.Contains(recherche)|| recherche == null || recherche == "")
                {
                    string nom = user.nom;
                    string prenom = user.prenom;
                    string login = user.login;
                    string mdp = user.mdp;
                    string mail = user.mail;
                    int admin = user.admin;
                    string tel = user.tel;
                    Entite_Utilisateur utilisateur = new Entite_Utilisateur(login, mdp, mail, admin, nom, prenom, tel);
                    listeUtilisateur.Add(utilisateur);
                }
            }
            affichageUtilisateur(listeUtilisateur);
        }

        /// <summary>
        /// affiche les entités utilisateur dans l'interface
        /// </summary>
        /// <param name="utilisateurs"></param>
        private void affichageUtilisateur(List<Entite_Utilisateur> utilisateurs)
        {
            clientsPanel.Controls.Clear();

            // Pour tous les utilisateur présents dans la liste, les afficher
            if (utilisateurs != null)
            {
                int y = 0;
                foreach (Entite_Utilisateur utilisateur in utilisateurs)
                {
                    if (utilisateur == utilisateurs[0])
                    {
                        utilisateur.Location = new Point(0, 0);

                    }
                    else
                    {
                        utilisateurs[y].Location = new Point(0, y * (utilisateur.Height + 30));
                    }

                    utilisateur.Width = this.clientsPanel.Width;
                    this.clientsPanel.Controls.Add(utilisateur);
                    clientsPanel.AutoScroll = true;
                    y++;
                }
            }
            else
            {
                MessageBox.Show("Pas d'utilisateur dans la base");
            }
        }
        #endregion
    }
}
