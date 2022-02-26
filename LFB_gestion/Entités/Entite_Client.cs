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
        public String reservation;
        public Entite_Client(String nom, String prenom, String reservation)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.reservation = reservation;
            nomLabel.Text = this.nom;
            prenomLabel.Text = this.prenom;
            reservationLabel.Text = this.reservation;
            InitializeComponent();
        }
    }
}
