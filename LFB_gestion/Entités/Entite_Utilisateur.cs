using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LFB_gestion.Entités
{
    public partial class Entite_Utilisateur : UserControl
    {
        public string login;

        public string mdp;

        public string mail;

        public int admin;

        public string nom;

        public string prenom;

        public string tel;

        public static Entite_Utilisateur courant;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="login"></param>
        /// <param name="mdp"></param>
        /// <param name="mail"></param>
        /// <param name="admin"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        public Entite_Utilisateur(string login, string mdp, string mail, int admin, string nom, string prenom, string tel)
        {
            this.login = login;
            this.mdp = mdp;
            this.mail = mail;
            this.admin = admin;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            InitializeComponent();
            prenomLabel.Text = prenom;
            nomLabel.Text = nom;
        }

        /// <summary>
        /// Instancie l'utilisateur courant
        /// </summary>
        /// <param name="login">le login de l'utilisateur courant</param>
        /// <returns></returns>
        public static Entite_Utilisateur setUtilisateurCourant(string login)
        {
            SqlConnection connexion = Outils.Connexion();
            connexion.Open();

            string query = "SELECT * FROM utilisateur WHERE login = @login";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@login", login);
            DbDataReader reader = command.ExecuteReader();
            reader.Read();

            string mdp = reader.GetString(7);
            string mail = reader.GetString(2);
            int admin = reader.GetInt32(3);
            string nom = reader.GetString(5);
            string prenom = reader.GetString(4);
            string tel = reader.GetString(6);

            Entite_Utilisateur courant = new Entite_Utilisateur(login, mdp, mail, admin, nom, prenom, tel);

            reader.Close();
            return courant;
        }

        /// <summary>
        /// Supprimer l'utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void supprimerBouton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.prenom, this.nom);
        }
    }
}
