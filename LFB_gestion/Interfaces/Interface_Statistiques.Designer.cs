
namespace LFB_gestion.Interfaces
{
    partial class Interface_Statistiques
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
            this.panelRecherche.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomModuleLabel
            // 
            this.nomModuleLabel.Location = new System.Drawing.Point(3, 4);
            this.nomModuleLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            // 
            // rechercheTextBox
            // 
            this.rechercheTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // clientsPanel
            // 
            this.clientsPanel.Location = new System.Drawing.Point(152, 176);
            this.clientsPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientsPanel.Size = new System.Drawing.Size(1599, 707);
            // 
            // ajoutBouton
            // 
            this.ajoutBouton.FlatAppearance.BorderSize = 0;
            // 
            // rechercheBouton
            // 
            this.rechercheBouton.FlatAppearance.BorderSize = 0;
            // 
            // buttonDeconnexion
            // 
            this.buttonDeconnexion.FlatAppearance.BorderSize = 0;
            this.buttonDeconnexion.Location = new System.Drawing.Point(1694, 0);
            this.buttonDeconnexion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // refreshButton
            // 
            this.refreshButton.FlatAppearance.BorderSize = 0;
            this.refreshButton.Location = new System.Drawing.Point(917, 126);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(4);
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // panelRecherche
            // 
            this.panelRecherche.Location = new System.Drawing.Point(1404, 132);
            // 
            // Interface_Statistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1076, 710);
            this.Name = "Interface_Statistiques";
            this.Text = "Statistiques";
            this.panelRecherche.ResumeLayout(false);
            this.panelRecherche.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}