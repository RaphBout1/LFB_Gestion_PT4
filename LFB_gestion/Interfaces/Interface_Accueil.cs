using LFB_gestion.Entités;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace LFB_gestion.Interfaces
{
    public partial class Interface_Accueil : Interface_Abstraite
    {
        private SqlConnection connexion = Outils.Connexion();

        public static List<Entite_Client> clients = new List<Entite_Client>();

        public static List<Entite_Utilisateur> users = new List<Entite_Utilisateur>();

        public static List<Entite_Entretien> entretiens = new List<Entite_Entretien>();

        public Interface_Accueil()
        {
            selectClients();
            selectUsers();
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
                clients.Add(new Entite_Client(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3)));
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
                string login = reader.GetString(0);
                string mdp = reader.GetString(7);
                string mail = reader.GetString(2);
                int admin = reader.GetInt32(3);
                string nom = reader.GetString(5);
                string prenom = reader.GetString(4);
                string tel = reader.GetString(6);

                users.Add(new Entite_Utilisateur(login, mdp, mail, admin, nom, prenom, tel));
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
                int id = (int)reader["id"];
                DateTime date = (DateTime)reader["date"];
                string description = (string)reader["description"];
                string user = (string)reader["login_user"];
                int emplacement = (int)reader["id_emplacement"];
       

                entretiens.Add(new Entite_Entretien(id, date, description,emplacement, user ));
            }
            reader.Close();
            connexion.Close();
        }


        #endregion



    }
}
