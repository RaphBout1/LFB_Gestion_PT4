
namespace LFB_gestion
{
    partial class Acceuil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.boutonCompte = new System.Windows.Forms.Button();
            this.boutonClients = new System.Windows.Forms.Button();
            this.boutonStocks = new System.Windows.Forms.Button();
            this.boutonIncidents = new System.Windows.Forms.Button();
            this.boutonPlan = new System.Windows.Forms.Button();
            this.boutonReservations = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boutonCompte
            // 
            this.boutonCompte.Location = new System.Drawing.Point(951, 15);
            this.boutonCompte.Margin = new System.Windows.Forms.Padding(4);
            this.boutonCompte.Name = "boutonCompte";
            this.boutonCompte.Size = new System.Drawing.Size(100, 28);
            this.boutonCompte.TabIndex = 0;
            this.boutonCompte.Text = "Mon compte";
            this.boutonCompte.UseVisualStyleBackColor = true;
            // 
            // boutonClients
            // 
            this.boutonClients.Location = new System.Drawing.Point(668, 185);
            this.boutonClients.Margin = new System.Windows.Forms.Padding(4);
            this.boutonClients.Name = "boutonClients";
            this.boutonClients.Size = new System.Drawing.Size(100, 28);
            this.boutonClients.TabIndex = 1;
            this.boutonClients.Text = "Clients";
            this.boutonClients.UseVisualStyleBackColor = true;
            this.boutonClients.Click += new System.EventHandler(this.boutonClients_Click);
            // 
            // boutonStocks
            // 
            this.boutonStocks.Location = new System.Drawing.Point(464, 185);
            this.boutonStocks.Margin = new System.Windows.Forms.Padding(4);
            this.boutonStocks.Name = "boutonStocks";
            this.boutonStocks.Size = new System.Drawing.Size(100, 28);
            this.boutonStocks.TabIndex = 2;
            this.boutonStocks.Text = "Stocks";
            this.boutonStocks.UseVisualStyleBackColor = true;
            this.boutonStocks.Click += new System.EventHandler(this.boutonStocks_Click);
            // 
            // boutonIncidents
            // 
            this.boutonIncidents.Location = new System.Drawing.Point(260, 185);
            this.boutonIncidents.Margin = new System.Windows.Forms.Padding(4);
            this.boutonIncidents.Name = "boutonIncidents";
            this.boutonIncidents.Size = new System.Drawing.Size(100, 28);
            this.boutonIncidents.TabIndex = 3;
            this.boutonIncidents.Text = "Incidents";
            this.boutonIncidents.UseVisualStyleBackColor = true;
            this.boutonIncidents.Click += new System.EventHandler(this.boutonIncidents_Click);
            // 
            // boutonPlan
            // 
            this.boutonPlan.Location = new System.Drawing.Point(464, 273);
            this.boutonPlan.Margin = new System.Windows.Forms.Padding(4);
            this.boutonPlan.Name = "boutonPlan";
            this.boutonPlan.Size = new System.Drawing.Size(100, 28);
            this.boutonPlan.TabIndex = 4;
            this.boutonPlan.Text = "Plan";
            this.boutonPlan.UseVisualStyleBackColor = true;
            this.boutonPlan.Click += new System.EventHandler(this.button1_Click);
            // 
            // boutonReservations
            // 
            this.boutonReservations.Location = new System.Drawing.Point(260, 273);
            this.boutonReservations.Margin = new System.Windows.Forms.Padding(4);
            this.boutonReservations.Name = "boutonReservations";
            this.boutonReservations.Size = new System.Drawing.Size(100, 28);
            this.boutonReservations.TabIndex = 5;
            this.boutonReservations.Text = "Réservations";
            this.boutonReservations.UseVisualStyleBackColor = true;
            this.boutonReservations.Click += new System.EventHandler(this.boutonReservations_Click);
            // 
            // Acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.boutonReservations);
            this.Controls.Add(this.boutonPlan);
            this.Controls.Add(this.boutonIncidents);
            this.Controls.Add(this.boutonStocks);
            this.Controls.Add(this.boutonClients);
            this.Controls.Add(this.boutonCompte);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Acceuil";
            this.Text = "Acceuil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button boutonCompte;
        private System.Windows.Forms.Button boutonClients;
        private System.Windows.Forms.Button boutonStocks;
        private System.Windows.Forms.Button boutonIncidents;
        private System.Windows.Forms.Button boutonPlan;
        private System.Windows.Forms.Button boutonReservations;
    }
}

