namespace LFB_gestion.Interfaces
{
    partial class Interface_Entretien
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
            // clientsPanel
            // 
            this.clientsPanel.Location = new System.Drawing.Point(148, 172);
            this.clientsPanel.Size = new System.Drawing.Size(1557, 688);
            // 
            // ajoutBouton
            // 
            this.ajoutBouton.FlatAppearance.BorderSize = 0;
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
            this.buttonDeconnexion.Location = new System.Drawing.Point(1644, 0);
            // 
            // refreshButton
            // 
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // Interface_Entretien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1854, 1012);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Interface_Entretien";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
    }
}