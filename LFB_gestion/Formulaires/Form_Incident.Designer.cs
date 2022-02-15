namespace LFB_gestion.Formulaires
{
    partial class Form_Incident
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
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.statutCheckBox = new System.Windows.Forms.CheckBox();
            this.clientLabel = new System.Windows.Forms.Label();
            this.emplacementLabel = new System.Windows.Forms.Label();
            this.validationBouton = new System.Windows.Forms.Button();
            this.clientsListBox = new System.Windows.Forms.ListBox();
            this.emplacementsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(58, 40);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(235, 79);
            this.descriptionTextBox.TabIndex = 0;
            this.descriptionTextBox.Text = "";
            // 
            // statutCheckBox
            // 
            this.statutCheckBox.AutoSize = true;
            this.statutCheckBox.Location = new System.Drawing.Point(58, 135);
            this.statutCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statutCheckBox.Name = "statutCheckBox";
            this.statutCheckBox.Size = new System.Drawing.Size(59, 17);
            this.statutCheckBox.TabIndex = 1;
            this.statutCheckBox.Text = "Résolu";
            this.statutCheckBox.UseVisualStyleBackColor = true;
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Location = new System.Drawing.Point(56, 167);
            this.clientLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(39, 13);
            this.clientLabel.TabIndex = 3;
            this.clientLabel.Text = "Client :";
            // 
            // emplacementLabel
            // 
            this.emplacementLabel.AutoSize = true;
            this.emplacementLabel.Location = new System.Drawing.Point(56, 242);
            this.emplacementLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emplacementLabel.Name = "emplacementLabel";
            this.emplacementLabel.Size = new System.Drawing.Size(77, 13);
            this.emplacementLabel.TabIndex = 5;
            this.emplacementLabel.Text = "Emplacement :";
            // 
            // validationBouton
            // 
            this.validationBouton.Location = new System.Drawing.Point(133, 322);
            this.validationBouton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.validationBouton.Name = "validationBouton";
            this.validationBouton.Size = new System.Drawing.Size(72, 34);
            this.validationBouton.TabIndex = 6;
            this.validationBouton.Text = "Valider";
            this.validationBouton.UseVisualStyleBackColor = true;
            this.validationBouton.Click += new System.EventHandler(this.validationBouton_Click);
            // 
            // clientsListBox
            // 
            this.clientsListBox.FormattingEnabled = true;
            this.clientsListBox.Location = new System.Drawing.Point(58, 183);
            this.clientsListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clientsListBox.Name = "clientsListBox";
            this.clientsListBox.Size = new System.Drawing.Size(235, 56);
            this.clientsListBox.TabIndex = 7;
            // 
            // emplacementsListBox
            // 
            this.emplacementsListBox.FormattingEnabled = true;
            this.emplacementsListBox.Location = new System.Drawing.Point(58, 262);
            this.emplacementsListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emplacementsListBox.Name = "emplacementsListBox";
            this.emplacementsListBox.Size = new System.Drawing.Size(235, 56);
            this.emplacementsListBox.TabIndex = 8;
            // 
            // Form_Incident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 366);
            this.Controls.Add(this.emplacementsListBox);
            this.Controls.Add(this.clientsListBox);
            this.Controls.Add(this.validationBouton);
            this.Controls.Add(this.emplacementLabel);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.statutCheckBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_Incident";
            this.Text = "Form_Incident";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.CheckBox statutCheckBox;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.Label emplacementLabel;
        private System.Windows.Forms.Button validationBouton;
        private System.Windows.Forms.ListBox clientsListBox;
        private System.Windows.Forms.ListBox emplacementsListBox;
    }
}