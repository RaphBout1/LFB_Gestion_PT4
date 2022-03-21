
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
            this.label1 = new System.Windows.Forms.Label();
            this.plusGrosConsoLabel = new System.Windows.Forms.Label();
            this.clientsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomModuleLabel
            // 
            this.nomModuleLabel.Location = new System.Drawing.Point(220, 20);
            // 
            // clientsPanel
            // 
            this.clientsPanel.Controls.Add(this.plusGrosConsoLabel);
            this.clientsPanel.Controls.Add(this.label1);
            this.clientsPanel.Location = new System.Drawing.Point(64, 94);
            this.clientsPanel.Size = new System.Drawing.Size(672, 376);
            // 
            // ajoutBouton
            // 
            this.ajoutBouton.FlatAppearance.BorderSize = 0;
            // 
            // rechercheBouton
            // 
            this.rechercheBouton.FlatAppearance.BorderSize = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Le plus gros consomateur";
            // 
            // plusGrosConsoLabel
            // 
            this.plusGrosConsoLabel.AutoSize = true;
            this.plusGrosConsoLabel.Location = new System.Drawing.Point(247, 66);
            this.plusGrosConsoLabel.Name = "plusGrosConsoLabel";
            this.plusGrosConsoLabel.Size = new System.Drawing.Size(72, 13);
            this.plusGrosConsoLabel.TabIndex = 10;
            this.plusGrosConsoLabel.Text = "Nom du client";
            // 
            // Interface_Statistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Interface_Statistiques";
            this.Text = "Interface_Statistiques";
            this.clientsPanel.ResumeLayout(false);
            this.clientsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label plusGrosConsoLabel;
    }
}