using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
            SqlConnection connexion = new SqlConnection(connexionString);

            return connexion;
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

    }
}
