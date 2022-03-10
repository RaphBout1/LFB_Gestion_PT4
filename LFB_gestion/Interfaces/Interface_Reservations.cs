using LFB_gestion.Formulaires;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace LFB_gestion.Interfaces
{
    public partial class Interface_Reservations : Interface_Abstraite
    {

        private SqlConnection connexion = Outils.Connexion();

        List<Entités.Entite_Reservation> reservations = new List<Entités.Entite_Reservation>();

        public Interface_Reservations()
        {
            nomModuleLabel.Text = "Module Réservations";
            AllReservations();
            InitializeComponent();
        }

        private void AllReservations()
        {
            connexion.Open();
            SqlCommand cmd = new SqlCommand("select * from reservation");
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                reservations.Add();
            }
        }
        private void reader(SqlCommand cmd)
        {
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            List<Entités.Entite_Reservation> reservations = new List<Entités.Entite_Reservation>();
            while (reader.Read())
            {
                String nom = reader["nom"].ToString();
                String prenom = reader["prenom"].ToString();
                String email = reader["mail"].ToString();
                Entités.Entite_Reservation reservations= new Entités.Entite_Reservation(nom, prenom, email);
                reservations.Add(client);
            }
            affichageReservations(listeClients);

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
    }
}
