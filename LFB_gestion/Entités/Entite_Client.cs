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
        public String nom;
        public String prenom;
        public String email;
        public Entite_Client(String nom, String prenom, String email)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
            nomLabel.Text = this.nom;
            prenomLabel.Text = this.prenom;
            emailLabel.Text = this.email;
            InitializeComponent();
        }
    }
}
