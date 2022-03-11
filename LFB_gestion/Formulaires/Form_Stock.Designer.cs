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
            this.nombreTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.nombreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombreTextBox.Location = new System.Drawing.Point(249, 50);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(37, 13);
            this.nombreTextBox.TabIndex = 0;
            this.nombreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreTextBox_KeyPress);
            // 
            // montantLabel
            // 
            this.montantLabel.AutoSize = true;
            this.montantLabel.BackColor = System.Drawing.Color.Transparent;
            this.montantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montantLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.montantLabel.Location = new System.Drawing.Point(185, 47);
            this.montantLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.montantLabel.Name = "montantLabel";
            this.montantLabel.Size = new System.Drawing.Size(60, 16);
            this.montantLabel.TabIndex = 1;
            this.montantLabel.Text = "Montant :";
            // 
            // produitsListBox
            // 
            this.produitsListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.produitsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.produitsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.produitsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produitsListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.produitsListBox.FormattingEnabled = true;
            this.produitsListBox.ItemHeight = 15;
            this.produitsListBox.Location = new System.Drawing.Point(14, 9);
            this.produitsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.produitsListBox.Name = "produitsListBox";
            this.produitsListBox.Size = new System.Drawing.Size(167, 90);
            this.produitsListBox.TabIndex = 2;
            // 
            // nouveauProduitBouton
            // 
            this.nouveauProduitBouton.BackColor = System.Drawing.Color.Transparent;
            this.nouveauProduitBouton.BackgroundImage = global::LFB_gestion.Properties.Resources.fondBouton;
            this.nouveauProduitBouton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nouveauProduitBouton.FlatAppearance.BorderSize = 0;
            this.nouveauProduitBouton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nouveauProduitBouton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nouveauProduitBouton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.nouveauProduitBouton.Location = new System.Drawing.Point(92, 123);
            this.nouveauProduitBouton.Margin = new System.Windows.Forms.Padding(2);
            this.nouveauProduitBouton.Name = "nouveauProduitBouton";
            this.nouveauProduitBouton.Size = new System.Drawing.Size(124, 29);
            this.nouveauProduitBouton.TabIndex = 3;
            this.nouveauProduitBouton.Text = "Nouveau produit";
            this.nouveauProduitBouton.UseVisualStyleBackColor = false;
            this.nouveauProduitBouton.Click += new System.EventHandler(this.nouveauProduitBouton_Click);
            // 
            // validerBouton
            // 
            this.validerBouton.BackColor = System.Drawing.Color.Transparent;
            this.validerBouton.BackgroundImage = global::LFB_gestion.Properties.Resources.fondBouton;
            this.validerBouton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.validerBouton.FlatAppearance.BorderSize = 0;
            this.validerBouton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.validerBouton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validerBouton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.validerBouton.Location = new System.Drawing.Point(92, 406);
            this.validerBouton.Margin = new System.Windows.Forms.Padding(2);
            this.validerBouton.Name = "validerBouton";
            this.validerBouton.Size = new System.Drawing.Size(124, 26);
            this.validerBouton.TabIndex = 4;
            this.validerBouton.Text = "Valider";
            this.validerBouton.UseVisualStyleBackColor = true;
            this.validerBouton.Click += new System.EventHandler(this.validerBouton_Click);
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.nomLabel.Location = new System.Drawing.Point(3, 14);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(104, 16);
            this.nomLabel.TabIndex = 0;
            this.nomLabel.Text = "Nom du produit :";
            // 
            // nomProduitTextBox
            // 
            this.nomProduitTextBox.Location = new System.Drawing.Point(113, 13);
            this.nomProduitTextBox.Name = "nomProduitTextBox";
            this.nomProduitTextBox.Size = new System.Drawing.Size(162, 20);
            this.nomProduitTextBox.TabIndex = 1;
            this.nomProduitTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nomProduitTextBox_KeyPress);
            // 
            // ImageLabel
            // 
            this.ImageLabel.AutoSize = true;
            this.ImageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.ImageLabel.Location = new System.Drawing.Point(3, 62);
            this.ImageLabel.Name = "ImageLabel";
            this.ImageLabel.Size = new System.Drawing.Size(113, 16);
            this.ImageLabel.TabIndex = 3;
            this.ImageLabel.Text = "Image du produit :";
            // 
            // imageBouton
            // 
            this.imageBouton.BackColor = System.Drawing.Color.Transparent;
            this.imageBouton.BackgroundImage = global::LFB_gestion.Properties.Resources.fondBouton;
            this.imageBouton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageBouton.FlatAppearance.BorderSize = 0;
            this.imageBouton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imageBouton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageBouton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.imageBouton.Location = new System.Drawing.Point(166, 132);
            this.imageBouton.Name = "imageBouton";
            this.imageBouton.Size = new System.Drawing.Size(100, 37);
            this.imageBouton.TabIndex = 4;
            this.imageBouton.Text = "Ajouter une image";
            this.imageBouton.UseVisualStyleBackColor = false;
            this.imageBouton.Click += new System.EventHandler(this.imageBouton_Click);
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.imagePictureBox.Location = new System.Drawing.Point(6, 90);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(129, 121);
            this.imagePictureBox.TabIndex = 2;
            this.imagePictureBox.TabStop = false;
            // 
            // validerBoutonProduit
            // 
            this.validerBoutonProduit.BackColor = System.Drawing.Color.Transparent;
            this.validerBoutonProduit.BackgroundImage = global::LFB_gestion.Properties.Resources.fondBouton;
            this.validerBoutonProduit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.validerBoutonProduit.FlatAppearance.BorderSize = 0;
            this.validerBoutonProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.validerBoutonProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validerBoutonProduit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.validerBoutonProduit.Location = new System.Drawing.Point(97, 232);
            this.validerBoutonProduit.Margin = new System.Windows.Forms.Padding(2);
            this.validerBoutonProduit.Name = "validerBoutonProduit";
            this.validerBoutonProduit.Size = new System.Drawing.Size(99, 35);
            this.validerBoutonProduit.TabIndex = 5;
            this.validerBoutonProduit.Text = "Ajouter";
            this.validerBoutonProduit.UseVisualStyleBackColor = true;
            this.validerBoutonProduit.Click += new System.EventHandler(this.validerBoutonProduit_Click);
            // 
            // panelNewProduit
            // 
            this.panelNewProduit.BackColor = System.Drawing.Color.Transparent;
            this.panelNewProduit.Controls.Add(this.validerBoutonProduit);
            this.panelNewProduit.Controls.Add(this.imageBouton);
            this.panelNewProduit.Controls.Add(this.imagePictureBox);
            this.panelNewProduit.Controls.Add(this.ImageLabel);
            this.panelNewProduit.Controls.Add(this.nomProduitTextBox);
            this.panelNewProduit.Controls.Add(this.nomLabel);
            this.panelNewProduit.Location = new System.Drawing.Point(11, 156);
            this.panelNewProduit.Margin = new System.Windows.Forms.Padding(2);
            this.panelNewProduit.Name = "panelNewProduit";
            this.panelNewProduit.Size = new System.Drawing.Size(278, 269);
            this.panelNewProduit.TabIndex = 6;
            this.panelNewProduit.Visible = false;
            // 
            // Form_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LFB_gestion.Properties.Resources.fondEcran;
            this.ClientSize = new System.Drawing.Size(308, 436);
            this.Controls.Add(this.panelNewProduit);
            this.Controls.Add(this.validerBouton);
            this.Controls.Add(this.nouveauProduitBouton);
            this.Controls.Add(this.produitsListBox);
            this.Controls.Add(this.montantLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Name = "Form_Stock";
            this.Text = "Gestion Stock";
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