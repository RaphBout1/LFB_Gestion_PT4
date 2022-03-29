﻿using LFB_gestion.Entités;
using LFB_gestion.Interfaces;
using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.Globalization;
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
        /// trouve le client de la liste dans l'interface d'accueil à partir d'un id
        /// </summary>
        /// <param name="idClient"></param>
        /// <returns>Renvoie l'entité client correspondant à l'id</returns>
        public static Entite_Client trouverClient(int idClient)
        {
            Entite_Client res = null;
            foreach (Entite_Client client in Interface_Accueil.clients)
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


            if (Interfaces.Interface_Accueil.clients.Count != 0) //S'il existe des clients
            {
                foreach (Entités.Entite_Client client in Interfaces.Interface_Accueil.clients)
                {
                    listBox.DisplayMember = "nom";
                    listBox.ValueMember = "id";

                    listBox.Items.Add(client);
                        
                }
            }
        }

        public static Entités.Entite_Client afficherClient(int idRecherche)
        {
            foreach (Entités.Entite_Client client in Interfaces.Interface_Accueil.clients)
            {
                if (client.id == idRecherche)
                {
                    return client;
                }
            }

            MessageBox.Show("Le client avec l'id " + idRecherche + " n'existe pas");
            return null;

        }


    }
}
