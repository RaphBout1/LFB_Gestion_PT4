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
    public partial class Interface_Utilisateurs : Interface_Abstraite
    {
        public Interface_Utilisateurs()
        {
            nomModuleLabel.Text = "Module Utilisateurs";
            InitialisationUtilisateurs();
            InitializeComponent();
        }

        private void InitialisationUtilisateurs()
        {
            // Génération de 30 modèles d'utilisateurs pour tester (à supprimer)
            List<Entités.Entite_Utilisateur> utilisateurs = new List<Entités.Entite_Utilisateur>();
            for (int i = 0; i < 30; i++)
            {
                Entités.Entite_Utilisateur utilisateur = new Entités.Entite_Utilisateur();
                utilisateurs.Add(utilisateur);
            }

            // Pour tous les utilisateurs présents dans la liste, les afficher
            int y = 0;
            foreach (Entités.Entite_Utilisateur utilisateur in utilisateurs)
            {
                if (utilisateur == utilisateurs[0])
                {
                    utilisateur.Location = new System.Drawing.Point(0, 0);
                }
                else
                {
                    utilisateurs[y].Location = new Point(0, y * (utilisateur.Height + 10));
                }
                this.clientsPanel.Controls.Add(utilisateur);
                clientsPanel.AutoScroll = true;
                y++;
            }
        }
    }
}
