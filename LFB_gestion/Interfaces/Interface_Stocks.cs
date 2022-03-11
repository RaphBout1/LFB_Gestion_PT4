using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LFB_gestion.Interfaces
{
    public partial class Interface_Stocks : Interface_Abstraite
    {
        public Interface_Stocks()
        {
            InitialisationStocks();
            nomModuleLabel.Text = "Module Stocks";
            InitializeComponent();
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
        #endregion

        #region Fonctions
        /// <summary>
        /// Initialise quelques stocks et affiche les clients
        /// </summary>
        private void InitialisationStocks()
        {
            // Génération de 30 modèles de clients pour tester (à supprimer)
            List<Entités.Entite_Stock> stocks = new List<Entités.Entite_Stock>();
            for (int i = 0; i < 30; i++)
            {
                Entités.Entite_Stock stock = new Entités.Entite_Stock();
                stocks.Add(stock);
            }

            // Pour tous les clients présents dans la liste, les afficher
            int y = 0;
            foreach (Entités.Entite_Stock stock in stocks)
            {
                if (stock == stocks[0])
                {
                    stock.Location = new System.Drawing.Point(0, 0);
                }
                else
                {
                    stocks[y].Location = new Point(0, y * (stock.Height + 10));
                }
                this.clientsPanel.Controls.Add(stock);
                
                clientsPanel.AutoScroll = true;
                y++;
            }
        }
        #endregion


        
    }
}
