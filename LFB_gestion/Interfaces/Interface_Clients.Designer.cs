﻿
namespace LFB_gestion.Interfaces
{
    partial class Interface_Clients
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
            this.nomModuleLabel.Location = new System.Drawing.Point(3, 3);
            this.nomModuleLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            // 
            // rechercheTextBox
            // 
            this.rechercheTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // clientsPanel
            // 
            this.clientsPanel.Location = new System.Drawing.Point(148, 172);
            this.clientsPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientsPanel.Size = new System.Drawing.Size(1557, 688);
            // 
            // ajoutBouton
            // 
            this.ajoutBouton.FlatAppearance.BorderSize = 0;
            this.ajoutBouton.Click += new System.EventHandler(this.ajoutBouton_Click_1);
            // 
            // rechercheBouton
            // 
            this.rechercheBouton.FlatAppearance.BorderSize = 0;
            this.rechercheBouton.Click += new System.EventHandler(this.rechercheBouton_Click);
            // 
            // Interface_Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1854, 1012);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(614, 486);
            this.Name = "Interface_Clients";
            this.ResumeLayout(false);

        }

        #endregion
    }
}