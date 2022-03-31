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
            afficherLabelBonjour();
            //dataBase.refreshDataBase();
            //afficherEntretienUtilisateurCourant(dataBase.entretiensCourants);
        }

        private void afficherLabelBonjour()
        {
            Label bonjourLabel = new Label();
            DateTime date = new DateTime();
            bonjourLabel.Text = "Bonjour " + Entite_Utilisateur.courant + "\n" + "Il est " + DateTime.Now.Hour.ToString() + "h" + DateTime.Now.Minute;
            bonjourLabel.Location = new Point(nomModuleLabel.Location.X + nomModuleLabel.Size.Width + 50, nomModuleLabel.Location.Y);
            bonjourLabel.Size = new Size(300, 300);
            bonjourLabel.ForeColor = Color.FromArgb(94, 139, 47);
            bonjourLabel.Font = nomModuleLabel.Font;
            this.Controls.Add(bonjourLabel);
        }

        private void afficherEntretienUtilisateurCourant(List<Entités.Entite_Entretien> entretiens)
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
        }
    }
}
