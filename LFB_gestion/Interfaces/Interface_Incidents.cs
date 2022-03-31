using LFB_gestion.Classes;
using LFB_gestion.Entités;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LFB_gestion.Interfaces
{
    public partial class Interface_Incidents : Interface_Abstraite

    {
        private SqlConnection connexion = Outils.Connexion();
        public Interface_Incidents()
        {
            ajoutBouton.Visible = false;
            // On redéfini le nom du module
            nomModuleLabel.Text = "Incidents";
            InitializeComponent();
            afficherIncidents();
        }

        #region Événements
        /// <summary>
        /// Méthode permettant de construire une liste d'incidents présents dans la base en fonction d'une chaine de caractères. Elle appelle ensuite le méthode d'affichage en passant cette liste en paramètres
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
        /// Affiche tout les incidents
        /// </summary>
        private void afficherIncidents()
        {
            reader("");
        }
        #endregion

        #region Fonctions
        /// <summary>
        /// Affiche tous les incidents
        /// </summary>
        private void affichageIncident(List<Entite_Incident> incidents)
        {

            clientsPanel.Controls.Clear();
            if (incidents != null)
            {
                // Pour tous les clients présents dans la liste, les afficher
                int y = 0;
                foreach (Entite_Incident incident in incidents)
                {
                    if (incident == incidents[0])
                    {
                        incident.Location = new Point(0, 0);
                    }
                    else
                    {
                        incidents[y].Location = new Point(0, y * (incident.Height + 10));
                    }
                    incident.Width = this.clientsPanel.Width -15;
                    this.clientsPanel.Controls.Add(incident);
                    clientsPanel.AutoScroll = true;
                    y++;
                }
            }
            else
            {
                MessageBox.Show("Pas de d'incident dans la base");
            }

        }

        /// <summary>
        /// Permet de créer une liste d'Entité_Incident selon un identifiant recherché et appelle la fonction qui les affiche
        /// </summary>
        /// <param name="recherche"></param>
        private void reader(string recherche)
        {
            List<Entite_Incident> listeIncidents = new List<Entite_Incident>();
            foreach (Entite_Incident incident in dataBase.incidents)
            {
                if (incident.description.Contains(recherche) || recherche == null || recherche == "")
                {
                    int id = incident.id;
                    string description = incident.description;
                    int id_réservation = incident.id_réservation;
                    Entite_Incident inci = new Entite_Incident(id, description, id_réservation);
                    listeIncidents.Add(inci);
                }
            }
            affichageIncident(listeIncidents);
        }



        #endregion

        private void refreshButton_Click(object sender, EventArgs e)
        {
            afficherIncidents();
        }
    }
}
