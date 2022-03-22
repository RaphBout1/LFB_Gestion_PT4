using System.Windows.Forms;

namespace LFB_gestion.Entités
{
    public partial class Entite_Client : UserControl
    {
        public int id;

        public string nom;

        public string prenom;

        public string mail;
        public string adresse;
        public string codePostal;
        public string ville;
        public string tel;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="mail"></param>
        public Entite_Client(int id, string nom, string prenom, string mail, string adresse, string codePostal, string ville, string tel)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.mail = mail;
            this.adresse = adresse;
            this.codePostal = codePostal;
            this.ville = ville;
            this.tel = tel;
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
