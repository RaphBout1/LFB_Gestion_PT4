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
            String produitLePlusVendu = "test";
            while (rd.Read())
            {
                produitLePlusVendu = rd["nom"].ToString();
            }
            MessageBox.Show(produitLePlusVendu);
            connexion.Close();
        }
    }
}
