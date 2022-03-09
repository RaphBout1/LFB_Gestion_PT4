namespace LFB_gestion.Formulaires
{
    partial class Form_Stock
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
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.montantLabel = new System.Windows.Forms.Label();
            this.produitsListBox = new System.Windows.Forms.ListBox();
            this.nouveauProduitBouton = new System.Windows.Forms.Button();
            this.validerBouton = new System.Windows.Forms.Button();
            this.nomLabel = new System.Windows.Forms.Label();
            this.nomProduitTextBox = new System.Windows.Forms.TextBox();
            this.ImageLabel = new System.Windows.Forms.Label();
            this.imageBouton = new System.Windows.Forms.Button();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.validerBoutonProduit = new System.Windows.Forms.Button();
            this.panelNewProduit = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.panelNewProduit.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(309, 54);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(48, 22);
            this.nombreTextBox.TabIndex = 0;
            this.nombreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreTextBox_KeyPress);
            // 
            // montantLabel
            // 
            this.montantLabel.AutoSize = true;
            this.montantLabel.Location = new System.Drawing.Point(237, 57);
            this.montantLabel.Name = "montantLabel";
            this.montantLabel.Size = new System.Drawing.Size(67, 17);
            this.montantLabel.TabIndex = 1;
            this.montantLabel.Text = "Montant :";
            // 
            // produitsListBox
            // 
            this.produitsListBox.FormattingEnabled = true;
            this.produitsListBox.ItemHeight = 16;
            this.produitsListBox.Location = new System.Drawing.Point(19, 11);
            this.produitsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.produitsListBox.Name = "produitsListBox";
            this.produitsListBox.Size = new System.Drawing.Size(207, 84);
            this.produitsListBox.TabIndex = 2;
            // 
            // nouveauProduitBouton
            // 
            this.nouveauProduitBouton.Location = new System.Drawing.Point(25, 113);
            this.nouveauProduitBouton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nouveauProduitBouton.Name = "nouveauProduitBouton";
            this.nouveauProduitBouton.Size = new System.Drawing.Size(165, 32);
            this.nouveauProduitBouton.TabIndex = 3;
            this.nouveauProduitBouton.Text = "Nouveau produit";
            this.nouveauProduitBouton.UseVisualStyleBackColor = true;
            this.nouveauProduitBouton.Click += new System.EventHandler(this.nouveauProduitBouton_Click);
            // 
            // validerBouton
            // 
            this.validerBouton.Location = new System.Drawing.Point(122, 500);
            this.validerBouton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.validerBouton.Name = "validerBouton";
            this.validerBouton.Size = new System.Drawing.Size(165, 32);
            this.validerBouton.TabIndex = 4;
            this.validerBouton.Text = "Valider";
            this.validerBouton.UseVisualStyleBackColor = true;
            this.validerBouton.Click += new System.EventHandler(this.validerBouton_Click);
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Location = new System.Drawing.Point(4, 17);
            this.nomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(113, 17);
            this.nomLabel.TabIndex = 0;
            this.nomLabel.Text = "Nom du produit :";
            // 
            // nomProduitTextBox
            // 
            this.nomProduitTextBox.Location = new System.Drawing.Point(120, 12);
            this.nomProduitTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nomProduitTextBox.Name = "nomProduitTextBox";
            this.nomProduitTextBox.Size = new System.Drawing.Size(132, 22);
            this.nomProduitTextBox.TabIndex = 1;
            this.nomProduitTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nomProduitTextBox_KeyPress);
            // 
            // ImageLabel
            // 
            this.ImageLabel.AutoSize = true;
            this.ImageLabel.Location = new System.Drawing.Point(127, 38);
            this.ImageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ImageLabel.Name = "ImageLabel";
            this.ImageLabel.Size = new System.Drawing.Size(122, 17);
            this.ImageLabel.TabIndex = 3;
            this.ImageLabel.Text = "Image du produit :";
            // 
            // imageBouton
            // 
            this.imageBouton.Location = new System.Drawing.Point(130, 211);
            this.imageBouton.Margin = new System.Windows.Forms.Padding(4);
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
            this.imagePictureBox.Location = new System.Drawing.Point(119, 77);
            this.imagePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(133, 102);
            this.imagePictureBox.TabIndex = 2;
            this.imagePictureBox.TabStop = false;
            // 
            // validerBoutonProduit
            // 
            this.validerBoutonProduit.Location = new System.Drawing.Point(130, 285);
            this.validerBoutonProduit.Name = "validerBoutonProduit";
            this.validerBoutonProduit.Size = new System.Drawing.Size(132, 43);
            this.validerBoutonProduit.TabIndex = 5;
            this.validerBoutonProduit.Text = "Valider";
            this.validerBoutonProduit.UseVisualStyleBackColor = true;
            this.validerBoutonProduit.Click += new System.EventHandler(this.validerBoutonProduit_Click);
            // 
            // panelNewProduit
            // 
            this.panelNewProduit.Controls.Add(this.validerBoutonProduit);
            this.panelNewProduit.Controls.Add(this.imageBouton);
            this.panelNewProduit.Controls.Add(this.imagePictureBox);
            this.panelNewProduit.Controls.Add(this.ImageLabel);
            this.panelNewProduit.Controls.Add(this.nomProduitTextBox);
            this.panelNewProduit.Controls.Add(this.nomLabel);
            this.panelNewProduit.Location = new System.Drawing.Point(12, 155);
            this.panelNewProduit.Name = "panelNewProduit";
            this.panelNewProduit.Size = new System.Drawing.Size(370, 331);
            this.panelNewProduit.TabIndex = 6;
            this.panelNewProduit.Visible = false;
            // 
            // Form_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 552);
            this.Controls.Add(this.panelNewProduit);
            this.Controls.Add(this.validerBouton);
            this.Controls.Add(this.nouveauProduitBouton);
            this.Controls.Add(this.produitsListBox);
            this.Controls.Add(this.montantLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Stock";
            this.Text = "Form_Stock";
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.panelNewProduit.ResumeLayout(false);
            this.panelNewProduit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Label montantLabel;
        public System.Windows.Forms.ListBox produitsListBox;
        private System.Windows.Forms.Button nouveauProduitBouton;
        private System.Windows.Forms.Button validerBouton;
        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.TextBox nomProduitTextBox;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.Label ImageLabel;
        private System.Windows.Forms.Button imageBouton;
        private System.Windows.Forms.Button validerBoutonProduit;
        private System.Windows.Forms.Panel panelNewProduit;
    }
}