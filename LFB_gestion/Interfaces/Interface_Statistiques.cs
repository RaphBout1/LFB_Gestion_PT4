using System;
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
            afficherProduitLePlusVendu();
            InitializeComponent();
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
                        element.Location = new Point(20,30);
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
    }
}
