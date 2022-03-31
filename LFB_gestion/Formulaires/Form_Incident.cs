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
        private Entite_Incident Incident;

        SqlConnection connexion = Outils.Connexion();

        public Form_Incident(Entite_Reservation réservation, Entite_Incident incident)
        {
            this.Incident = incident;
            this.réservation = réservation;
            InitializeComponent();
            remplirDonnées();


        }


        #region Événements

        #endregion

        #region Fonctions

        private void ajouterIncident(string description)
        {
            connexion.Open();
            if (Incident != null)
            {

                try
                {
                    string query = "insert into incident values ((select coalesce(MAX(id),0)+1 from produit), @desc, @id_réservation)";
                    SqlCommand cmd = new SqlCommand(query, connexion);
                    cmd.Parameters.AddWithValue("@desc", description);
                    cmd.Parameters.AddWithValue("@id_réservation", réservation.id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Incident signalé");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                string requete = " UPDATE incident SET description = @description WHERE id = @condition";
                SqlCommand command = new SqlCommand(requete, connexion);
                command.Parameters.AddWithValue("@description", description);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("Entretien modifié");
                connexion.Close();

            }
        }


            #endregion


            /// <summary>
            /// Rempli les données par défaut
            /// </summary>
            private void remplirDonnées()
            {
                clientlabel.Text = Outils.recupererClient(réservation.idClient).ToString();
                débutLabel.Text = réservation.début.ToString();
                emplacementlabel.Text += " " + réservation.emplacement.ToString();

            if (Incident != null)
            {
                descriptionTextBox.Text = Incident.description;
            }
            }

            private void validationBouton_Click(object sender, EventArgs e)
            {
                if (descriptionTextBox.Text != null)
                {
                    ajouterIncident(descriptionTextBox.Text);
                }
                else
                {
                MessageBox.Show("Description vide");
                }
            }
        }
    }
