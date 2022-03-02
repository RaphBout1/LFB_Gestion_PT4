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

        public string mail;

        public Client(int id, string nom, string prenom, string mail)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.mail = mail;
        }
        
        public override string ToString()
        {
            return prenom + " " + nom;
        }
    }
}
