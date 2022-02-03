
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
            this.SuspendLayout();
            // 
            // boutonCompte
            // 
            this.boutonCompte.Location = new System.Drawing.Point(713, 12);
            this.boutonCompte.Name = "boutonCompte";
            this.boutonCompte.Size = new System.Drawing.Size(75, 23);
            this.boutonCompte.TabIndex = 0;
            this.boutonCompte.Text = "Mon compte";
            this.boutonCompte.UseVisualStyleBackColor = true;
            // 
            // boutonClients
            // 
            this.boutonClients.Location = new System.Drawing.Point(501, 150);
            this.boutonClients.Name = "boutonClients";
            this.boutonClients.Size = new System.Drawing.Size(75, 23);
            this.boutonClients.TabIndex = 1;
            this.boutonClients.Text = "Clients";
            this.boutonClients.UseVisualStyleBackColor = true;
            // 
            // boutonStocks
            // 
            this.boutonStocks.Location = new System.Drawing.Point(348, 150);
            this.boutonStocks.Name = "boutonStocks";
            this.boutonStocks.Size = new System.Drawing.Size(75, 23);
            this.boutonStocks.TabIndex = 2;
            this.boutonStocks.Text = "Stocks";
            this.boutonStocks.UseVisualStyleBackColor = true;
            // 
            // boutonIncidents
            // 
            this.boutonIncidents.Location = new System.Drawing.Point(195, 150);
            this.boutonIncidents.Name = "boutonIncidents";
            this.boutonIncidents.Size = new System.Drawing.Size(75, 23);
            this.boutonIncidents.TabIndex = 3;
            this.boutonIncidents.Text = "Incidents";
            this.boutonIncidents.UseVisualStyleBackColor = true;
            // 
            // boutonPlan
            // 
            this.boutonPlan.Location = new System.Drawing.Point(348, 222);
            this.boutonPlan.Name = "boutonPlan";
            this.boutonPlan.Size = new System.Drawing.Size(75, 23);
            this.boutonPlan.TabIndex = 4;
            this.boutonPlan.Text = "Plan";
            this.boutonPlan.UseVisualStyleBackColor = true;
            this.boutonPlan.Click += new System.EventHandler(this.button1_Click);
            // 
            // Acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boutonPlan);
            this.Controls.Add(this.boutonIncidents);
            this.Controls.Add(this.boutonStocks);
            this.Controls.Add(this.boutonClients);
            this.Controls.Add(this.boutonCompte);
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
    }
}

