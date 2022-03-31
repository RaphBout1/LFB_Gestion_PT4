
namespace LFB_gestion.Interfaces
{
    partial class Interface_Reservations
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
            this.SuspendLayout();
            // 
            // nomModuleLabel
            // 
            this.nomModuleLabel.TabIndex = 1;
            // 
            // rechercheTextBox
            // 
            this.rechercheTextBox.ForeColor = System.Drawing.Color.Gray;
            this.rechercheTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rechercheTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rechercheTextBox_KeyDown);
            // 
            // clientsPanel
            // 
            this.clientsPanel.Location = new System.Drawing.Point(204, 220);
            this.clientsPanel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.clientsPanel.Size = new System.Drawing.Size(2155, 882);
            // 
            // ajoutBouton
            // 
            this.ajoutBouton.FlatAppearance.BorderSize = 0;
            this.ajoutBouton.TabIndex = 2;
            this.ajoutBouton.Click += new System.EventHandler(this.ajoutBouton_Click);
            // 
            // rechercheBouton
            // 
            this.rechercheBouton.FlatAppearance.BorderSize = 0;
            this.rechercheBouton.Click += new System.EventHandler(this.rechercheBouton_Click);
            // 
            // buttonDeconnexion
            // 
            this.buttonDeconnexion.FlatAppearance.BorderSize = 0;
            this.buttonDeconnexion.Location = new System.Drawing.Point(2285, 0);
            this.buttonDeconnexion.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // refreshButton
            // 
            this.refreshButton.FlatAppearance.BorderSize = 0;
            this.refreshButton.Location = new System.Drawing.Point(1220, 159);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // Interface_Reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MinimumSize = new System.Drawing.Size(813, 589);
            this.Name = "Interface_Reservations";
            this.Text = "Reservations";
            this.Load += new System.EventHandler(this.Interface_Reservations_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}