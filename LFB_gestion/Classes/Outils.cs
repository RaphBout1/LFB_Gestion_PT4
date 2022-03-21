﻿using LFB_gestion.Entités;
using LFB_gestion.Interfaces;
using System;
using System.Data.SqlClient;
using System.Text;

namespace LFB_gestion
{
    internal class Outils
    {
        private static string Key = "ENGn*fa}T&39.349&tgS";

        static string connexionString = "Data Source=info-joyeux;Initial Catalog=PT4_Camping_S4AE2;User Id=ETD;Password=ETD";



        /// <summary>
        /// Crypte un string
        /// </summary>
        /// <param name="text">Le string à crypter</param>
        /// <returns>Renvoie un string crypté</returns>
        public static string crypter(string text)
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
        public static bool isValidMail(string eMail)
        {
            bool Result = false;
            try
            {
                var eMailValidator = new System.Net.Mail.MailAddress(eMail);

                Result = (eMail.LastIndexOf(".") > eMail.LastIndexOf("@"));
            }
            catch
            {
                Result = false;
            };
            return Result;
        }

        /// <summary>
        /// trouve le client de la liste dans l'interface d'accueil à partir d'un id
        /// </summary>
        /// <param name="idClient"></param>
        /// <returns>Renvoie l'entité client correspondant à l'id</returns>
        public static Entite_Client findClient(int idClient)
        {
            Entite_Client res = null;
            foreach (Entite_Client client in Interface_Accueil.clients)
            {
                if (client.id == idClient)
                    res = client;
            }
            return res;
        }
    }
}
