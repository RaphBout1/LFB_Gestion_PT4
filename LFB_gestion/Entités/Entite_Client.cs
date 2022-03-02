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
        private String nom;
        private String prenom;
        private String email;
       
        public Entite_Client(String nom, String prenom, String mail)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.email = mail;
            InitializeComponent();
            nomLabel.Text = nom;
            prenomLabel.Text = prenom;
            emailLabel.Text = mail;
        }

       public String getNom()
        {
            return this.nom;
        }

        public String getEmail()
        {
            return this.email;
        }

        public String getPrenom()
        {
            return this.prenom;
        }

        public void setNom(String nom)
        {
            this.nom = nom;
        }

        public void setPrenom(String prenom)
        {
            this.prenom = prenom;
        }

        public void setEmail(String nom)
        {
            this.email = email;
        }
    }
}
