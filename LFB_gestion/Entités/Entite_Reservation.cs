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
        /// Constructeur
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
            nomClientLabel.Text = Outils.recupererClient(idClient).ToString();
            emplacementLabel.Text = "emplacement " + this.emplacement.ToString();
            debutLabel.Text = this.début.ToString("dd/MM/yyyy");
            finLabel.Text = this.fin.ToString("dd/MM/yyyy");
        }

        private void buttonFacturer_Click(object sender, EventArgs e)
        {
            Form_Facture facture = new Form_Facture(this);
            facture.ShowDialog();
        }

        private void créerIncident_Click(object sender, EventArgs e)
        {
            Form_Incident incident = new Form_Incident(this, null);
            incident.ShowDialog();
        }

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
            dataBase.selectReservation();
        }

        private void modifierBouton_Click(object sender, EventArgs e)
        {
            Form_Reservation form = new Form_Reservation(true, this);
            selectDatesAModifier(form);
            selectClientAModifier(form);
            selectEmplacementAModifier(form);
            form.ShowDialog();
            dataBase.selectReservation();
        }

        private void selectDatesAModifier(Form_Reservation form)
        {
            SelectionRange sr = new SelectionRange();
            sr.Start = this.début;
            sr.End = this.fin;
            form.calendrier.SelectionRange = sr;
        }

        /// <summary>
        /// Trouver le numéro de l'item de la liste client qui correspond au client qu'il y a sur la réservation à modifier
        /// </summary>
        private void selectClientAModifier(Form_Reservation form)
        {
            int i = 0;
            int index = -1;
            foreach (string s in form.clientsListBox.Items)
            {
                if (s.Contains(Outils.trouverClient(this.idClient).ToString()))
                {
                    index = i;
                }
                i++;
            }
            form.clientsListBox.SelectedIndex = index;
        }

        private void selectEmplacementAModifier(Form_Reservation form)
        {
            int i = 0;
            int index = -1;
            foreach (var x in form.emplacementsListBox.Items)
            {
                int emplacement = -1;
                try
                {
                    emplacement = (int)x;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Convertion impossible de l'objet dans la liste d'emplacements en 'int'");
                }
                if (emplacement == this.emplacement)
                {
                    index = i;
                }
                i++;
            }
            form.emplacementsListBox.SelectedIndex = index;
        }
    }
}
