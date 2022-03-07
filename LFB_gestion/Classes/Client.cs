using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFB_gestion.Classes
{
    internal class Client
    {
        public int id;

        public string nom;

        public string prenom;

        string mail;

        public Client(int id, string nom, string prenom, string mail)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.mail = mail;
        }
        
        /// <summary>
        /// Affiche le prénom et le nom du client
        /// </summary>
        public override string ToString()
        {
            return prenom + " " + nom;
        }
    }
}
