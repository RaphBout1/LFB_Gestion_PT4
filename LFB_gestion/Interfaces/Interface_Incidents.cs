using LFB_gestion.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LFB_gestion.Interfaces
{
    public partial class Interface_Incidents : Interface_Abstraite
    {
        public Interface_Incidents()
        {
            InitialisationIncidents();
            nomModuleLabel.Text = "Module Incidents";
            InitializeComponent();
        }

        private void InitialisationIncidents()
        {
            // Génération de 30 modèles de clients pour tester (à supprimer)
            List<Entités.Entite_Incident> incidents = new List<Entités.Entite_Incident>();
            for (int i = 0; i < 30; i++)
            {
                Entités.Entite_Incident incident = new Entités.Entite_Incident();
                incidents.Add(incident);
            }

            // Pour tous les clients présents dans la liste, les afficher
            int y = 0;
            foreach (Entités.Entite_Incident incident in incidents)
            {
                if (incident == incidents[0])
                {
                    incident.Location = new System.Drawing.Point(0, 0);
                }
                else
                {
                    incidents[y].Location = new Point(0, y * (incident.Height + 10));
                }
                this.clientsPanel.Controls.Add(incident);
                clientsPanel.AutoScroll = true;
                y++;
            }
        }

        private void ajoutBouton_Click(object sender, EventArgs e)
        {
            Form formIncident = new Formulaires.Form_Incident();

            formIncident.ShowDialog();
        }
    }
}
