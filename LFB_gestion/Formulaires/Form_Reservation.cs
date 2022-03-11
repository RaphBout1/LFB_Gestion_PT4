using LFB_gestion.Entités;
using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LFB_gestion.Formulaires
{
    public partial class Form_Reservation : Form
    {

        private static string connexionString = "Data Source=info-joyeux;Initial Catalog=PT4_Camping_S4AE2;User Id=ETD;Password=ETD;";

        private SqlConnection connexion = new SqlConnection(connexionString);

        public Form_Reservation()
        {
            InitializeComponent();
            remplirClients();
            emplacementsListBox.Items.Add("Sélectionner les dates");
        }

        #region Événements
        /// <summary>
        /// Bouton créer un nouveau client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nouveauClientBouton_Click(object sender, EventArgs e)
        {
            Form_Client formNouveauClient = new Form_Client();
            if (formNouveauClient.ShowDialog() == DialogResult.OK)
            {
                clientsListBox.Items.Clear();
                remplirClients();
            }
        }

        /// <summary>
        /// Bouton pour créer la réservation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void validerBouton_Click(object sender, EventArgs e)
        {
            if (auMoinsUnClientSelectionne())
            {
                if (auMoinsUnEmplacementSelectionne())
                {
                    if (datesLogiques())
                    {
                        ajouterRéservation(calendrier.SelectionRange, (Entite_Client)clientsListBox.SelectedItem, emplacementsListBox.SelectedItems);
                    }
                    else
                    {
                        MessageBox.Show("Les dates sélectionnées ne sont pas logiques");
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez selectionner un emplacement.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez selectionner un client.");
            }
        }

        /// <summary>
        /// Selon les dates selectionnées ça va afficher les emplacements disponibles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calendrier_DateChanged(object sender, DateRangeEventArgs e)
        {
            emplacementsListBox.Items.Clear();
            connexion.Open();
            string query = "select emplacement.id " +
                "from emplacement " +
                "left outer join reservation on emplacement.id = reservation.id_emplacement " +
                "where @dateDebut not between reservation.date_debut and reservation.date_fin " +
                "and   @dateFin not between reservation.date_debut and reservation.date_fin " +
                "and reservation.date_debut not between @dateDebut and @dateFin " +
                "and reservation.date_fin not between @dateDebut and @dateFin " +
                "or date_debut is null " +
                "group by emplacement.id";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@dateDebut", calendrier.SelectionRange.Start.ToString("dd-MM-yyyy"));
            command.Parameters.AddWithValue("@dateFin", calendrier.SelectionRange.End.ToString("dd-MM-yyyy"));
            DbDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    emplacementsListBox.Items.Add(reader.GetInt32(0));
                }
            }
            reader.Close();
            connexion.Close();
        }

        /// <summary>
        /// Aide pour sélectionner une date de réservation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void infoDate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pour sélectionner cliquer sur la date de début et faite glisser la souris tout en maintenant le clique sur la date de fin");
        }
        #endregion

        #region Fonctions
        /// <summary>
        /// Créer une réservation
        /// </summary>
        /// <param name="dates">dates auxquelles le client veut réserver un ou des emplacements</param>
        /// <param name="client">le client qui veut réserver</param>
        /// <param name="emplacements">le(s) emplacement(s) que le client veut réserver</param>
        private void ajouterRéservation(SelectionRange dates, Entite_Client client, ListBox.SelectedObjectCollection emplacements)
        {
            string s = "";   //Créer un string (pour l'afficher dans la confirmation) avec les numéros d'emplacements réservés au cas où il y ait plusieurs emplacements
            connexion.Open();
            foreach (int emplacement in emplacements)
            {
                s += emplacement + " ";
                string query = "select max(id) from reservation";
                SqlCommand command = new SqlCommand(query, connexion);
                DbDataReader reader = command.ExecuteReader();
                int id = 0;
                if (reader.Read())
                {
                    id = reader.GetInt32(0);
                    id++;
                }
                reader.Close();
                query = "insert into reservation  values (@id, @emplacement, @client, @dateDebut, @dateFin)";
                command = new SqlCommand(query, connexion);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@emplacement", emplacement);
                command.Parameters.AddWithValue("@client", client.id);
                command.Parameters.AddWithValue("@dateDebut", dates.Start);
                command.Parameters.AddWithValue("@dateFin", dates.End);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            MessageBox.Show("Réservation des emplacements " + s + " effectuée au nom de " + client.ToString());
            connexion.Close();
        }

        /// <summary>
        /// Vérifie si on a pas selectionné qu'un seul jour car c'est pas possible et si la date de fin est supérieur à la date de début de réservation
        /// </summary>
        /// <returns>retourne vrai si les dates sont logiques</returns>
        private bool datesLogiques()
        {
            return calendrier.SelectionEnd != calendrier.SelectionStart && calendrier.SelectionRange.Start < calendrier.SelectionRange.End;
        }

        /// <summary>
        /// Vérifie si au moins un emplacement est sélectionné pour la réservation
        /// </summary>
        /// <returns>renvoie vrai si au moins un emplacement est sélectionné</returns>
        private bool auMoinsUnEmplacementSelectionne()
        {
            return emplacementsListBox.SelectedItem != null;
        }

        /// <summary>
        /// Vérifie si au moins un client est sélectionné pour la réservation
        /// </summary>
        /// <returns>renvoie vrai si au moins un emplacement est sélectionné</returns>
        private bool auMoinsUnClientSelectionne()
        {
            return clientsListBox.SelectedItem != null;
        }

        /// <summary>
        /// Rempli la listBox avec les clients existant dans la basede données
        /// </summary>
        private void remplirClients()
        {
            connexion.Open();
            string query = "SELECT * from client";
            SqlCommand command = new SqlCommand(query, connexion);
            DbDataReader reader = command.ExecuteReader();

            if (reader.HasRows) //S'il existe des clients
            {
                while (reader.Read())
                {
                    Entite_Client client = new Entite_Client(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                    clientsListBox.Items.Add(client);
                }
                reader.Close();
            }
            connexion.Close();
        }
        #endregion

        
    }
}
