
namespace LFB_gestion
{
    partial class MenuBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuBar));
            this.boutonCompte = new System.Windows.Forms.Button();
            this.boutonClients = new System.Windows.Forms.Button();
            this.boutonStocks = new System.Windows.Forms.Button();
            this.boutonIncidents = new System.Windows.Forms.Button();
            this.boutonPlan = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accueilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entretienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accueilToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.statistiquesToolStripMenuItem,
            this.entretienToolStripMenuItem,
            this.planToolStripMenuItem,
            this.clientsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 579);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1231, 68);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accueilToolStripMenuItem
            // 
            this.accueilToolStripMenuItem.Font = new System.Drawing.Font("Barlow Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accueilToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.accueilToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("accueilToolStripMenuItem.Image")));
            this.accueilToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accueilToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.accueilToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.accueilToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.accueilToolStripMenuItem.Name = "accueilToolStripMenuItem";
            this.accueilToolStripMenuItem.Size = new System.Drawing.Size(146, 64);
            this.accueilToolStripMenuItem.Text = "Accueil";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Font = new System.Drawing.Font("Barlow Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.stockToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stockToolStripMenuItem.Image")));
            this.stockToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stockToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(130, 64);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // statistiquesToolStripMenuItem
            // 
            this.statistiquesToolStripMenuItem.Font = new System.Drawing.Font("Barlow Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statistiquesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.statistiquesToolStripMenuItem.Image = global::LFB_gestion.Properties.Resources.iconeStat;
            this.statistiquesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statistiquesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.statistiquesToolStripMenuItem.Name = "statistiquesToolStripMenuItem";
            this.statistiquesToolStripMenuItem.Size = new System.Drawing.Size(189, 64);
            this.statistiquesToolStripMenuItem.Text = "Statistiques";
            // 
            // entretienToolStripMenuItem
            // 
            this.entretienToolStripMenuItem.Font = new System.Drawing.Font("Barlow Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entretienToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.entretienToolStripMenuItem.Image = global::LFB_gestion.Properties.Resources.iconeEntretien;
            this.entretienToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.entretienToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.entretienToolStripMenuItem.Name = "entretienToolStripMenuItem";
            this.entretienToolStripMenuItem.Size = new System.Drawing.Size(163, 64);
            this.entretienToolStripMenuItem.Text = "Entretien";
            // 
            // planToolStripMenuItem
            // 
            this.planToolStripMenuItem.Font = new System.Drawing.Font("Barlow Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.planToolStripMenuItem.Image = global::LFB_gestion.Properties.Resources.iconePlan;
            this.planToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.planToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.planToolStripMenuItem.Name = "planToolStripMenuItem";
            this.planToolStripMenuItem.Size = new System.Drawing.Size(118, 64);
            this.planToolStripMenuItem.Text = "Plan";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Font = new System.Drawing.Font("Barlow Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.clientsToolStripMenuItem.Image = global::LFB_gestion.Properties.Resources.iconeClients;
            this.clientsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(140, 64);
            this.clientsToolStripMenuItem.Text = "Clients";
            // 
            // Acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1231, 647);
            this.Controls.Add(this.boutonPlan);
            this.Controls.Add(this.boutonIncidents);
            this.Controls.Add(this.boutonStocks);
            this.Controls.Add(this.boutonClients);
            this.Controls.Add(this.boutonCompte);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Acceuil";
            this.Text = "Acceuil";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button boutonCompte;
        private System.Windows.Forms.Button boutonClients;
        private System.Windows.Forms.Button boutonStocks;
        private System.Windows.Forms.Button boutonIncidents;
        private System.Windows.Forms.Button boutonPlan;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accueilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistiquesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entretienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
    }
}

