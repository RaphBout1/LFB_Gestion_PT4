using LFB_gestion.Classes;
using LFB_gestion.Formulaires;
using LFB_gestion.Interfaces;
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
        /// Constructeur de l'entité utilisateur
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

            string mdp = (string)reader["mdp"];
            string mail = (string)reader["mail"];
            int admin = (int)reader["admin"];
            string nom = (string)reader["nom"];
            string prenom = (string)reader["prenom"];
            string tel = (string)reader["telephone"];

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
            SqlConnection connexion = Outils.Connexion();
            connexion.Open();
            string query = "delete from entretien where login_user like @id ;delete from utilisateur where login like @id";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@id", this.login);
            command.ExecuteNonQuery();
            MessageBox.Show("Client supprimé");
            connexion.Close();
            dataBase.selectUsers();
        }

        /// <summary>
        /// Affiche le prénom et le nom de l'utilisateur
        /// </summary>
        public override string ToString()
        {
            return prenom + " " + nom;
        }

        private void modifierBouton_Click(object sender, EventArgs e)
        {
            Form form = new Form_Employe(this);
            form.ShowDialog();
            dataBase.selectUsers();
        }
    }
}
