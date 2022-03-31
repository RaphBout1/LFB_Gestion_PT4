using LFB_gestion.Classes;
using LFB_gestion.Formulaires;
using LFB_gestion.Interfaces;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LFB_gestion.Entités
{
    public partial class Entite_Reservation : UserControl
    {
        public int id;

        public int idClient;

        public int emplacement;

        public DateTime début;

        public DateTime fin;

        /// <summary>
        /// Constructeur de l'entité reservation
        /// </summary>
        /// <param name="id"></param>
        /// <param name="emplacement"></param>
        /// <param name="idClient"></param>
        /// <param name="début"></param>
        /// <param name="fin"></param>
        public Entite_Reservation(int id, int emplacement, int idClient, DateTime début, DateTime fin)
        {
            this.id = id;
            this.emplacement = emplacement;
            this.idClient = idClient;
            this.début = début;
            this.fin = fin;
            InitializeComponent();
            nomClientLabel.Text = Outils.afficherClient(idClient).ToString();
            emplacementLabel.Text = "emplacement " + this.emplacement.ToString();
            debutLabel.Text = this.début.ToString("dd/MM/yyyy");
            finLabel.Text = this.fin.ToString("dd/MM/yyyy");
        }
        /// <summary>
        /// affiche le formulaire pour créer une facture
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFacturer_Click(object sender, EventArgs e)
        {
            Form_Facture facture = new Form_Facture(this);
            facture.ShowDialog();
        }
        /// <summary>
        /// affiche le formulaire pour créer un incident
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void créerIncident_Click(object sender, EventArgs e)
        {
            Form_Incident incident = new Form_Incident(this);
            incident.ShowDialog();
        }
        /// <summary>
        /// supprime une reservation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void supprimerBouton_Click(object sender, EventArgs e)
        {
            SqlConnection connexion = Outils.Connexion();
            connexion.Open();
            string query = "delete from reservation where id = @id";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@id", this.id);
            command.ExecuteNonQuery();
            MessageBox.Show("Reservation supprimée");
            connexion.Close();
            dataBase.refreshDataBase();
            Form.ActiveForm.Close();
            Form formrefresh = new Interface_Reservations();

            formrefresh.ShowDialog();
        }
    }
}
