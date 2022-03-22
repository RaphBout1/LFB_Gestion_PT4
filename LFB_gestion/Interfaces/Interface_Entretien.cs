using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LFB_gestion.Interfaces
{
    public partial class Interface_Entretien : Interface_Abstraite
    {

        private SqlConnection connexion = Outils.Connexion();
        public Interface_Entretien()
        {
            InitialisationEntretien();
            nomModuleLabel.Text = "Entretients";
            InitializeComponent();
            Refresh();
        }

        #region Événements
        /// <summary>
        /// Ouvre un formulaire pour créer un nouveau incident
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ajoutBouton_Click(object sender, EventArgs e)
        {
            Form formEntretien = new Formulaires.Form_Entretien(null);
            formEntretien.ShowDialog();
        }
        #endregion

        #region Fonctions

        /// <summary>
        /// Méthode affichant la liste de entretient qu'elle reçoit en paramètres.
        /// </summary>
        /// <param name="entretiens"></param>
        private void affichageClients(List<Entités.Entite_Entretien> entretiens)
        {
            clientsPanel.Controls.Clear();

            // Pour tous les clients présents dans la liste, les afficher
            if (entretiens != null)
            {
                int y = 0;
                foreach (Entités.Entite_Entretien entretien in entretiens)
                {
                    if (entretien == entretiens[0])
                    {
                        entretien.Location = new System.Drawing.Point(0, 0);
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
            connexion.Close();
        }

        /// <summary>
        /// Affiche tous les incidents et les clients
        /// </summary>
        private void InitialisationEntretien()
        {
            // Génération de 30 modèles de clients pour tester (à supprimer)
            List<Entités.Entite_Entretien> incidents = new List<Entités.Entite_Entretien>();
            for (int i = 0; i < 30; i++)
            {
                Entités.Entite_Entretien incident = new Entités.Entite_Entretien(2, new DateTime(1985, 6, 20),"coucouuuuuu","emplacement 4",new Entités.Entite_Utilisateur("coucou", "coucou", "coucou",1, "coucou", "coucou", "coucou")) ;
                incidents.Add(incident);
            }

            // Pour tous les clients présents dans la liste, les afficher
            int y = 0;
            foreach (Entités.Entite_Entretien incident in incidents)
            {
                if (incident == incidents[0])
                {
                    incident.Location = new System.Drawing.Point(0, 0);
                }
                else
                {
                    incidents[y].Location = new Point(0, y * (incident.Height + 10));
                }
                incident.Width = this.clientsPanel.Width;
                this.clientsPanel.Controls.Add(incident);
                clientsPanel.AutoScroll = true;
                y++;
            }
        }
        #endregion




    }
}
