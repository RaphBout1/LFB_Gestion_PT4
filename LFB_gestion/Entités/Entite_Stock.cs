using LFB_gestion.Classes;
using LFB_gestion.Interfaces;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace LFB_gestion.Entités
{
    public partial class Entite_Stock : UserControl
    {
        public int id;
        public string name;
        public string image;
        public int quantite;
        /// <summary>
        /// Constructeur entité stock
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="image"></param>
        /// <param name="quantite"></param>
        public Entite_Stock(int id, string name, string image, int quantite)
        {
            this.id = id;
            this.name = name;
            this.image = image;
            this.quantite = quantite;
            InitializeComponent();
            quantiteProduitLabel.Text = quantite.ToString();
            nomProduitLabel.Text = name;
            Outils.afficherImage(image, imageProduitBox);
            
        }


        private void supprimerBouton_Click(object sender, System.EventArgs e)
        {
            SqlConnection connexion = Outils.Connexion();
            connexion.Open();
            string query = "delete from produit where id = @id";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@id", this.id);
            command.ExecuteNonQuery();
            MessageBox.Show("Produit supprimée");
            connexion.Close();
            dataBase.refreshDataBase();
            Form.ActiveForm.Close();
            Form formrefresh = new Interface_Stocks();

            formrefresh.ShowDialog();
        }

        private void modifierBouton_Click(object sender, EventArgs e)
        {
            Form form = new Formulaires.Form_Stock(this);
            form.ShowDialog();
        }
    }
}
