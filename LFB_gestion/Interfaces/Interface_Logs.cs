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
            resizeList();
        }

        public void resizeList()
        {
            listBoxLog.Width = clientsPanel.Width;
            listBoxLog.Height = clientsPanel.Height;
        }

        private void afficherLogs()
        {

            SqlConnection connexion = Outils.Connexion();
            connexion.Open();
            SqlCommand idQuery = new SqlCommand("select * from log", connexion);
            SqlDataReader rd;
            rd = idQuery.ExecuteReader();


            while (rd.Read())
            {
                try
                {
                    String elem = "utilisateur : " + rd["login_user"].ToString() + " | date : " + rd["date"].ToString() + " | action : " + rd["action"].ToString() + " | table modifié : " + rd["table_modifiée"].ToString();
                    listBoxLog.Items.Add(elem);
                }
                catch (Exception e)
                {
                    String elem = "log indisponible";
                    listBoxLog.Items.Add(elem);
                }
            }
            this.clientsPanel.Controls.Add(listBoxLog);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            afficherLogs();
        }
    }
}
