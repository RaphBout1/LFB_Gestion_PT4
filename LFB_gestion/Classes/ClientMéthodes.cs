using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LFB_gestion.Classes
{
    public class ClientMéthodes
    {
        public static SqlConnection connexion = Outils.Connexion();

        /// <summary>
        /// Création d'un nouveau client
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="mail"></param>
        public static void creationDuClient(string nom, string prenom, string mail, string adresse, string codePostal, string ville, string tel)
        {
            connexion.Open();
            int id = 0;
            string query = "select max (id) from client";
            SqlCommand command = new SqlCommand(query, connexion);
            DbDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                id = reader.GetInt32(0);
                id++;
                reader.Close();
            }
            try
            {
                query = "insert into client values (@id, @nom, @prenom, @mail, @adresse,@codePostal,@ville,@tel)";
                command = new SqlCommand(query, connexion);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@nom", nom);
                command.Parameters.AddWithValue("@prenom", prenom);
                command.Parameters.AddWithValue("@mail", mail);
                command.Parameters.AddWithValue("@mail", adresse);
                command.Parameters.AddWithValue("@mail", codePostal);
                command.Parameters.AddWithValue("@mail", ville);
                command.Parameters.AddWithValue("@mail", tel);
                command.ExecuteNonQuery();
                MessageBox.Show("Client bien ajouté");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connexion.Close();
        }

        /// <summary>
        /// Vérifie si le client qu'on veut créer n'existe pas déjà dans la base de données par le nom et le prénom
        /// </summary>
        /// <param name="prenom"></param>
        /// <param name="nom"></param>
        /// <returns></returns>
        public static bool clientDejaPresent(string prenom, string nom)
        {
            bool present = false;
            connexion.Open();
            string query = "select prenom, nom from client where prenom = @prenom and nom = @nom";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@prenom", prenom);
            command.Parameters.AddWithValue("@nom", nom);
            DbDataReader reader = null;
            try
            {
                reader = command.ExecuteReader();
                if (reader.HasRows)
                    present = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connexion.Close();
            return present;
        }
    }
}
