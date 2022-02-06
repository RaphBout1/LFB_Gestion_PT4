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
    public partial class Interface_Clients : Interface_Abstraite
    {
        public Interface_Clients()
        {
            nomModuleLabel.Text = "Module Clients";
            InitialisationClients();
            InitializeComponent();
        }

        private void InitialisationClients()
        {
            // Génération de 30 modèles de clients pour tester (à supprimer)
            List<Entités.EntiteClient> clients = new List<Entités.EntiteClient>();
            for(int i =0; i<30; i++)
            {
                Entités.EntiteClient client = new Entités.EntiteClient();
                clients.Add(client);
            }

            // Pour tous les clients présents dans la liste, les afficher
            int y = 0;
            foreach (Entités.EntiteClient client in clients) {
                if (client == clients[0])
                {
                    client.Location = new System.Drawing.Point(0, 0);
                }
                else
                {
                    clients[y].Location = new Point(0, y * (client.Height + 10));
                }
                this.clientsPanel.Controls.Add(client);
                clientsPanel.AutoScroll = true;
                y++;
            }
        }
    }
}
