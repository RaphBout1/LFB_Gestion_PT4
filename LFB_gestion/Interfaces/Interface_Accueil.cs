using LFB_gestion.Entités;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LFB_gestion.Interfaces
{
    public partial class Interface_Accueil : Interface_Abstraite
    {
        private SqlConnection connexion = Outils.Connexion();

        public static List<Entite_Client> clients = new List<Entite_Client>();

        public static List<Entite_Utilisateur> users = new List<Entite_Utilisateur>();

        public static List<Entite_Entretien> entretiens = new List<Entite_Entretien>();

        public static List<Entite_Incident> incidents = new List<Entite_Incident>();
        public static List<Entite_Reservation> reservations = new List<Entite_Reservation>();


        public Interface_Accueil()
        {
            selectClients();
            selectUsers();
            selectEntretien();
            selectIncident();
            selectReservation();
            InitializeComponent();
        }

        #region Événements



        #endregion

        #region Fonctions
        /// <summary>
        /// charge tous les clients depuis la base de données
        /// </summary>
        private void selectClients()
        {
            clients.Clear();
            connexion.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM client", connexion);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = (int)reader["id"];
                string adresse = (string)reader["adresse"];
                string mail = (string)reader["mail"];
                string codePostal = (string)reader["codePostal"];
                string nom = (string)reader["nom"];
                string prenom = (string)reader["prenom"];
                string tel = (string)reader["telephone"];
                string ville = (string)reader["ville"];

                clients.Add(new Entite_Client(id, nom, prenom, mail, adresse, codePostal, ville, tel));
            }
            reader.Close();
            connexion.Close();
        }

        /// <summary>
        /// Charge tous les utilisateurs depuis la base de données dans la liste users
        /// </summary>
        private void selectUsers()
        {
            users.Clear();
            connexion.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM utilisateur", connexion);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                try
                {
                    string login = (string)reader["login"];
                    string mdp = (string)reader["mdp"];
                    string mail = (string)reader["mail"];
                    int admin = (int)reader["admin"];
                    string nom = (string)reader["nom"];
                    string prenom = (string)reader["prenom"];
                    string tel = (string)reader["telephone"];
                    users.Add(new Entite_Utilisateur(login, mdp, mail, admin, nom, prenom, tel));
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            reader.Close();
            connexion.Close();
        }

        /// <summary>
        /// Charge tous les entretiens depuis la base de données dans la liste users
        /// </summary>
        private void selectEntretien()
        {
            entretiens.Clear();
            connexion.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM entretien", connexion);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                try
                {
                    int id = (int)reader["id"];
                    string date = reader["date"].ToString();
                    string description = (string)reader["description"];
                    string user = (string)reader["login_user"];
                    int emplacement = (int)reader["id_emplacement"];


                    entretiens.Add(new Entite_Entretien(id, date, description, emplacement, user));
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message + " selectEntretien");
                }
            }
            reader.Close();
            connexion.Close();
        }


        /// <summary>
        /// Charge tous les incidents depuis la base de données dans la liste users
        /// </summary>
        private void selectIncident()
        {
            incidents.Clear();
            connexion.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM incident", connexion);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                try
                {
                    int id = (int)reader["id"];
                    string description = (string)reader["description"];
                    int id_réservation = (int)reader["id_reservation"];
                    incidents.Add(new Entite_Incident(id, description, id_réservation));
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            reader.Close();
            connexion.Close();
        }

        /// <summary>
        /// Charge tous les réservations depuis la base de données dans la liste users
        /// </summary>
        private void selectReservation()
        {
            reservations.Clear();
            connexion.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM reservation", connexion);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                try
                {
                    int id = (int)reader["id"];
                    DateTime dateDebut = (DateTime)reader["date_debut"];
                    DateTime dateFin = (DateTime)reader["date_fin"];
                    int client = (int)reader["id_client"];
                    int emplacement = (int)reader["id_emplacement"];


                    reservations.Add(new Entite_Reservation(id,emplacement, client, dateDebut, dateFin));
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            reader.Close();
            connexion.Close();
        }


        #endregion



    }
}
