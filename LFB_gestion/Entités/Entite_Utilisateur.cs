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



    public partial class Entite_Utilisateur : UserControl
    {
        private String login;
        private String mdp;
        private String mail;
        private int admin;
        private String nom;
        private String prenom;
        private String tel;
        public Entite_Utilisateur(String login, String mdp, String mail, String nom, String prenom, String tel)
        {
            InitializeComponent();
            this.login = login;
            this.mdp = mdp; 
            this.mail = mail;   
            this.nom = nom; 
            this.prenom = prenom;
            this.tel = tel;

            loginLabel.Text = login;
            passwordLabel.Text = mdp;


             
        }

        private void Entite_Utilisateur_Load(object sender, EventArgs e)
        {

        }
    }
}
