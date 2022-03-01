using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFB_gestion.Classes
{
    public class Utilisateur

    {
        public string login;
        public string mdp;
        public string mail;
        public int admin;
        public string nom;
        public string prenom;
        public string tel;
        public static Utilisateur courant;

        public static Utilisateur CreationUtilisateur(string login)
        {
            SqlConnection connexion = Outils.Connexion();
            connexion.Open();

            string query = "SELECT * FROM utilisateur WHERE login = @login";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@login", login);
            DbDataReader reader = command.ExecuteReader();
            reader.Read();

            Utilisateur courant = new Utilisateur
            {
                login = login,
                mdp = reader.GetValue(7).ToString(),
                mail = reader.GetValue(2).ToString(),
                admin = (int)reader.GetValue(3),
                nom = reader.GetValue(5).ToString(),
                prenom = reader.GetValue(4).ToString(),
                tel = reader.GetValue(6).ToString()
            };



            reader.Close();
            return courant;
        }
        public static Utilisateur getUtilisateurCourant()
        {
            return courant;
        }


    }
}
