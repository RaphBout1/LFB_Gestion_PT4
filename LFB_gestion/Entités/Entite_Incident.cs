using System;
using System.Windows.Forms;

namespace LFB_gestion.Entités
{
    public partial class Entite_Incident : UserControl
    {

        public int id;
        public string description;
        public Boolean status;
        public int idClient;
        public int idEmplacement;
        public DateTime date;
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="id"></param>
        /// <param name="description"></param>
        /// <param name="status"></param>
        /// <param name="idClient"></param>
        /// <param name="idEmplacement"></param>
        /// <param name="date"></param>
        public Entite_Incident(int id, string description , Boolean status, int idClient,int idEmplacement, DateTime date )
        {
            this.id = id;
            this.description = description;
            this.status = status;
            this.idClient = idClient;
            this.idEmplacement = idEmplacement;
            InitializeComponent();
            descriptionLabel.Text = description;
            nomClientLabel.Text = Outils.afficherClient(idClient).ToString();
            nomEmplacementLabel.Text = idEmplacement.ToString();


        }


        private void statutBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
