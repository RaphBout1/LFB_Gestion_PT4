using LFB_gestion.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
  
}
}
