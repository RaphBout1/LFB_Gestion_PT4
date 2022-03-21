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
            connexion.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM client", connexion);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                clients.Add(new Entite_Client(
                        (int)reader["id"],
                        reader["nom"].ToString(),
                        reader["prenom"].ToString(),
                        reader["adresse"].ToString(),
                        reader["codePostal"].ToString(),
                        reader["ville"].ToString(),
                        reader["telephone"].ToString(),
                        reader["mail"].ToString()
                    ));
            }
            reader.Close();
            connexion.Close();
        }

        /// <summary>
        /// Charge tous les utilisateurs depuis la base de données dans la liste users
        /// </summary>
        private void selectUsers()
        {
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
        #endregion



    }
}
