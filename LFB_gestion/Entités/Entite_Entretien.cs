using LFB_gestion.Classes;
using LFB_gestion.Interfaces;
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

namespace LFB_gestion.Entités
{
    public partial class Entite_Entretien : UserControl
    {

        public int id;

        public string date;

        public string description;

        public int emplacement;

        public string user;

        public Entite_Entretien(int id, string date, string description, int emplacement, string user)
        {
            this.id = id;
            this.date = date;
            this.description = description;
            this.user = user;
            this.emplacement = emplacement;
            InitializeComponent();
            nomEmployeeLabel.Text = user.ToString();
            nomEmplacementLabel.Text = "Emplacement: " + emplacement.ToString();
            descriptionLabel.Text = description;



            
        }

        private void modifierBouton_Click(object sender, EventArgs e)
        {
            Form formEntretien = new Formulaires.Form_Entretien(this);
            formEntretien.ShowDialog();
            dataBase.selectEntretien();
        }

        private void supprimerBouton_Click(object sender, EventArgs e)
        {
            SqlConnection connexion = Outils.Connexion();
            connexion.Open();
            string query = "delete from entretien where id = @id";
            SqlCommand command = new SqlCommand(query, connexion);
            command.Parameters.AddWithValue("@id", this.id);
            command.ExecuteNonQuery();
            MessageBox.Show("Entretien supprimé");
            connexion.Close();
            dataBase.selectEntretien();
        }
    }
}
