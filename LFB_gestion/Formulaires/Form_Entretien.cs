using LFB_gestion.Entités;
using LFB_gestion.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LFB_gestion.Formulaires
{
    public partial class Form_Entretien : Form
    {
        Entite_Entretien entretien;

        public Form_Entretien(Entite_Entretien entretien)
        {
            InitializeComponent();
            if (entretien != null)
            {
                descriptionTextBox.Text = entretien.description;
                Outils.remplirUtilisateur(utilisateurListBox, entretien.user);
                Outils.remplirEmplacement(emplacementsListBox, entretien.emplacement.ToString());
                this.entretien = entretien;

            }
            else
            {
                Outils.remplirUtilisateur(utilisateurListBox, null);
                Outils.remplirEmplacement(emplacementsListBox, null);

            }
        }

        /// <summary>
        /// Vérifie si au moins un user est sélectionné pour la réservation
        /// </summary>
        /// <returns>renvoie vrai si au moins un user est sélectionné</returns>
        private bool auMoinsUnUserSelectionne()
        {
            return utilisateurListBox.SelectedItem != null;
        }

        /// <summary>
        /// Vérifie si au moins un emplacement est sélectionné pour la réservation
        /// </summary>
        /// <returns>renvoie vrai si au moins un emplacement est sélectionné</returns>
        private bool auMoinsUnEmplacementSelectionne()
        {
            return emplacementsListBox.SelectedItem != null;
        }

        private void validationBouton_Click(object sender, EventArgs e)
        {
            if (auMoinsUnUserSelectionne())
            {
                if (auMoinsUnEmplacementSelectionne())
                {
                    if (descriptionTextBox != null)
                    {


                        ajouterEntretien(descriptionTextBox.Text, utilisateurListBox.SelectedItem.ToString(), emplacementsListBox.SelectedItem.ToString());

                    }
                    else
                    {
                        MessageBox.Show("Description vide");
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez selectionner un emplacement.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez selectionner un utilisateur.");
            }
        }


        private void ajouterEntretien(string description, string utilisateur, string emplacement)
        {
            SqlConnection connexion = Outils.Connexion();
            connexion.Open();

            if (entretien == null)
            {

                string query = "select max(id) from entretien";
                SqlCommand command = new SqlCommand(query, connexion);
                DbDataReader reader = command.ExecuteReader();
                int id = 0;
                if (reader.Read())
                {
                    id = reader.GetInt32(0);
                    id++;
                }
                reader.Close();
                query = "insert into entretien  values (@id,@description, @utilisateur,@emplacement, GETDATE())";
                command = new SqlCommand(query, connexion);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@emplacement", emplacement);
                command.Parameters.AddWithValue("@utilisateur", utilisateur);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("Entretien rajouté");
                connexion.Close();
            }
            else
            {
                string requete = " UPDATE entretien SET id = @id, description = @description, login_user = @user, id_emplacement = @emplacement, date = @date WHERE id = @condition";
                SqlCommand command = new SqlCommand(requete, connexion);
                command.Parameters.AddWithValue("@id", entretien.id);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@emplacement", emplacement);
                command.Parameters.AddWithValue("@user", utilisateur);
                command.Parameters.AddWithValue("@date", entretien.date);
                command.Parameters.AddWithValue("@condition", entretien.id);

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
            
            this.Close();
        }
    }
}


