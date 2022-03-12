using LFB_gestion.Entités;
using LFB_gestion.Formulaires;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LFB_gestion.Interfaces
{
    public partial class Interface_Reservations : Interface_Abstraite
    {

        private SqlConnection connexion = Outils.Connexion();

        public Interface_Reservations()
        {
            nomModuleLabel.Text = "Réservations";
            AllReservations();
            InitializeComponent();
        }

        private void AllReservations()
        {
            SqlCommand cmd = new SqlCommand("select * from reservation", connexion);
            reader(cmd);
        }

        private void reader(SqlCommand cmd)
        {
            connexion.Open();
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            List<Entite_Reservation> réservations = new List<Entite_Reservation>();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                int idEmplacement = reader.GetInt32(1);
                int idClient = reader.GetInt32(2);
                DateTime début = reader.GetDateTime(3);
                DateTime fin = reader.GetDateTime(4);
                Entite_Reservation réservation= new Entite_Reservation(id, idEmplacement, idClient, début, fin);
                réservations.Add(réservation);
            }
            affichageReservations(réservations);
        }

        private void affichageReservations(List<Entite_Reservation> réservations)
        {
            clientsPanel.Controls.Clear();

            // Pour tous les clients présents dans la liste, les afficher
            if (réservations != null)
            {
                int y = 0;
                foreach (Entite_Reservation réservation in réservations)
                {
                    if (réservation == réservations[0])
                    {
                        réservation.Location = new System.Drawing.Point(0, 0);
                    }
                    else
                    {
                        réservations[y].Location = new Point(0, y * (réservation.Height + 30));
                    }
                    réservation.Width = this.clientsPanel.Width;
                    this.clientsPanel.Controls.Add(réservation);
                    clientsPanel.AutoScroll = true;
                    y++;
                }
            }
            else
            {
                MessageBox.Show("Pas de réservations dans la base");
            }
            connexion.Close();
        }

        /// <summary>
        /// bouton pour créer une nouvelle réservation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ajouter_button_Click(object sender, EventArgs e)
        {
            Form_Reservation reservation = new Form_Reservation();
            reservation.Show();
        }

        private void ajoutBouton_Click(object sender, EventArgs e)
        {
            Form formResa = new Formulaires.Form_Reservation();

            formResa.ShowDialog();
        }
    }
}
