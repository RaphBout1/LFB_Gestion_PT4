
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
            this.panelGeneralGroupBox = new System.Windows.Forms.GroupBox();
            this.boutonPlan = new System.Windows.Forms.Button();
            this.boutonClients = new System.Windows.Forms.Button();
            this.boutonStocks = new System.Windows.Forms.Button();
            this.boutonAccueil = new System.Windows.Forms.Button();
            this.entitesListBox = new System.Windows.Forms.ListBox();
            this.monCompteGroupBox = new System.Windows.Forms.GroupBox();
            this.deconnexionBouton = new System.Windows.Forms.Button();
            this.nomUtilisateurLabel = new System.Windows.Forms.Label();
            this.rechercheTextBox = new System.Windows.Forms.TextBox();
            this.ajoutBouton = new System.Windows.Forms.Button();
            this.rechercheBouton = new System.Windows.Forms.Button();
            this.panelGeneralGroupBox.SuspendLayout();
            this.monCompteGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomModuleLabel
            // 
            this.nomModuleLabel.AutoSize = true;
            this.nomModuleLabel.Location = new System.Drawing.Point(257, 60);
            this.nomModuleLabel.Name = "nomModuleLabel";
            this.nomModuleLabel.Size = new System.Drawing.Size(134, 17);
            this.nomModuleLabel.TabIndex = 0;
            this.nomModuleLabel.Text = "Nom_Module_Label";
            // 
            // panelGeneralGroupBox
            // 
            this.panelGeneralGroupBox.Controls.Add(this.boutonPlan);
            this.panelGeneralGroupBox.Controls.Add(this.boutonClients);
            this.panelGeneralGroupBox.Controls.Add(this.boutonStocks);
            this.panelGeneralGroupBox.Controls.Add(this.boutonAccueil);
            this.panelGeneralGroupBox.Location = new System.Drawing.Point(12, 12);
            this.panelGeneralGroupBox.Name = "panelGeneralGroupBox";
            this.panelGeneralGroupBox.Size = new System.Drawing.Size(210, 539);
            this.panelGeneralGroupBox.TabIndex = 1;
            this.panelGeneralGroupBox.TabStop = false;
            this.panelGeneralGroupBox.Text = "Les flots blancs";
            // 
            // boutonPlan
            // 
            this.boutonPlan.Location = new System.Drawing.Point(6, 247);
            this.boutonPlan.Margin = new System.Windows.Forms.Padding(4);
            this.boutonPlan.Name = "boutonPlan";
            this.boutonPlan.Size = new System.Drawing.Size(100, 28);
            this.boutonPlan.TabIndex = 5;
            this.boutonPlan.Text = "Plan";
            this.boutonPlan.UseVisualStyleBackColor = true;
            // 
            // boutonClients
            // 
            this.boutonClients.Location = new System.Drawing.Point(6, 191);
            this.boutonClients.Margin = new System.Windows.Forms.Padding(4);
            this.boutonClients.Name = "boutonClients";
            this.boutonClients.Size = new System.Drawing.Size(100, 28);
            this.boutonClients.TabIndex = 4;
            this.boutonClients.Text = "Clients";
            this.boutonClients.UseVisualStyleBackColor = true;
            // 
            // boutonStocks
            // 
            this.boutonStocks.Location = new System.Drawing.Point(6, 134);
            this.boutonStocks.Margin = new System.Windows.Forms.Padding(4);
            this.boutonStocks.Name = "boutonStocks";
            this.boutonStocks.Size = new System.Drawing.Size(100, 28);
            this.boutonStocks.TabIndex = 3;
            this.boutonStocks.Text = "Stocks";
            this.boutonStocks.UseVisualStyleBackColor = true;
            // 
            // boutonAccueil
            // 
            this.boutonAccueil.Location = new System.Drawing.Point(6, 79);
            this.boutonAccueil.Name = "boutonAccueil";
            this.boutonAccueil.Size = new System.Drawing.Size(100, 28);
            this.boutonAccueil.TabIndex = 0;
            this.boutonAccueil.Text = "Accueil";
            this.boutonAccueil.UseVisualStyleBackColor = true;
            // 
            // entitesListBox
            // 
            this.entitesListBox.FormattingEnabled = true;
            this.entitesListBox.ItemHeight = 16;
            this.entitesListBox.Location = new System.Drawing.Point(260, 91);
            this.entitesListBox.Name = "entitesListBox";
            this.entitesListBox.Size = new System.Drawing.Size(543, 372);
            this.entitesListBox.TabIndex = 2;
            // 
            // monCompteGroupBox
            // 
            this.monCompteGroupBox.Controls.Add(this.deconnexionBouton);
            this.monCompteGroupBox.Controls.Add(this.nomUtilisateurLabel);
            this.monCompteGroupBox.Location = new System.Drawing.Point(824, 12);
            this.monCompteGroupBox.Name = "monCompteGroupBox";
            this.monCompteGroupBox.Size = new System.Drawing.Size(231, 539);
            this.monCompteGroupBox.TabIndex = 3;
            this.monCompteGroupBox.TabStop = false;
            this.monCompteGroupBox.Text = "Mon compte";
            // 
            // deconnexionBouton
            // 
            this.deconnexionBouton.Location = new System.Drawing.Point(66, 483);
            this.deconnexionBouton.Name = "deconnexionBouton";
            this.deconnexionBouton.Size = new System.Drawing.Size(104, 36);
            this.deconnexionBouton.TabIndex = 1;
            this.deconnexionBouton.Text = "Déconnexion";
            this.deconnexionBouton.UseVisualStyleBackColor = true;
            // 
            // nomUtilisateurLabel
            // 
            this.nomUtilisateurLabel.AutoSize = true;
            this.nomUtilisateurLabel.Location = new System.Drawing.Point(6, 34);
            this.nomUtilisateurLabel.Name = "nomUtilisateurLabel";
            this.nomUtilisateurLabel.Size = new System.Drawing.Size(90, 17);
            this.nomUtilisateurLabel.TabIndex = 0;
            this.nomUtilisateurLabel.Text = "Nom Prénom";
            // 
            // rechercheTextBox
            // 
            this.rechercheTextBox.Location = new System.Drawing.Point(617, 63);
            this.rechercheTextBox.Name = "rechercheTextBox";
            this.rechercheTextBox.Size = new System.Drawing.Size(186, 22);
            this.rechercheTextBox.TabIndex = 4;
            // 
            // ajoutBouton
            // 
            this.ajoutBouton.Location = new System.Drawing.Point(579, 63);
            this.ajoutBouton.Name = "ajoutBouton";
            this.ajoutBouton.Size = new System.Drawing.Size(32, 23);
            this.ajoutBouton.TabIndex = 2;
            this.ajoutBouton.Text = "+";
            this.ajoutBouton.UseVisualStyleBackColor = true;
            // 
            // rechercheBouton
            // 
            this.rechercheBouton.Location = new System.Drawing.Point(753, 62);
            this.rechercheBouton.Name = "rechercheBouton";
            this.rechercheBouton.Size = new System.Drawing.Size(50, 23);
            this.rechercheBouton.TabIndex = 5;
            this.rechercheBouton.Text = "Go";
            this.rechercheBouton.UseVisualStyleBackColor = true;
            // 
            // Interface_Abstraite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.rechercheBouton);
            this.Controls.Add(this.ajoutBouton);
            this.Controls.Add(this.rechercheTextBox);
            this.Controls.Add(this.monCompteGroupBox);
            this.Controls.Add(this.entitesListBox);
            this.Controls.Add(this.panelGeneralGroupBox);
            this.Controls.Add(this.nomModuleLabel);
            this.Name = "Interface_Abstraite";
            this.Text = "Form1";
            this.panelGeneralGroupBox.ResumeLayout(false);
            this.monCompteGroupBox.ResumeLayout(false);
            this.monCompteGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label nomModuleLabel;
        private System.Windows.Forms.GroupBox panelGeneralGroupBox;
        private System.Windows.Forms.Button boutonAccueil;
        private System.Windows.Forms.Button boutonStocks;
        private System.Windows.Forms.Button boutonClients;
        private System.Windows.Forms.Button boutonPlan;
        protected System.Windows.Forms.ListBox entitesListBox;
        private System.Windows.Forms.GroupBox monCompteGroupBox;
        private System.Windows.Forms.Label nomUtilisateurLabel;
        private System.Windows.Forms.Button deconnexionBouton;
        private System.Windows.Forms.TextBox rechercheTextBox;
        private System.Windows.Forms.Button ajoutBouton;
        private System.Windows.Forms.Button rechercheBouton;
    }
}