using LFB_gestion.Classes;
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
            clientlabel.Text = (dataBase.clients.Find(client => client.id == réservation.idClient)).ToString();
            débutLabel.Text = réservation.début.ToString();
            emplacementlabel.Text += " " + réservation.emplacement.ToString();
        }

        private void validationBouton_Click(object sender, EventArgs e)
        {
            connexion.Open();
            if (descriptionTextBox.Text != null)
            {
                try
                {
                    string query = "insert into incident values ((select coalesce(MAX(id),0) from incident)+1, @id_réservation, @desc)";
                    SqlCommand cmd = new SqlCommand(query, connexion);
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
            connexion.Close();
            this.Close();
        }
    }
}
