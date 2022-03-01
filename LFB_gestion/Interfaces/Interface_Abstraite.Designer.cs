
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
            this.nomModuleLabel = new System.Windows.Forms.Label();
            this.rechercheTextBox = new System.Windows.Forms.TextBox();
            this.ajoutBouton = new System.Windows.Forms.Button();
            this.rechercheBouton = new System.Windows.Forms.Button();
            this.clientsPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accueilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entretienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelRecherche = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelRecherche.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomModuleLabel
            // 
            this.nomModuleLabel.AutoSize = true;
            this.nomModuleLabel.BackColor = System.Drawing.Color.Transparent;
            this.nomModuleLabel.Font = new System.Drawing.Font("Barlow Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomModuleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.nomModuleLabel.Location = new System.Drawing.Point(132, 104);
            this.nomModuleLabel.Name = "nomModuleLabel";
            this.nomModuleLabel.Size = new System.Drawing.Size(199, 35);
            this.nomModuleLabel.TabIndex = 0;
            this.nomModuleLabel.Text = "Nom_Module_Label";
            // 
            // rechercheTextBox
            // 
            this.rechercheTextBox.Location = new System.Drawing.Point(38, 7);
            this.rechercheTextBox.Name = "rechercheTextBox";
            this.rechercheTextBox.Size = new System.Drawing.Size(186, 22);
            this.rechercheTextBox.TabIndex = 4;
            // 
            // ajoutBouton
            // 
            this.ajoutBouton.Location = new System.Drawing.Point(0, 7);
            this.ajoutBouton.Name = "ajoutBouton";
            this.ajoutBouton.Size = new System.Drawing.Size(32, 23);
            this.ajoutBouton.TabIndex = 2;
            this.ajoutBouton.Text = "+";
            this.ajoutBouton.UseVisualStyleBackColor = true;
            // 
            // rechercheBouton
            // 
            this.rechercheBouton.Location = new System.Drawing.Point(230, 6);
            this.rechercheBouton.Name = "rechercheBouton";
            this.rechercheBouton.Size = new System.Drawing.Size(50, 23);
            this.rechercheBouton.TabIndex = 5;
            this.rechercheBouton.Text = "Go";
            this.rechercheBouton.UseVisualStyleBackColor = true;
            // 
            // clientsPanel
            // 
            this.clientsPanel.AutoScroll = true;
            this.clientsPanel.BackColor = System.Drawing.Color.Transparent;
            this.clientsPanel.BackgroundImage = global::LFB_gestion.Properties.Resources.fondModule;
            this.clientsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clientsPanel.Location = new System.Drawing.Point(128, 140);
            this.clientsPanel.Name = "clientsPanel";
            this.clientsPanel.Size = new System.Drawing.Size(543, 382);
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
            this.utilisateursToolStripMenuItem,
            this.statistiquesToolStripMenuItem,
            this.stocksToolStripMenuItem,
            this.entretienToolStripMenuItem,
            this.planToolStripMenuItem,
            this.reservationsToolStripMenuItem,
            this.clientsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 969);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 86);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accueilToolStripMenuItem
            // 
            this.accueilToolStripMenuItem.Font = new System.Drawing.Font("Barlow Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accueilToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.accueilToolStripMenuItem.Image = global::LFB_gestion.Properties.Resources.iconeAccueil;
            this.accueilToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accueilToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.accueilToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.accueilToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.accueilToolStripMenuItem.Name = "accueilToolStripMenuItem";
            this.accueilToolStripMenuItem.Size = new System.Drawing.Size(146, 82);
            this.accueilToolStripMenuItem.Text = "Accueil";
            this.accueilToolStripMenuItem.Click += new System.EventHandler(this.accueilToolStripMenuItem_Click);
            // 
            // utilisateursToolStripMenuItem
            // 
            this.utilisateursToolStripMenuItem.Font = new System.Drawing.Font("Barlow Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilisateursToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.utilisateursToolStripMenuItem.Image = global::LFB_gestion.Properties.Resources.iconeUtilisateur;
            this.utilisateursToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.utilisateursToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.utilisateursToolStripMenuItem.Name = "utilisateursToolStripMenuItem";
            this.utilisateursToolStripMenuItem.Size = new System.Drawing.Size(184, 82);
            this.utilisateursToolStripMenuItem.Text = "Utilisateurs";
            // 
            // statistiquesToolStripMenuItem
            // 
            this.statistiquesToolStripMenuItem.Font = new System.Drawing.Font("Barlow Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statistiquesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.statistiquesToolStripMenuItem.Image = global::LFB_gestion.Properties.Resources.iconeStat;
            this.statistiquesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statistiquesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.statistiquesToolStripMenuItem.Name = "statistiquesToolStripMenuItem";
            this.statistiquesToolStripMenuItem.Size = new System.Drawing.Size(189, 82);
            this.statistiquesToolStripMenuItem.Text = "Statistiques";
            this.statistiquesToolStripMenuItem.Click += new System.EventHandler(this.statistiquesToolStripMenuItem_Click);
            // 
            // stocksToolStripMenuItem
            // 
            this.stocksToolStripMenuItem.Font = new System.Drawing.Font("Barlow Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stocksToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.stocksToolStripMenuItem.Image = global::LFB_gestion.Properties.Resources.iconeStock;
            this.stocksToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stocksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stocksToolStripMenuItem.Name = "stocksToolStripMenuItem";
            this.stocksToolStripMenuItem.ShowShortcutKeys = false;
            this.stocksToolStripMenuItem.Size = new System.Drawing.Size(130, 82);
            this.stocksToolStripMenuItem.Text = "Stock";
            this.stocksToolStripMenuItem.Click += new System.EventHandler(this.stocksToolStripMenuItem_Click);
            // 
            // entretienToolStripMenuItem
            // 
            this.entretienToolStripMenuItem.Font = new System.Drawing.Font("Barlow Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entretienToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.entretienToolStripMenuItem.Image = global::LFB_gestion.Properties.Resources.iconeEntretien;
            this.entretienToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.entretienToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.entretienToolStripMenuItem.Name = "entretienToolStripMenuItem";
            this.entretienToolStripMenuItem.Size = new System.Drawing.Size(163, 82);
            this.entretienToolStripMenuItem.Text = "Entretien";
            this.entretienToolStripMenuItem.Click += new System.EventHandler(this.entretienToolStripMenuItem_Click);
            // 
            // planToolStripMenuItem
            // 
            this.planToolStripMenuItem.Font = new System.Drawing.Font("Barlow Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.planToolStripMenuItem.Image = global::LFB_gestion.Properties.Resources.iconePlan;
            this.planToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.planToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.planToolStripMenuItem.Name = "planToolStripMenuItem";
            this.planToolStripMenuItem.Size = new System.Drawing.Size(118, 82);
            this.planToolStripMenuItem.Text = "Plan";
            this.planToolStripMenuItem.Click += new System.EventHandler(this.planToolStripMenuItem_Click);
            // 
            // reservationsToolStripMenuItem
            // 
            this.reservationsToolStripMenuItem.Font = new System.Drawing.Font("Barlow Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.reservationsToolStripMenuItem.Image = global::LFB_gestion.Properties.Resources.iconeResa;
            this.reservationsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reservationsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reservationsToolStripMenuItem.Name = "reservationsToolStripMenuItem";
            this.reservationsToolStripMenuItem.Size = new System.Drawing.Size(199, 82);
            this.reservationsToolStripMenuItem.Text = "Reservations";
            this.reservationsToolStripMenuItem.Click += new System.EventHandler(this.reservationsToolStripMenuItem_Click);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Font = new System.Drawing.Font("Barlow Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.clientsToolStripMenuItem.Image = global::LFB_gestion.Properties.Resources.iconeClients;
            this.clientsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(140, 82);
            this.clientsToolStripMenuItem.Text = "Clients";
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::LFB_gestion.Properties.Resources.logoDuHAut;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = global::LFB_gestion.Properties.Resources.logoDuHAut;
            this.pictureBox1.InitialImage = global::LFB_gestion.Properties.Resources.logoDuHAut;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 71);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panelRecherche
            // 
            this.panelRecherche.BackColor = System.Drawing.Color.Transparent;
            this.panelRecherche.Controls.Add(this.ajoutBouton);
            this.panelRecherche.Controls.Add(this.rechercheBouton);
            this.panelRecherche.Controls.Add(this.rechercheTextBox);
            this.panelRecherche.Location = new System.Drawing.Point(385, 104);
            this.panelRecherche.Name = "panelRecherche";
            this.panelRecherche.Size = new System.Drawing.Size(286, 35);
            this.panelRecherche.TabIndex = 0;
            // 
            // Interface_Abstraite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LFB_gestion.Properties.Resources.fondEcran;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panelRecherche);
            this.Controls.Add(this.nomModuleLabel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.clientsPanel);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1080, 720);
            this.Name = "Interface_Abstraite";
            this.Text = "Connexion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResizeBegin += new System.EventHandler(this.Interface_Abstraite_Resize);
            this.ResizeEnd += new System.EventHandler(this.Interface_Abstraite_Resize);
            this.SizeChanged += new System.EventHandler(this.Interface_Abstraite_Resize);
            this.Resize += new System.EventHandler(this.Interface_Abstraite_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelRecherche.ResumeLayout(false);
            this.panelRecherche.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label nomModuleLabel;
        private System.Windows.Forms.TextBox rechercheTextBox;
        private System.Windows.Forms.Button ajoutBouton;
        private System.Windows.Forms.Button rechercheBouton;
        protected System.Windows.Forms.Panel clientsPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accueilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistiquesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entretienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelRecherche;
        private System.Windows.Forms.ToolStripMenuItem utilisateursToolStripMenuItem;
    }
}