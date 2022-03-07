using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LFB_gestion.Interfaces
{
    public partial class Interface_Utilisateurs : Interface_Abstraite
    {

        public List<Classes.Utilisateur> users = new List<Classes.Utilisateur>();

        private SqlConnection connexion = Outils.Connexion();
        public Interface_Utilisateurs()
        {
            nomModuleLabel.Text = "Module Utilisateurs";
            selectUsers();
            afficherUsers();
            InitializeComponent();
        }

        /// <summary>
        /// Charge tous les utilisateurs depuis la base de données dans la liste users
        /// </summary>
        private void selectUsers()
        {
            connexion.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM utilisateur", connexion);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string login = reader.GetString(0);
                string mdp = reader.GetString(7);
                string mail = reader.GetString(2);
                int admin = reader.GetInt32(3);
                string nom = reader.GetString(5);
                string prenom = reader.GetString(4);
                string tel = reader.GetString(6);

                users.Add( new Classes.Utilisateur(login, mdp, mail, admin, nom, prenom, tel));
            }
            reader.Close();
            connexion.Close();
        }

        /// <summary>
        /// Appelle la fonction qui affichera tous les utilisateurs
        /// </summary>
        private void afficherUsers()
        {
            reader(null);
        }
        
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
        /// Permet de créer une liste d'Entités_Utilisateur selon un identifiant recherché et appelle la fonction qui les affiche
        /// </summary>
        /// <param name="idQuery"></param>
        private void reader(string recherche)
        {
            List<Entités.Entite_Utilisateur> listeUtilisateur = new List<Entités.Entite_Utilisateur>();
            foreach (Classes.Utilisateur user in users)
            {
                if (user.login == recherche || recherche == null || recherche == "")
                {
                    string nom = user.nom;
                    string prenom = user.prenom;
                    string login = user.login;
                    string mdp = user.mdp;
                    string mail = user.mail;
                    string tel = user.tel;
                    Entités.Entite_Utilisateur utilisateur = new Entités.Entite_Utilisateur(login, mdp, mail, nom, prenom, tel);
                    listeUtilisateur.Add(utilisateur);
                }
            }
            affichageUtilisateur(listeUtilisateur);
        }

        /// <summary>
        /// affiche les entités utilisateur dans l'interface
        /// </summary>
        /// <param name="utilisateurs"></param>
        private void affichageUtilisateur(List<Entités.Entite_Utilisateur> utilisateurs)
        {
            clientsPanel.Controls.Clear();

            // Pour tous les utilisateur présents dans la liste, les afficher
            if (utilisateurs != null)
            {
                int y = 0;
                foreach (Entités.Entite_Utilisateur utilisateur in utilisateurs)
                {
                    if (utilisateur == utilisateurs[0])
                    {
                        utilisateur.Location = new System.Drawing.Point(0, 0);

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
                MessageBox.Show("Pas de clients dans la base");
            }
            connexion.Close();
        }

    }
}
