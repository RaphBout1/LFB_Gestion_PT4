using LFB_gestion.Classes;
using LFB_gestion.Interfaces;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LFB_gestion.Entités
{
    public partial class Entite_Client : UserControl
    {
        public int id;

        public string nom;

        public string prenom;

        public string adresse;

        public string codePostal;

        public string ville;

        public string tel;

        public string mail;


        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="mail"></param>
        public Entite_Client(int id, string nom, string prenom, string adresse, string codePostal, string ville, string tel, string mail)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.codePostal = codePostal;
            this.ville = ville;
            this.tel = tel;
            this.mail = mail;
            ToString();
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

        private void supprimerBouton_Click(object sender, System.EventArgs e)
        {
            SqlConnection connexion = Outils.Connexion();
            connexion.Open();
            string query = "delete from client where id = @id";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@id", this.id);
            command.ExecuteNonQuery();
            MessageBox.Show("Client supprimé");
            connexion.Close();
            dataBase.selectClients();
        }
    }
}
