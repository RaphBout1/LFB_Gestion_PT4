﻿namespace LFB_gestion.Formulaires
{
    partial class Form_Produit
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
            this.nomLabel = new System.Windows.Forms.Label();
            this.nomProduitTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageBouton = new System.Windows.Forms.Button();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.validerBouton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Location = new System.Drawing.Point(61, 62);
            this.nomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(113, 17);
            this.nomLabel.TabIndex = 0;
            this.nomLabel.Text = "Nom du produit :";
            // 
            // nomProduitTextBox
            // 
            this.nomProduitTextBox.Location = new System.Drawing.Point(65, 81);
            this.nomProduitTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nomProduitTextBox.Name = "nomProduitTextBox";
            this.nomProduitTextBox.Size = new System.Drawing.Size(132, 22);
            this.nomProduitTextBox.TabIndex = 1;
            this.nomProduitTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nomProduitTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Image du produit :";
            // 
            // imageBouton
            // 
            this.imageBouton.Location = new System.Drawing.Point(65, 271);
            this.imageBouton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imageBouton.Name = "imageBouton";
            this.imageBouton.Size = new System.Drawing.Size(133, 28);
            this.imageBouton.TabIndex = 4;
            this.imageBouton.Text = "Ajouter une image";
            this.imageBouton.UseVisualStyleBackColor = true;
            this.imageBouton.Click += new System.EventHandler(this.imageBouton_Click);
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.imagePictureBox.Location = new System.Drawing.Point(65, 161);
            this.imagePictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(133, 102);
            this.imagePictureBox.TabIndex = 2;
            this.imagePictureBox.TabStop = false;
            // 
            // validerBouton
            // 
            this.validerBouton.Location = new System.Drawing.Point(65, 351);
            this.validerBouton.Name = "validerBouton";
            this.validerBouton.Size = new System.Drawing.Size(132, 43);
            this.validerBouton.TabIndex = 5;
            this.validerBouton.Text = "Valider";
            this.validerBouton.UseVisualStyleBackColor = true;
            this.validerBouton.Click += new System.EventHandler(this.validerBouton_Click);
            // 
            // Form_Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 439);
            this.Controls.Add(this.validerBouton);
            this.Controls.Add(this.imageBouton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(this.nomProduitTextBox);
            this.Controls.Add(this.nomLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_Produit";
            this.Text = "Form_Produit";
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.TextBox nomProduitTextBox;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button imageBouton;
        private System.Windows.Forms.Button validerBouton;
    }
}