using LFB_gestion.Classes;
using LFB_gestion.Entités;
using LFB_gestion.Interfaces;
using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.Globalization;
using System.Drawing;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LFB_gestion
{
    public class Outils
    {
        private static string Key = "ENGn*fa}T&39.349&tgS";

        static string connexionString = "Data Source=info-joyeux;Initial Catalog=PT4_Camping_S4AE2;User Id=ETD;Password=ETD";



        /// <summary>
        /// Crypte un string
        /// </summary>
        /// <param name="text">Le string à chiffrer</param>
        /// <returns>Renvoie un string crypté</returns>
        public static string chiffrer(string text)
        {
            if (string.IsNullOrEmpty(text)) return "";
            string res = text + Key;
            var textBytes = Encoding.UTF8.GetBytes(res);
            return Convert.ToBase64String(textBytes);
        }

        /// <summary>
        /// Décrypter un string
        /// </summary>
        /// <param name="base64EncodeData">Le string à décrypter</param>
        /// <returns>Renvoie le string décrypté</returns>
        public static string décrypter(string base64EncodeData)
        {
            if (string.IsNullOrEmpty(base64EncodeData)) return "";
            var base64EncodeBytes = Convert.FromBase64String(base64EncodeData);
            var res = Encoding.UTF8.GetString(base64EncodeBytes);
            res = res.Substring(0, res.Length - Key.Length);
            return res;
        }

        public static SqlConnection Connexion()
        {
            return new SqlConnection(connexionString);
        }

        /// <summary>
        /// Vérifie si une adresse mail contient un '.' après un '@'
        /// </summary>
        /// <param name="eMail"></param>
        /// <returns>renvoie vrai si l'adresse mail est valide</returns>
        public static bool mailEstValide(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                string DomainMapper(Match match)
                {
                    var idn = new IdnMapping();
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
        /// <summary>
        /// Verifie si le numero de téléphone est correcte
        /// </summary>
        /// <param name="tel"></param>
        /// <returns></returns>
        public static bool isValidTel(string tel)
        {
            int cmpt = 0;
            foreach (char c in tel)
            {
                if (c >= '0' && c <= '9')
                {
                    cmpt++;
                }
                else
                {
                    return false;
                }
            }
            return (cmpt == 10);
        }

        /// <summary>
        /// Verifie si le numero du code Postale est correcte
        /// </summary>
        /// <param name="CP"></param>
        /// <returns></returns>
        public static bool isValidCodePostal(string CP)
        {
            int cmpt = 0;
            foreach (char c in CP)
            {
                if (c >= '0' && c <= '9')
                {
                    cmpt++;
                }
                else
                {
                    return false;
                }
            }
            return (cmpt == 5);
        }


        /// <summary>
        /// trouve le client de la liste dans l'interface d'accueil à partir d'un id
        /// </summary>
        /// <param name="idClient"></param>
        /// <returns>Renvoie l'entité client correspondant à l'id</returns>
        public static Entite_Client trouverClient(int idClient)
        {
            Entite_Client res = null;
            foreach (Entite_Client client in dataBase.clients)
            {
                if (client.id == idClient)
                    res = client;
            }
            return res;
        }

        /// <summary>
        /// Rempli la listBox avec les clients existant dans la basede données
        /// </summary>
        public static void remplirClients(ListBox listBox)
        {
            if (dataBase.clients.Count != 0) //S'il existe des clients
            {
                foreach (Entite_Client client in dataBase.clients)
                {
                    listBox.Items.Add(client.id + " " + client.ToString());

                }
            }
        }

        /// <summary>
        /// Rempli la listBox avec les utilisateurs existant dans la basede données
        /// </summary>
        public static void remplirUtilisateur(ListBox listBox, string userSelect)
        {
            int i = 0;


            if (dataBase.users.Count != 0)
            {
                foreach (Entités.Entite_Utilisateur user in dataBase.users)
                {

                    listBox.Items.Add(user.login);
                    if (user.login == userSelect)
                    {
                        listBox.SetSelected(i, true);
                    }

                    i++;
                }
            }
        }

        /// <summary>
        /// Rempli la listBox avec les emplacements existant dans la basede données
        /// </summary>
        public static void remplirEmplacement(ListBox listBox, string emplacementSelect)
        {
            int i = 0;
            SqlConnection connexion = Connexion();

            listBox.Items.Clear();
            connexion.Open();
            string query = "select emplacement.id from emplacement";

            SqlCommand command = new SqlCommand(query, connexion);
            DbDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    listBox.Items.Add(reader.GetInt32(0));
                    if (reader.GetInt32(0).ToString() == emplacementSelect)
                    {
                        listBox.SetSelected(i, true);
                    }

                    i++;
                }
            }

        }

        public static Entités.Entite_Client afficherClient(int idRecherche)
        {
            foreach (Entités.Entite_Client client in dataBase.clients)
            {
                if (client.id == idRecherche)
                {
                    return client;
                }
            }

            MessageBox.Show("Le client avec l'id " + idRecherche + " n'existe pas");
            return null;

        }

        public static void afficherImage(string image, PictureBox box)
        {
            try
            {
                WebRequest request = WebRequest.Create(image);
                using (var response = request.GetResponse())
                {
                    using (var str = response.GetResponseStream())
                    {
                        box.BackgroundImage = Bitmap.FromStream(str);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Url incorrecte");
            }
        }


    }
}
