using LFB_gestion.Classes;
using LFB_gestion.Entités;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LFB_gestion.Interfaces
{
    public partial class Interface_Stocks : Interface_Abstraite
    {

        private SqlConnection connexion = Outils.Connexion();
        public Interface_Stocks()
        {
            nomModuleLabel.Text = "Stocks";
            InitializeComponent();
            afficherStock();
        }

      

        #region Événements
        /// <summary>
        /// Ouvre un formulaire pour créer un nouveau produit dans le stock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ajoutBouton_Click(object sender, EventArgs e)
        {
            Form formStock = new Formulaires.Form_Stock();
            formStock.ShowDialog();
        }

        private void rechercheBouton_Click(object sender, EventArgs e)
        {
            connexion.Open();
            // On récupère le texte dans le label rechercheLabel
            reader(rechercheTextBox.Text);
            connexion.Close();
        }


        #endregion

        #region Fonctions
        private void reader(string text)
        {
            List<Entite_Stock> listeStock = new List<Entite_Stock>();
            foreach (Entite_Stock stock in dataBase.stocks)
            {
                if (stock.name.Contains(text) || text == null || text == "")
                {
                    int id = stock.id;
                    string nom = stock.name;
                    string image = stock.image;
                    int quantite = stock.quantite;
                    Entite_Stock c = new Entite_Stock(id, nom, image, quantite);
                    listeStock.Add(c);

                }

            }
            affichageStock(listeStock);
        }

        private void affichageStock(List<Entite_Stock> listeStock)
        {
            clientsPanel.Controls.Clear();
            if (listeStock != null)
            {
                int y = 0;
                int x = 0;

                foreach (Entités.Entite_Stock stock in listeStock)
                {
                    if (stock == listeStock[0])
                    {
                        stock.Location = new System.Drawing.Point(0, 0);


                    }
                    else
                    {
                        if ((x * stock.Width + 170) + stock.Width + 170 < clientsPanel.Width)
                        {
                            stock.Location = new Point(x * (stock.Width + 170) + stock.Width + 170, y * (stock.Height + 100));
                            x++;
                        }
                        else
                        {
                            y++;
                            stock.Location = new Point(0, y * (stock.Height + 100));

                            x = 0;
                        }

                    }
                    this.clientsPanel.Controls.Add(stock);

                    clientsPanel.AutoScroll = true;

                }
            }
            else
            {
                MessageBox.Show("Pas de stock dans la base");
            }
           
        }

        private void afficherStock()
        {
            reader("");
        }


        #endregion


    }
}
