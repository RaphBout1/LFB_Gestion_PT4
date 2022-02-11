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
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.creerBouton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nomTextBox
            // 
            this.nomTextBox.Location = new System.Drawing.Point(211, 103);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomTextBox.TabIndex = 0;
            this.nomTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nomTextBox_KeyPress);
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.Location = new System.Drawing.Point(211, 157);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(100, 20);
            this.prenomTextBox.TabIndex = 1;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(211, 207);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 2;
            // 
            // creerBouton
            // 
            this.creerBouton.Location = new System.Drawing.Point(225, 271);
            this.creerBouton.Name = "creerBouton";
            this.creerBouton.Size = new System.Drawing.Size(75, 23);
            this.creerBouton.TabIndex = 3;
            this.creerBouton.Text = "Créer";
            this.creerBouton.UseVisualStyleBackColor = true;
            // 
            // Form_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 433);
            this.Controls.Add(this.creerBouton);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.prenomTextBox);
            this.Controls.Add(this.nomTextBox);
            this.Name = "Form_Stock";
            this.Text = "Form_Stock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox prenomTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button creerBouton;
    }
}