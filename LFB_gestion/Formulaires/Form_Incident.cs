using LFB_gestion.Entités;
using LFB_gestion.Interfaces;
using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LFB_gestion.Formulaires
{
    public partial class Form_Incident : Form
    {
        private Entite_Reservation réservation;

        SqlConnection connexion = Outils.Connexion();

        public Form_Incident(Entite_Reservation réservation)
        {
            this.réservation = réservation;
            InitializeComponent();
            remplirDonnées();
        }


        #region Événements

        #endregion

        #region Fonctions

        #endregion


        /// <summary>
        /// Rempli les données par défaut
        /// </summary>
        private void remplirDonnées()
        {
            clientlabel.Text = (Interface_Accueil.clients.Find(client => client.id == réservation.idClient)).ToString();
            débutLabel.Text = réservation.début.ToString();
            emplacementlabel.Text += " " + réservation.emplacement.ToString();
        }

        private void validationBouton_Click(object sender, EventArgs e)
        {
            connexion.Open();
            string query = "select max(id) from incident";
            SqlCommand cmd = new SqlCommand(query, connexion);
            DbDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int id = reader.GetInt32(0) + 1;
            reader.Close();
            if (descriptionTextBox.Text != null)
            {
                try
                {
                    query = "insert into incident values (@id, @desc, @id_réservation)";
                    cmd = new SqlCommand(query, connexion);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@desc", descriptionTextBox.Text);
                    cmd.Parameters.AddWithValue("@id_réservation", réservation.id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Incident signalé");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
