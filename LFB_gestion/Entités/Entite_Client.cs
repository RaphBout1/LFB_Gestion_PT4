using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LFB_gestion.Entités
{
    public partial class Entite_Client : UserControl
    {
        public int id;
        public string nom;
        public string prenom;
        public string mail;
       
        public Entite_Client(int id, string nom, string prenom, string mail)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.mail = mail;
            InitializeComponent();
            nomLabel.Text = nom;
            prenomLabel.Text = prenom;
            emailLabel.Text = mail;
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
