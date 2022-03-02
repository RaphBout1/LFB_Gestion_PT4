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
        //Connexion à la base
        private SqlConnection connexion = Outils.Connexion();
        public Interface_Utilisateurs()
        {

            nomModuleLabel.Text = "Module Utilisateurs";
            InitialisationToutUtilisateurs();
            InitializeComponent();
        }


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
                    this.clientsPanel.Controls.Add(utilisateur);
                    clientsPanel.AutoScroll = true;
                    y++;
                }
            }
            else
            {
                MessageBox.Show("Pas de client dans la base");
            }
            connexion.Close();
        }

        private void InitialisationToutUtilisateurs()
        {
            // Remplir la liste this.clients
            // Connexion bdd
            connexion.Open();
            SqlCommand idQuery = new SqlCommand("SELECT * from utilisateur", connexion);
            SqlDataReader rd;
            rd = idQuery.ExecuteReader();
            List<Entités.Entite_Utilisateur> listeUtilisateur = new List<Entités.Entite_Utilisateur>();
            while (rd.Read())
            {
                String nom = rd["nom"].ToString();
                String prenom = rd["prenom"].ToString();
                String login = rd["login"].ToString();
                String mdp = rd["mdp"].ToString();
                String email = rd["mail"].ToString();
                String tel = rd["telephone"].ToString();
                Entités.Entite_Utilisateur utilisateur = new Entités.Entite_Utilisateur(login,mdp,email,nom,prenom,tel);
                listeUtilisateur.Add(utilisateur);
            }
            connexion.Close();
            affichageUtilisateur(listeUtilisateur);
        }
    }
}
