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
    public partial class Interface_Reservations : Interface_Abstraite
    {
        public Interface_Reservations()
        {
            nomModuleLabel.Text = "Module Réservations";
            InitialisationReservations();
            InitializeComponent();
        }

        private void InitialisationReservations()
        {
            // Génération de 30 modèles de clients pour tester (à supprimer)
            List<Entités.Entite_Reservation> reservations = new List<Entités.Entite_Reservation>();
            for (int i = 0; i < 30; i++)
            {
                Entités.Entite_Reservation reservation = new Entités.Entite_Reservation();
                reservations.Add(reservation);
            }

            // Pour tous les clients présents dans la liste, les afficher
            int y = 0;
            foreach (Entités.Entite_Reservation reservation in reservations)
            {
                if (reservation == reservations[0])
                {
                    reservation.Location = new System.Drawing.Point(0, 0);
                }
                else
                {
                    reservations[y].Location = new Point(0, y * (reservation.Height + 10));
                }
                this.clientsPanel.Controls.Add(reservation);
                clientsPanel.AutoScroll = true;
                y++;
            }
        }
    }
}
