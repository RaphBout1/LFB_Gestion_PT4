using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFB_gestion.Classes
{
    class Utilisateur

    {
        public string login;
        public string mdp;
        public string mail;
        public int admin;
        public string nom;
        public string prenom;
        public int tel;

        public static Utilisateur CreationUtilisateur(string login)
        {
            SqlConnection connexion = Outils.Connexion();
            string query = "SELECT * FROM utilisateur WHERE login = @login";
            SqlCommand command = new SqlCommand(query, connexion);
            DbDataReader reader = command.ExecuteReader();


            Utilisateur courant = new Utilisateur
            {
                login = login,
                mdp = reader.GetValue(1).ToString(),
                mail = "cool",
                admin =1,
                nom = "cool",
                prenom = "cool",
                tel = 12345
            };
            // Chercher le mdp dans la base de données
            
            command.Parameters.AddWithValue("@login", login);

            
            return courant;
        }


    }
}
