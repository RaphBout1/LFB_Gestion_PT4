using LFB_gestion.Entités;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LFB_gestion.Interfaces
{
    public partial class Interface_Reservations : Interface_Abstraite
    {

        private SqlConnection connexion = Outils.Connexion();

        public Interface_Reservations()
        {
            nomModuleLabel.Text = "Réservations";
            nomModuleLabel.Text = "Module Réservations";
            placeHolder();
            AllReservations();
            InitializeComponent();
        }
        #region Événements
        /// <summary>
        /// bouton pour créer une nouvelle réservation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ajoutBouton_Click(object sender, EventArgs e)
        {
            Form formResa = new Formulaires.Form_Reservation();

            formResa.ShowDialog();
        }

        /// <summary>
        /// Permet de ne pas avoir le focus sur la textbox de recherche dès l'ouverture de l'onglet réservation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Interface_Reservations_Load(object sender, EventArgs e)
        {
            nomModuleLabel.Select();
            rechercheTextBox.LostFocus += rechercheTextBox_LostFocus;
            rechercheTextBox.GotFocus += rechercheTextBox_GotFocus;
        }

        /// <summary>
        /// Passer en mode écriture dans la textBox et non placeholder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rechercheTextBox_GotFocus(object sender, EventArgs e)
        {
            rechercheTextBox.ForeColor = Color.Black;
            rechercheTextBox.Text = "";
        }

        /// <summary>
        /// revenir en mode placeholder si la textbox est vide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rechercheTextBox_LostFocus(object sender, EventArgs e)
        {
            if (rechercheTextBox.Text == "")
            {
                placeHolder();
            }
        }

        /// <summary>
        /// rechercher dans la base de données les réservations avec le prénom et nom tapés dans la textBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rechercheBouton_Click(object sender, EventArgs e)
        {
            clientsPanel.Controls.Clear();
            string txt = rechercheTextBox.Text;
            string[] tab = txt.Split(' ');
            int id = 0;
            foreach (Entite_Client client in Interface_Accueil.clients)
            {
                // L'utilisateur doit tapper le prénom + le nom en entier
                if (tab[0] == client.prenom && tab[1] == client.nom) // client trouvé
                    id = client.id;
            }
            SqlCommand cmd = new SqlCommand("SELECT * from reservation where id_client = @id", connexion);
            cmd.Parameters.AddWithValue("id", id);
            reader(cmd);
        }

        /// <summary>
        /// Permet de valider la recherche en appuyant sur "entrer" au lieu de cliquer sur le bouton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rechercheTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                rechercheBouton_Click(sender, e);
        }
        #endregion

        #region Fonctions
        /// <summary>
        /// placeholder prénom nom pour la recherche de réservations
        /// </summary>
        private void placeHolder()
        {
            rechercheTextBox.ForeColor = Color.Gray;
            rechercheTextBox.Text = "prénom nom";
        }

        /// <summary>
        /// requête pour toutes les réservations qui appelel une fonction qui permet de les afficher
        /// </summary>
        private void AllReservations()
        {
            SqlCommand cmd = new SqlCommand("select * from reservation", connexion);
            reader(cmd);
        }

        /// <summary>
        /// appelle une fonction qui va afficher des réservations selon une requête précisée
        /// </summary>
        /// <param name="cmd">la requête pour chercher des réservations</param>
        private void reader(SqlCommand cmd)
        {
            connexion.Open();
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            List<Entite_Reservation> réservations = new List<Entite_Reservation>();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                int idEmplacement = reader.GetInt32(1);
                int idClient = reader.GetInt32(2);
                DateTime début = reader.GetDateTime(3);
                DateTime fin = reader.GetDateTime(4);
                Entite_Reservation réservation = new Entite_Reservation(id, idEmplacement, idClient, début, fin);
                réservations.Add(réservation);
            }
            affichageReservations(réservations);
        }

        /// <summary>
        /// gère l'affichage d'une liste de réservations avec l'entité réservation
        /// </summary>
        /// <param name="réservations">une liste de réservations</param>
        private void affichageReservations(List<Entite_Reservation> réservations)
        {
            clientsPanel.Controls.Clear();

            // Pour tous les clients présents dans la liste, les afficher
            if (réservations != null)
            {
                int y = 0;
                foreach (Entite_Reservation réservation in réservations)
                {
                    if (réservation == réservations[0])
                    {
                        réservation.Location = new System.Drawing.Point(0, 0);
                    }
                    else
                    {
                        réservations[y].Location = new Point(0, y * (réservation.Height + 30));
                    }
                    réservation.Width = this.clientsPanel.Width;
                    this.clientsPanel.Controls.Add(réservation);
                    clientsPanel.AutoScroll = true;
                    y++;
                }
            }
            else
            {
                MessageBox.Show("Pas de réservations dans la base");
            }
            connexion.Close();
        }
        #endregion
    }
}
