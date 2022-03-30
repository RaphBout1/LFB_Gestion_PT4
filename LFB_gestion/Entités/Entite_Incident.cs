using LFB_gestion.Classes;
using LFB_gestion.Interfaces;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LFB_gestion.Entités
{
    public partial class Entite_Incident : UserControl
    {

        public int id;
        public string description;
        public int id_réservation;
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="id"></param>
        /// <param name="description"></param>
        /// <param name="status"></param>
        /// <param name="idClient"></param>
        /// <param name="idEmplacement"></param>
        /// <param name="date"></param>
        public Entite_Incident(int id, string description, int id_réservation)
        {
            this.id = id;
            this.description = description;
            this.id_réservation = id_réservation;
            InitializeComponent();
            descriptionLabel.Text = description;
        }

        private void supprimerBouton_Click(object sender, EventArgs e)
        {
            SqlConnection connexion = Outils.Connexion();
            connexion.Open();
            string query = "delete from incident where id = @id";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@id", this.id);
            command.ExecuteNonQuery();
            MessageBox.Show("Incident supprimé");
            connexion.Close();
            dataBase.refreshDataBase();
            Form.ActiveForm.Close();
            Form formrefresh = new Interface_Incidents();

            formrefresh.ShowDialog();
        }
    }
}
