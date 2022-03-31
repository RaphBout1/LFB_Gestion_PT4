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
    public partial class Interface_Logs : Interface_Abstraite
    {
        public Interface_Logs()
        {
            InitializeComponent();
            afficherLogs();
        }
        /// <summary>
        /// affiche les logs qui sont stockées dans la base de données
        /// </summary>
        private void afficherLogs()
        {
            SqlConnection connexion = Outils.Connexion();
            connexion.Open();
            SqlCommand idQuery = new SqlCommand("select * from log", connexion);
            SqlDataReader rd;
            rd = idQuery.ExecuteReader();
            ListBox listBox = new ListBox();
            listBox.Size = new Size(900, 500);

            while (rd.Read())
            {
                try
                {
                    String elem = "utilisateur : " + rd["login_user"].ToString() + " | date : " + rd["date"].ToString() + " | action : " + rd["action"].ToString() + " | table modifié : " + rd["table_modifiée"].ToString();
                    listBox.Items.Add(elem);
                }
                catch (Exception e)
                {
                    String elem = "log indisponible";
                    listBox.Items.Add(elem);
                }
            }
            this.clientsPanel.Controls.Add(listBox);
        }
    }
}
