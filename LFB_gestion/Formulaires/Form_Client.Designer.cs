namespace LFB_gestion.Formulaires
{
    partial class Form_Client
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
            this.creerBouton = new System.Windows.Forms.Button();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.nomLabel = new System.Windows.Forms.Label();
            this.prenomLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // creerBouton
            // 
            this.creerBouton.Location = new System.Drawing.Point(199, 319);
            this.creerBouton.Margin = new System.Windows.Forms.Padding(4);
            this.creerBouton.Name = "creerBouton";
            this.creerBouton.Size = new System.Drawing.Size(100, 28);
            this.creerBouton.TabIndex = 7;
            this.creerBouton.Text = "Créer";
            this.creerBouton.UseVisualStyleBackColor = true;
            this.creerBouton.Click += new System.EventHandler(this.creerBouton_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(180, 240);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(132, 22);
            this.emailTextBox.TabIndex = 6;
            this.emailTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.emailTextBox_KeyPress);
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.Location = new System.Drawing.Point(180, 178);
            this.prenomTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(132, 22);
            this.prenomTextBox.TabIndex = 5;
            this.prenomTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.prenomTextBox_KeyPress);
            // 
            // nomTextBox
            // 
            this.nomTextBox.Location = new System.Drawing.Point(180, 112);
            this.nomTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(132, 22);
            this.nomTextBox.TabIndex = 4;
            this.nomTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nomTextBox_KeyPress);
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Location = new System.Drawing.Point(177, 91);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(45, 17);
            this.nomLabel.TabIndex = 8;
            this.nomLabel.Text = "Nom :";
            // 
            // prenomLabel
            // 
            this.prenomLabel.AutoSize = true;
            this.prenomLabel.Location = new System.Drawing.Point(177, 157);
            this.prenomLabel.Name = "prenomLabel";
            this.prenomLabel.Size = new System.Drawing.Size(65, 17);
            this.prenomLabel.TabIndex = 9;
            this.prenomLabel.Text = "Prénom :";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(177, 219);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(97, 17);
            this.emailLabel.TabIndex = 10;
            this.emailLabel.Text = "Adresse mail :";
            // 
            // Form_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 524);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.prenomLabel);
            this.Controls.Add(this.nomLabel);
            this.Controls.Add(this.creerBouton);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.prenomTextBox);
            this.Controls.Add(this.nomTextBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Client";
            this.Text = "Form_Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button creerBouton;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox prenomTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.Label prenomLabel;
        private System.Windows.Forms.Label emailLabel;
    }
}