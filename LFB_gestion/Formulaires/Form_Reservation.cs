﻿using System;
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
    public partial class Form_Reservation : Form
    {

        private static string connexionString = "Data Source=info-joyeux;Initial Catalog=PT4_Camping_S4AE2;User Id=ETD;Password=ETD;";

        private SqlConnection connexion = new SqlConnection(connexionString);

        public Form_Reservation()
        {
            InitializeComponent();
            remplirClients();
            emplacementsListBox.Items.Add("Sélectionnez les dates");
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
                        ajouterRéservation(calendrier.SelectionRange, (Classes.Client)clientsListBox.SelectedItem, emplacementsListBox.SelectedItems);
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
        #endregion

        #region Fonctions
        private void ajouterRéservation(SelectionRange dates, Classes.Client client, ListBox.SelectedObjectCollection emplacements)
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

        private bool datesLogiques()
        {
            return calendrier.SelectionEnd != calendrier.SelectionStart;
        }

        private bool auMoinsUnEmplacementSelectionne()
        {
            return emplacementsListBox.SelectedItem != null;
        }

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
                    Classes.Client client = new Classes.Client(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                    clientsListBox.Items.Add(client);
                }
                reader.Close();
            }
            connexion.Close();
        }
        #endregion



    }
}
