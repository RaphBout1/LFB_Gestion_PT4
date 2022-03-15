using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LFB_gestion.Interfaces
{
    public partial class Interface_Entretien : Interface_Abstraite
    {
        public Interface_Entretien()
        {
            InitialisationEntretien();
            nomModuleLabel.Text = "Entretients";
            InitializeComponent();
        }

        #region Événements
        /// <summary>
        /// Ouvre un formulaire pour créer un nouveau incident
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ajoutBouton_Click(object sender, EventArgs e)
        {
            Form formEntretien = new Formulaires.Form_Entretien();
            formEntretien.ShowDialog();
        }
        #endregion

        #region Fonctions
        /// <summary>
        /// Affiche tous les incidents et les clients
        /// </summary>
        private void InitialisationEntretien()
        {
            // Génération de 30 modèles de clients pour tester (à supprimer)
            List<Entités.Entite_Entretien> incidents = new List<Entités.Entite_Entretien>();
            for (int i = 0; i < 30; i++)
            {
                Entités.Entite_Entretien incident = new Entités.Entite_Entretien();
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
