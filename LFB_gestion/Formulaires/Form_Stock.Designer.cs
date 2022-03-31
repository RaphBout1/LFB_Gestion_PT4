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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Stock));
            this.nomLabel = new System.Windows.Forms.Label();
            this.nomProduitTextBox = new System.Windows.Forms.TextBox();
            this.ImageLabel = new System.Windows.Forms.Label();
            this.validerBoutonProduit = new System.Windows.Forms.Button();
            this.panelNewProduit = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.quantiteLabel = new System.Windows.Forms.Label();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.UrlTextBox = new System.Windows.Forms.TextBox();
            this.imageBouton = new System.Windows.Forms.Button();
            this.panelNewProduit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.nomLabel.Location = new System.Drawing.Point(3, 14);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(105, 16);
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
            this.ImageLabel.Location = new System.Drawing.Point(3, 126);
            this.ImageLabel.Name = "ImageLabel";
            this.ImageLabel.Size = new System.Drawing.Size(159, 16);
            this.ImageLabel.TabIndex = 3;
            this.ImageLabel.Text = "Url de l\'image du produit :";
            // 
            // validerBoutonProduit
            // 
            this.validerBoutonProduit.BackColor = System.Drawing.Color.Transparent;
            this.validerBoutonProduit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("validerBoutonProduit.BackgroundImage")));
            this.validerBoutonProduit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.validerBoutonProduit.FlatAppearance.BorderSize = 0;
            this.validerBoutonProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.validerBoutonProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validerBoutonProduit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.validerBoutonProduit.Location = new System.Drawing.Point(90, 377);
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
            this.panelNewProduit.Controls.Add(this.numericUpDown1);
            this.panelNewProduit.Controls.Add(this.quantiteLabel);
            this.panelNewProduit.Controls.Add(this.imageBox);
            this.panelNewProduit.Controls.Add(this.UrlTextBox);
            this.panelNewProduit.Controls.Add(this.validerBoutonProduit);
            this.panelNewProduit.Controls.Add(this.imageBouton);
            this.panelNewProduit.Controls.Add(this.ImageLabel);
            this.panelNewProduit.Controls.Add(this.nomProduitTextBox);
            this.panelNewProduit.Controls.Add(this.nomLabel);
            this.panelNewProduit.Location = new System.Drawing.Point(19, 11);
            this.panelNewProduit.Margin = new System.Windows.Forms.Padding(2);
            this.panelNewProduit.Name = "panelNewProduit";
            this.panelNewProduit.Size = new System.Drawing.Size(278, 414);
            this.panelNewProduit.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(113, 66);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 9;
            // 
            // quantiteLabel
            // 
            this.quantiteLabel.AutoSize = true;
            this.quantiteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantiteLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.quantiteLabel.Location = new System.Drawing.Point(27, 66);
            this.quantiteLabel.Name = "quantiteLabel";
            this.quantiteLabel.Size = new System.Drawing.Size(63, 16);
            this.quantiteLabel.TabIndex = 8;
            this.quantiteLabel.Text = "Quantité :";
            // 
            // imageBox
            // 
            this.imageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageBox.Location = new System.Drawing.Point(15, 171);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(154, 192);
            this.imageBox.TabIndex = 7;
            this.imageBox.TabStop = false;
            // 
            // UrlTextBox
            // 
            this.UrlTextBox.Location = new System.Drawing.Point(3, 145);
            this.UrlTextBox.Name = "UrlTextBox";
            this.UrlTextBox.Size = new System.Drawing.Size(269, 20);
            this.UrlTextBox.TabIndex = 6;
            // 
            // imageBouton
            // 
            this.imageBouton.BackColor = System.Drawing.Color.Transparent;
            this.imageBouton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imageBouton.BackgroundImage")));
            this.imageBouton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageBouton.FlatAppearance.BorderSize = 0;
            this.imageBouton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imageBouton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageBouton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.imageBouton.Location = new System.Drawing.Point(175, 243);
            this.imageBouton.Name = "imageBouton";
            this.imageBouton.Size = new System.Drawing.Size(100, 37);
            this.imageBouton.TabIndex = 4;
            this.imageBouton.Text = "Ajouter une image";
            this.imageBouton.UseVisualStyleBackColor = false;
            this.imageBouton.Click += new System.EventHandler(this.imageBouton_Click);
            // 
            // Form_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(308, 436);
            this.Controls.Add(this.panelNewProduit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Stock";
            this.Text = "Nouveau Produit";
            this.panelNewProduit.ResumeLayout(false);
            this.panelNewProduit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.TextBox nomProduitTextBox;
        private System.Windows.Forms.Label ImageLabel;
        private System.Windows.Forms.Button validerBoutonProduit;
        private System.Windows.Forms.Panel panelNewProduit;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.TextBox UrlTextBox;
        private System.Windows.Forms.Button imageBouton;
        private System.Windows.Forms.Label quantiteLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}