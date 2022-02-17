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
            this.produitsListBox.Location = new System.Drawing.Point(12, 23);
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
            this.validerBouton.Location = new System.Drawing.Point(109, 194);
            this.validerBouton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.validerBouton.Name = "validerBouton";
            this.validerBouton.Size = new System.Drawing.Size(165, 32);
            this.validerBouton.TabIndex = 4;
            this.validerBouton.Text = "Valider";
            this.validerBouton.UseVisualStyleBackColor = true;
            this.validerBouton.Click += new System.EventHandler(this.validerBouton_Click);
            // 
            // Form_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 257);
            this.Controls.Add(this.validerBouton);
            this.Controls.Add(this.nouveauProduitBouton);
            this.Controls.Add(this.produitsListBox);
            this.Controls.Add(this.montantLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_Stock";
            this.Text = "Form_Stock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Label montantLabel;
        public System.Windows.Forms.ListBox produitsListBox;
        private System.Windows.Forms.Button nouveauProduitBouton;
        private System.Windows.Forms.Button validerBouton;
    }
}