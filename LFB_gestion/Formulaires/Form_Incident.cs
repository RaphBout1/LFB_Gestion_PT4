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
        private Entite_Incident incident;

        SqlConnection connexion = Outils.Connexion();

        public Form_Incident(Entite_Reservation réservation, Entite_Incident incident)
        {
            this.incident = incident;
            this.réservation = réservation;
            InitializeComponent();
            remplirDonnées();



        }


        #region Événements

        #endregion

        #region Fonctions

        private void ajouterIncident(string description)
        {
            SqlConnection connexion = Outils.Connexion();

            connexion.Open();
            if (incident != null)
            {

                string requete = " UPDATE incident SET description = @description WHERE id = @condition";
                SqlCommand command = new SqlCommand(requete, connexion);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@condition", incident.id);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } 
                MessageBox.Show("Incident modifié");
            }
            else
            {
                try
                {
                    string query = "insert into incident values ((select coalesce(MAX(id),0)+1 from incident),@id_réservation, @desc )";
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
                connexion.Close();
            dataBase.refreshDataBase();
            this.Close();

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

            if (incident != null)
            {
                descriptionTextBox.Text = incident.description;
                validationBouton.Text = "Modifier";
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
