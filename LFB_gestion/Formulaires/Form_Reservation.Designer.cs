namespace LFB_gestion.Formulaires
{
    partial class Form_Reservation
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
            this.clientsListBox = new System.Windows.Forms.ListBox();
            this.emplacementsListBox = new System.Windows.Forms.ListBox();
            this.emplacementLabel = new System.Windows.Forms.Label();
            this.clientLabel = new System.Windows.Forms.Label();
            this.dateDebutCalendrier = new System.Windows.Forms.MonthCalendar();
            this.dateFinCalendrier = new System.Windows.Forms.MonthCalendar();
            this.dateDebutLabel = new System.Windows.Forms.Label();
            this.dateFinLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.validerBouton = new System.Windows.Forms.Button();
            this.nouveauClientBouton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clientsListBox
            // 
            this.clientsListBox.FormattingEnabled = true;
            this.clientsListBox.ItemHeight = 16;
            this.clientsListBox.Location = new System.Drawing.Point(76, 355);
            this.clientsListBox.Name = "clientsListBox";
            this.clientsListBox.Size = new System.Drawing.Size(312, 68);
            this.clientsListBox.TabIndex = 8;
            // 
            // emplacementsListBox
            // 
            this.emplacementsListBox.FormattingEnabled = true;
            this.emplacementsListBox.ItemHeight = 16;
            this.emplacementsListBox.Location = new System.Drawing.Point(76, 471);
            this.emplacementsListBox.Name = "emplacementsListBox";
            this.emplacementsListBox.Size = new System.Drawing.Size(312, 68);
            this.emplacementsListBox.TabIndex = 9;
            // 
            // emplacementLabel
            // 
            this.emplacementLabel.AutoSize = true;
            this.emplacementLabel.Location = new System.Drawing.Point(73, 451);
            this.emplacementLabel.Name = "emplacementLabel";
            this.emplacementLabel.Size = new System.Drawing.Size(101, 17);
            this.emplacementLabel.TabIndex = 10;
            this.emplacementLabel.Text = "Emplacement :";
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Location = new System.Drawing.Point(73, 335);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(51, 17);
            this.clientLabel.TabIndex = 11;
            this.clientLabel.Text = "Client :";
            // 
            // dateDebutCalendrier
            // 
            this.dateDebutCalendrier.Location = new System.Drawing.Point(34, 78);
            this.dateDebutCalendrier.Name = "dateDebutCalendrier";
            this.dateDebutCalendrier.TabIndex = 12;
            // 
            // dateFinCalendrier
            // 
            this.dateFinCalendrier.Location = new System.Drawing.Point(354, 78);
            this.dateFinCalendrier.Name = "dateFinCalendrier";
            this.dateFinCalendrier.TabIndex = 13;
            // 
            // dateDebutLabel
            // 
            this.dateDebutLabel.AutoSize = true;
            this.dateDebutLabel.Location = new System.Drawing.Point(31, 33);
            this.dateDebutLabel.Name = "dateDebutLabel";
            this.dateDebutLabel.Size = new System.Drawing.Size(106, 17);
            this.dateDebutLabel.TabIndex = 14;
            this.dateDebutLabel.Text = "Date de début :";
            // 
            // dateFinLabel
            // 
            this.dateFinLabel.AutoSize = true;
            this.dateFinLabel.Location = new System.Drawing.Point(351, 33);
            this.dateFinLabel.Name = "dateFinLabel";
            this.dateFinLabel.Size = new System.Drawing.Size(85, 17);
            this.dateFinLabel.TabIndex = 15;
            this.dateFinLabel.Text = "Date de fin :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // validerBouton
            // 
            this.validerBouton.Location = new System.Drawing.Point(226, 614);
            this.validerBouton.Name = "validerBouton";
            this.validerBouton.Size = new System.Drawing.Size(152, 56);
            this.validerBouton.TabIndex = 17;
            this.validerBouton.Text = "Valider";
            this.validerBouton.UseVisualStyleBackColor = true;
            // 
            // nouveauClientBouton
            // 
            this.nouveauClientBouton.Location = new System.Drawing.Point(415, 375);
            this.nouveauClientBouton.Name = "nouveauClientBouton";
            this.nouveauClientBouton.Size = new System.Drawing.Size(143, 33);
            this.nouveauClientBouton.TabIndex = 18;
            this.nouveauClientBouton.Text = "NouveauClient";
            this.nouveauClientBouton.UseVisualStyleBackColor = true;
            this.nouveauClientBouton.Click += new System.EventHandler(this.nouveauClientBouton_Click);
            // 
            // Form_Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 750);
            this.Controls.Add(this.nouveauClientBouton);
            this.Controls.Add(this.validerBouton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateFinLabel);
            this.Controls.Add(this.dateDebutLabel);
            this.Controls.Add(this.dateFinCalendrier);
            this.Controls.Add(this.dateDebutCalendrier);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.emplacementLabel);
            this.Controls.Add(this.emplacementsListBox);
            this.Controls.Add(this.clientsListBox);
            this.Name = "Form_Reservation";
            this.Text = "Form_Reservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox clientsListBox;
        private System.Windows.Forms.ListBox emplacementsListBox;
        private System.Windows.Forms.Label emplacementLabel;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.MonthCalendar dateDebutCalendrier;
        private System.Windows.Forms.MonthCalendar dateFinCalendrier;
        private System.Windows.Forms.Label dateDebutLabel;
        private System.Windows.Forms.Label dateFinLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button validerBouton;
        private System.Windows.Forms.Button nouveauClientBouton;
    }
}