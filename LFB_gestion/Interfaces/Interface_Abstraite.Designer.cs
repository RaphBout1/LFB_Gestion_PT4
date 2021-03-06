namespace LFB_gestion.Interfaces
{
    partial class Interface_Abstraite
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interface_Abstraite));
            this.nomModuleLabel = new System.Windows.Forms.Label();
            this.rechercheTextBox = new System.Windows.Forms.TextBox();
            this.rechercheBouton = new System.Windows.Forms.Button();
            this.clientsPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accueilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entretienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsToolStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelRecherche = new System.Windows.Forms.Panel();
            this.panelNomModule = new System.Windows.Forms.Panel();
            this.ajoutBouton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.buttonDeconnexion = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelRecherche.SuspendLayout();
            this.panelNomModule.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomModuleLabel
            // 
            this.nomModuleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nomModuleLabel.AutoSize = true;
            this.nomModuleLabel.BackColor = System.Drawing.Color.Transparent;
            this.nomModuleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomModuleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.nomModuleLabel.Location = new System.Drawing.Point(2, 2);
            this.nomModuleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nomModuleLabel.Name = "nomModuleLabel";
            this.nomModuleLabel.Size = new System.Drawing.Size(255, 31);
            this.nomModuleLabel.TabIndex = 0;
            this.nomModuleLabel.Text = "Nom_Module_Label";
            // 
            // rechercheTextBox
            // 
            this.rechercheTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.rechercheTextBox.Location = new System.Drawing.Point(2, 9);
            this.rechercheTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.rechercheTextBox.Name = "rechercheTextBox";
            this.rechercheTextBox.Size = new System.Drawing.Size(236, 20);
            this.rechercheTextBox.TabIndex = 4;
            // 
            // rechercheBouton
            // 
            this.rechercheBouton.BackColor = System.Drawing.Color.Transparent;
            this.rechercheBouton.BackgroundImage = global::LFB_gestion.Properties.Resources.loupe;
            this.rechercheBouton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rechercheBouton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rechercheBouton.FlatAppearance.BorderSize = 0;
            this.rechercheBouton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rechercheBouton.ForeColor = System.Drawing.Color.Transparent;
            this.rechercheBouton.Location = new System.Drawing.Point(242, 2);
            this.rechercheBouton.Margin = new System.Windows.Forms.Padding(2);
            this.rechercheBouton.Name = "rechercheBouton";
            this.rechercheBouton.Size = new System.Drawing.Size(32, 33);
            this.rechercheBouton.TabIndex = 5;
            this.rechercheBouton.UseVisualStyleBackColor = true;
            // 
            // clientsPanel
            // 
            this.clientsPanel.AutoScroll = true;
            this.clientsPanel.BackColor = System.Drawing.Color.Transparent;
            this.clientsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clientsPanel.Location = new System.Drawing.Point(92, 139);
            this.clientsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.clientsPanel.Name = "clientsPanel";
            this.clientsPanel.Size = new System.Drawing.Size(407, 310);
            this.clientsPanel.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImage = global::LFB_gestion.Properties.Resources.fondMenuNav;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accueilToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.incidentsToolStripMenuItem,
            this.entretienToolStripMenuItem,
            this.planToolStripMenuItem,
            this.reservationsToolStripMenuItem,
            this.stocksToolStripMenuItem,
            this.utilisateursToolStripMenuItem,
            this.statistiquesToolStripMenuItem,
            this.logsToolStripButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 935);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1284, 70);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accueilToolStripMenuItem
            // 
            this.accueilToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accueilToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.accueilToolStripMenuItem.Image = global::LFB_gestion.Properties.Resources.iconeAccueil;
            this.accueilToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accueilToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.accueilToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.accueilToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.accueilToolStripMenuItem.Name = "accueilToolStripMenuItem";
            this.accueilToolStripMenuItem.Size = new System.Drawing.Size(143, 66);
            this.accueilToolStripMenuItem.Text = "Accueil";
            this.accueilToolStripMenuItem.Click += new System.EventHandler(this.accueilToolStripMenuItem_Click);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.clientsToolStripMenuItem.Image = global::LFB_gestion.Properties.Resources.iconeClients;
            this.clientsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(139, 66);
            this.clientsToolStripMenuItem.Text = "Clients";
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            // 
            // incidentsToolStripMenuItem
            // 
            this.incidentsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incidentsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.incidentsToolStripMenuItem.Image = global::LFB_gestion.Properties.Resources.iconeIncident;
            this.incidentsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.incidentsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.incidentsToolStripMenuItem.Name = "incidentsToolStripMenuItem";
            this.incidentsToolStripMenuItem.Size = new System.Drawing.Size(159, 66);
            this.incidentsToolStripMenuItem.Text = "Incidents";
            this.incidentsToolStripMenuItem.Click += new System.EventHandler(this.incidentsToolStripMenuItem_Click);
            // 
            // entretienToolStripMenuItem
            // 
            this.entretienToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entretienToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.entretienToolStripMenuItem.Image = global::LFB_gestion.Properties.Resources.iconeEntretien;
            this.entretienToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.entretienToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.entretienToolStripMenuItem.Name = "entretienToolStripMenuItem";
            this.entretienToolStripMenuItem.Size = new System.Drawing.Size(159, 66);
            this.entretienToolStripMenuItem.Text = "Entretien";
            this.entretienToolStripMenuItem.Click += new System.EventHandler(this.entretienToolStripMenuItem_Click);
            // 
            // planToolStripMenuItem
            // 
            this.planToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.planToolStripMenuItem.Image = global::LFB_gestion.Properties.Resources.iconePlan;
            this.planToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.planToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.planToolStripMenuItem.Name = "planToolStripMenuItem";
            this.planToolStripMenuItem.Size = new System.Drawing.Size(116, 66);
            this.planToolStripMenuItem.Text = "Plan";
            this.planToolStripMenuItem.Click += new System.EventHandler(this.planToolStripMenuItem_Click);
            // 
            // reservationsToolStripMenuItem
            // 
            this.reservationsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.reservationsToolStripMenuItem.Image = global::LFB_gestion.Properties.Resources.iconeResa;
            this.reservationsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reservationsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reservationsToolStripMenuItem.Name = "reservationsToolStripMenuItem";
            this.reservationsToolStripMenuItem.Size = new System.Drawing.Size(199, 66);
            this.reservationsToolStripMenuItem.Text = "Reservations";
            this.reservationsToolStripMenuItem.Click += new System.EventHandler(this.reservationsToolStripMenuItem_Click);
            // 
            // stocksToolStripMenuItem
            // 
            this.stocksToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stocksToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.stocksToolStripMenuItem.Image = global::LFB_gestion.Properties.Resources.iconeStock;
            this.stocksToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stocksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stocksToolStripMenuItem.Name = "stocksToolStripMenuItem";
            this.stocksToolStripMenuItem.ShowShortcutKeys = false;
            this.stocksToolStripMenuItem.Size = new System.Drawing.Size(127, 66);
            this.stocksToolStripMenuItem.Text = "Stock";
            this.stocksToolStripMenuItem.Click += new System.EventHandler(this.stocksToolStripMenuItem_Click);
            // 
            // utilisateursToolStripMenuItem
            // 
            this.utilisateursToolStripMenuItem.AutoToolTip = true;
            this.utilisateursToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilisateursToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.utilisateursToolStripMenuItem.Image = global::LFB_gestion.Properties.Resources.iconeUtilisateur;
            this.utilisateursToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.utilisateursToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.utilisateursToolStripMenuItem.Name = "utilisateursToolStripMenuItem";
            this.utilisateursToolStripMenuItem.Size = new System.Drawing.Size(180, 66);
            this.utilisateursToolStripMenuItem.Text = "Utilisateurs";
            this.utilisateursToolStripMenuItem.Click += new System.EventHandler(this.utilisateursToolStripMenuItem_Click);
            // 
            // statistiquesToolStripMenuItem
            // 
            this.statistiquesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statistiquesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.statistiquesToolStripMenuItem.Image = global::LFB_gestion.Properties.Resources.iconeStat;
            this.statistiquesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statistiquesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.statistiquesToolStripMenuItem.Name = "statistiquesToolStripMenuItem";
            this.statistiquesToolStripMenuItem.Size = new System.Drawing.Size(185, 66);
            this.statistiquesToolStripMenuItem.Text = "Statistiques";
            this.statistiquesToolStripMenuItem.Click += new System.EventHandler(this.statistiquesToolStripMenuItem_Click);
            // 
            // logsToolStripButton
            // 
            this.logsToolStripButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logsToolStripButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.logsToolStripButton.Image = global::LFB_gestion.Properties.Resources.iconeLogs;
            this.logsToolStripButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logsToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.logsToolStripButton.Name = "logsToolStripButton";
            this.logsToolStripButton.Size = new System.Drawing.Size(119, 66);
            this.logsToolStripButton.Text = "Logs";
            this.logsToolStripButton.Click += new System.EventHandler(this.logsToolStripButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::LFB_gestion.Properties.Resources.logoDuHAut;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = global::LFB_gestion.Properties.Resources.logoDuHAut;
            this.pictureBox1.InitialImage = global::LFB_gestion.Properties.Resources.logoDuHAut;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 65);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panelRecherche
            // 
            this.panelRecherche.BackColor = System.Drawing.Color.Transparent;
            this.panelRecherche.Controls.Add(this.rechercheBouton);
            this.panelRecherche.Controls.Add(this.rechercheTextBox);
            this.panelRecherche.Location = new System.Drawing.Point(431, 92);
            this.panelRecherche.Margin = new System.Windows.Forms.Padding(2);
            this.panelRecherche.Name = "panelRecherche";
            this.panelRecherche.Size = new System.Drawing.Size(286, 37);
            this.panelRecherche.TabIndex = 0;
            // 
            // panelNomModule
            // 
            this.panelNomModule.BackColor = System.Drawing.Color.Transparent;
            this.panelNomModule.Controls.Add(this.ajoutBouton);
            this.panelNomModule.Controls.Add(this.nomModuleLabel);
            this.panelNomModule.Location = new System.Drawing.Point(26, 92);
            this.panelNomModule.Margin = new System.Windows.Forms.Padding(2);
            this.panelNomModule.Name = "panelNomModule";
            this.panelNomModule.Size = new System.Drawing.Size(372, 37);
            this.panelNomModule.TabIndex = 8;
            // 
            // ajoutBouton
            // 
            this.ajoutBouton.BackgroundImage = global::LFB_gestion.Properties.Resources.plusIcone;
            this.ajoutBouton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ajoutBouton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ajoutBouton.FlatAppearance.BorderSize = 0;
            this.ajoutBouton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ajoutBouton.Location = new System.Drawing.Point(288, 0);
            this.ajoutBouton.Margin = new System.Windows.Forms.Padding(2);
            this.ajoutBouton.Name = "ajoutBouton";
            this.ajoutBouton.Size = new System.Drawing.Size(42, 37);
            this.ajoutBouton.TabIndex = 1;
            this.ajoutBouton.UseVisualStyleBackColor = true;
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.Transparent;
            this.refreshButton.BackgroundImage = global::LFB_gestion.Properties.Resources.refresh;
            this.refreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshButton.FlatAppearance.BorderSize = 0;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Location = new System.Drawing.Point(400, 92);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(35, 37);
            this.refreshButton.TabIndex = 10;
            this.refreshButton.UseVisualStyleBackColor = false;
            // 
            // buttonDeconnexion
            // 
            this.buttonDeconnexion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeconnexion.BackColor = System.Drawing.Color.Transparent;
            this.buttonDeconnexion.BackgroundImage = global::LFB_gestion.Properties.Resources.boutonDeco1;
            this.buttonDeconnexion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDeconnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeconnexion.FlatAppearance.BorderSize = 0;
            this.buttonDeconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeconnexion.Location = new System.Drawing.Point(1699, 0);
            this.buttonDeconnexion.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeconnexion.Name = "buttonDeconnexion";
            this.buttonDeconnexion.Size = new System.Drawing.Size(210, 65);
            this.buttonDeconnexion.TabIndex = 9;
            this.buttonDeconnexion.TabStop = false;
            this.buttonDeconnexion.UseVisualStyleBackColor = false;
            this.buttonDeconnexion.Click += new System.EventHandler(this.buttonDeconnexion_Click);
            // 
            // Interface_Abstraite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LFB_gestion.Properties.Resources.fondEcran4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 1005);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.buttonDeconnexion);
            this.Controls.Add(this.panelNomModule);
            this.Controls.Add(this.panelRecherche);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.clientsPanel);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(812, 586);
            this.Name = "Interface_Abstraite";
            this.Text = "Connexion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Interface_Abstraite_Resize);
            this.ResizeBegin += new System.EventHandler(this.Interface_Abstraite_Resize);
            this.ResizeEnd += new System.EventHandler(this.Interface_Abstraite_Resize);
            this.SizeChanged += new System.EventHandler(this.Interface_Abstraite_Resize);
            this.Resize += new System.EventHandler(this.Interface_Abstraite_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelRecherche.ResumeLayout(false);
            this.panelRecherche.PerformLayout();
            this.panelNomModule.ResumeLayout(false);
            this.panelNomModule.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label nomModuleLabel;
        protected System.Windows.Forms.TextBox rechercheTextBox;
        protected System.Windows.Forms.Panel clientsPanel;
        private System.Windows.Forms.Panel panelNomModule;

        private System.Windows.Forms.PictureBox pictureBox1;

        public System.Windows.Forms.Button ajoutBouton;
        public System.Windows.Forms.Button rechercheBouton;
        public System.Windows.Forms.Button buttonDeconnexion;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accueilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistiquesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entretienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilisateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incidentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripButton;
        public System.Windows.Forms.Button refreshButton;
        public System.Windows.Forms.Panel panelRecherche;
    }
}


