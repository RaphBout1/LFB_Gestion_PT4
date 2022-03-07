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

        public Utilisateur(string login, string mdp, string mail, int admin, string nom, string prenom, string tel)
        {
            this.login = login;
            this.mdp = mdp;
            this.mail = mail;
            this.admin = admin;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
        }

        public static Utilisateur CreationUtilisateur(string login)
        {
            SqlConnection connexion = Outils.Connexion();
            connexion.Open();

            string query = "SELECT * FROM utilisateur WHERE login = @login";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@login", login);
            DbDataReader reader = command.ExecuteReader();
            reader.Read();

            string mdp = reader.GetString(7);
            string mail = reader.GetString(2);
            int admin = reader.GetInt32(3);
            string nom = reader.GetString(5);
            string prenom = reader.GetString(4);
            string tel = reader.GetString(6);

            Utilisateur courant = new Utilisateur(login, mdp, mail, admin, nom, prenom, tel);

            reader.Close();
            return courant;
        }
        public static Utilisateur getUtilisateurCourant()
        {
            return courant;
        }

    }
}
