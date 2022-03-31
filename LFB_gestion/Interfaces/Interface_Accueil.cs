using LFB_gestion.Classes;
using LFB_gestion.Entités;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LFB_gestion.Interfaces
{
    public partial class Interface_Accueil : Interface_Abstraite
    {

        public Interface_Accueil()
        {
            InitializeComponent();
            ajoutBouton.Hide();
            afficherLabelBonjour();
            dataBase.refreshDataBase();
            afficherEntretienCourant();
        }

        /// <summary>
        /// Appelle la fonction qui affichera tous les utilisateurs
        /// </summary>
        public void afficherEntretienCourant()
        {
            reader("");
        }

        /// <summary>
        /// Permet de créer une liste d'Entités_Entretien selon un identifiant recherché et appelle la fonction qui les affiche
        /// </summary>
        /// <param name="recherche"></param>
        public void reader(string recherche)
        {
            List<Entite_Entretien> listeEntretien = new List<Entite_Entretien>();
            foreach (Entite_Entretien entretien in dataBase.entretiens)
            {
                if (entretien.description.Contains(recherche) || recherche == null || recherche == "")
                {
                    int id = entretien.id;
                    string date = entretien.date;
                    string description = entretien.description;
                    string user = entretien.user;
                    int emplacement = entretien.emplacement;
                    Entite_Entretien entre = new Entite_Entretien(id, date, description, emplacement, user);
                    listeEntretien.Add(entre);
                }
            }
            affichageEntretien(listeEntretien);
        }

        /// <summary>
        /// Méthode affichant la liste de entretient qu'elle reçoit en paramètres.
        /// </summary>
        /// <param name="entretiens"></param>
        private void affichageEntretien(List<Entités.Entite_Entretien> entretiens)
        {
            // Affichage petite phrase avant les entités
            Label entretienLabel = new Label();
            entretienLabel.Text = "Voici vos taches pour la journée :";
            entretienLabel.Location = new Point(0,0);
            entretienLabel.Size = new Size(300, 300);
            entretienLabel.ForeColor = Color.FromArgb(94, 139, 47);
            entretienLabel.Font = nomModuleLabel.Font;


            clientsPanel.Controls.Clear();
            clientsPanel.Controls.Add(entretienLabel);

            // Pour tous les clients présents dans la liste, les afficher
            if (entretiens != null)
            {
                int y = 0;
                foreach (Entités.Entite_Entretien entretien in entretiens)
                {
                    if (entretien == entretiens[0])
                    {
                        entretien.Location = new Point(0, entretienLabel.Location.Y + entretien.Size.Height + 10);
                    }
                    else
                    {
                        entretiens[y].Location = new Point(0, y * (entretien.Height + 30));
                    }
                    entretien.Width = clientsPanel.Width;
                    clientsPanel.Controls.Add(entretien);
                    clientsPanel.AutoScroll = true;
                    y++;
                }
            }
            else
            {
                MessageBox.Show("Pas d'entretien dans la base");
            }
        }



        private void afficherLabelBonjour()
        {
            Label bonjourLabel = new Label();
            DateTime date = new DateTime();
            bonjourLabel.Text = "Bonjour " + Entite_Utilisateur.courant.prenom + "\n" + "Il est " + DateTime.Now.Hour.ToString() + "h" + DateTime.Now.Minute;
            bonjourLabel.Location = new Point(nomModuleLabel.Location.X + nomModuleLabel.Size.Width + 50, nomModuleLabel.Location.Y);
            bonjourLabel.Size = new Size(600, 300);
            bonjourLabel.BackColor = Color.Transparent;
            bonjourLabel.ForeColor = Color.FromArgb(94, 139, 47);
            bonjourLabel.Font = nomModuleLabel.Font;
            this.Controls.Add(bonjourLabel);
        }
    }
}
