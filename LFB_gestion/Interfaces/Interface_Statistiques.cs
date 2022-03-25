﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LFB_gestion.Interfaces
{
    public partial class Interface_Statistiques : Interface_Abstraite
    {
        SqlConnection connexion = Outils.Connexion();
        public Interface_Statistiques()
        {
            nomModuleLabel.Text = "Module statistiques";
            InitializeComponent();
            afficherProduitLePlusVendu();
            afficherPlusGrosConsommateur();
            afficherEmplacementAvecLePlusIncidents();
            afficheremplacementPrefere();
        }



        private void afficheremplacementPrefere()
        {
            connexion.Open();
            SqlCommand idQuery = new SqlCommand("select nom,COUNT(id_emplacement) as nb_reserves from emplacement inner join reservation on emplacement.id = reservation.id_emplacement GROUP BY nom  ORDER BY nb_reserves DESC OFFSET 0 ROWS FETCH FIRST 1 ROWS ONLY", connexion);
            SqlDataReader rd;
            Label label = new Label();
            label.Size = new Size(200, 50);
            label.Location = new Point(500, 50);
            rd = idQuery.ExecuteReader();

            while (rd.Read())
            {
                label.Text = "L'emplacement préféré des clients est\n l'" + rd["nom"].ToString() + " avec " + rd["nb_reserves"].ToString() + " réservation(s)";
            }
            connexion.Close();
            this.clientsPanel.Controls.Add(label);
        }

        private void afficherEmplacementAvecLePlusIncidents()
        {
            connexion.Open();
            SqlCommand idQuery = new SqlCommand("select emplacement.nom,COUNT(incident.id) as nb_incidents from emplacement inner join incident on emplacement.id = incident.id_emplacement group by emplacement.nom ORDER BY nb_incidents DESC OFFSET 0 ROWS FETCH FIRST 1 ROWS ONLY", connexion);
            SqlDataReader rd;
            Label label = new Label();
            label.Size = new Size(200, 50);
            label.Location = new Point(900, 50);
            rd = idQuery.ExecuteReader();

            while (rd.Read())
            {
                label.Text = "L'emplacement avec le plus d'incidents est \n l'" + rd["nom"].ToString() + " avec " + rd["nb_incidents"].ToString() + " incidents";
            }
            connexion.Close();
            this.clientsPanel.Controls.Add(label);
        }

        private void afficherPlusGrosConsommateur()
        {
            connexion.Open();
            SqlCommand idQuery = new SqlCommand("select client.nom,client.prenom,COUNT(vente.id) as nb_vente from client inner join vente on client.id = vente.id_client group by client.nom, client.prenom ORDER BY nb_vente DESC OFFSET 0 ROWS FETCH FIRST 1 ROWS ONLY", connexion);
            SqlDataReader rd;
            Label label = new Label();
            label.Size = new Size(200, 50);
            label.Location = new Point(1200, 50);
            rd = idQuery.ExecuteReader();

            while (rd.Read())
            {
                label.Text = "Le plus gros consommateur est " + rd["nom"] + " avec \n" + rd["nb_vente"].ToString() + " ventes";
            }
            connexion.Close();
            this.clientsPanel.Controls.Add(label);
        }

        private void afficherProduitLePlusVendu()
        {
            connexion.Open();
            SqlCommand idQuery = new SqlCommand("select produit.nom,COUNT(vente.id) as nb_vente from produit inner join vente on produit.id = vente.id_produit group by produit.nom ORDER BY nb_vente DESC OFFSET 0 ROWS FETCH FIRST 1 ROWS ONLY", connexion);
            SqlDataReader rd;
            rd = idQuery.ExecuteReader();
            List<Control> elements = new List<Control>();

            while (rd.Read())
            {
                Entités.Entite_Produit produit = new Entités.Entite_Produit(rd["nom"].ToString(), rd["nb_vente"].ToString());
                elements.Add(produit);
            }
            affichageStats(elements);
            connexion.Close();
        }

        private void affichageStats(List<Control> elements)
        {
            clientsPanel.Controls.Clear();

            // Pour tous les clients présents dans la liste, les afficher
            if (elements != null)
            {
                int y = 0;
                foreach (Control element in elements)
                {
                    if (element == elements[0])
                    {
                        Label meilleureVenteLabel = new Label();
                        meilleureVenteLabel.Text = "Produit le plus vendu : ";
                        meilleureVenteLabel.Size = new Size(400, 40);
                        meilleureVenteLabel.Location = new Point(20, 20);
                        this.clientsPanel.Controls.Add(meilleureVenteLabel);
                        element.Location = new Point(20, 30);
                    }
                    else
                    {
                        elements[y].Location = new Point(0, y * (element.Height + 30));
                    }
                    this.clientsPanel.Controls.Add(element);
                    clientsPanel.AutoScroll = true;
                    y++;
                }
            }
            else
            {
                MessageBox.Show("Pas de client dans la base");
            }
            connexion.Close();
        }

        private void rechercheBouton_Click(object sender, EventArgs e)
        {

        }
    }
}
