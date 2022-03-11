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
            this.calendrier = new System.Windows.Forms.MonthCalendar();
            this.dateDebutLabel = new System.Windows.Forms.Label();
            this.validerBouton = new System.Windows.Forms.Button();
            this.nouveauClientBouton = new System.Windows.Forms.Button();
            this.infoDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clientsListBox
            // 
            this.clientsListBox.FormattingEnabled = true;
            this.clientsListBox.Location = new System.Drawing.Point(57, 267);
            this.clientsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.clientsListBox.Name = "clientsListBox";
            this.clientsListBox.Size = new System.Drawing.Size(227, 56);
            this.clientsListBox.TabIndex = 8;
            // 
            // emplacementsListBox
            // 
            this.emplacementsListBox.FormattingEnabled = true;
            this.emplacementsListBox.Location = new System.Drawing.Point(58, 371);
            this.emplacementsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.emplacementsListBox.Name = "emplacementsListBox";
            this.emplacementsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.emplacementsListBox.Size = new System.Drawing.Size(226, 56);
            this.emplacementsListBox.TabIndex = 9;
            // 
            // emplacementLabel
            // 
            this.emplacementLabel.AutoSize = true;
            this.emplacementLabel.BackColor = System.Drawing.Color.Transparent;
            this.emplacementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emplacementLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.emplacementLabel.Location = new System.Drawing.Point(54, 346);
            this.emplacementLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emplacementLabel.Name = "emplacementLabel";
            this.emplacementLabel.Size = new System.Drawing.Size(115, 20);
            this.emplacementLabel.TabIndex = 10;
            this.emplacementLabel.Text = "Emplacement :";
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.BackColor = System.Drawing.Color.Transparent;
            this.clientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.clientLabel.Location = new System.Drawing.Point(53, 245);
            this.clientLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(57, 20);
            this.clientLabel.TabIndex = 11;
            this.clientLabel.Text = "Client :";
            // 
            // calendrier
            // 
            this.calendrier.Location = new System.Drawing.Point(57, 52);
            this.calendrier.Margin = new System.Windows.Forms.Padding(7);
            this.calendrier.MaxSelectionCount = 365;
            this.calendrier.Name = "calendrier";
            this.calendrier.TabIndex = 12;
            this.calendrier.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendrier_DateChanged);
            // 
            // dateDebutLabel
            // 
            this.dateDebutLabel.AutoSize = true;
            this.dateDebutLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateDebutLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dateDebutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDebutLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.dateDebutLabel.Location = new System.Drawing.Point(54, 25);
            this.dateDebutLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateDebutLabel.Name = "dateDebutLabel";
            this.dateDebutLabel.Size = new System.Drawing.Size(174, 20);
            this.dateDebutLabel.TabIndex = 14;
            this.dateDebutLabel.Text = "Sélectionner les dates :";
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
            this.validerBouton.Location = new System.Drawing.Point(107, 451);
            this.validerBouton.Margin = new System.Windows.Forms.Padding(2);
            this.validerBouton.Name = "validerBouton";
            this.validerBouton.Size = new System.Drawing.Size(114, 46);
            this.validerBouton.TabIndex = 17;
            this.validerBouton.Text = "Valider";
            this.validerBouton.UseVisualStyleBackColor = true;
            this.validerBouton.Click += new System.EventHandler(this.validerBouton_Click);
            // 
            // nouveauClientBouton
            // 
            this.nouveauClientBouton.BackColor = System.Drawing.Color.Transparent;
            this.nouveauClientBouton.BackgroundImage = global::LFB_gestion.Properties.Resources.fondBouton;
            this.nouveauClientBouton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nouveauClientBouton.FlatAppearance.BorderSize = 0;
            this.nouveauClientBouton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nouveauClientBouton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nouveauClientBouton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.nouveauClientBouton.Location = new System.Drawing.Point(177, 235);
            this.nouveauClientBouton.Margin = new System.Windows.Forms.Padding(2);
            this.nouveauClientBouton.Name = "nouveauClientBouton";
            this.nouveauClientBouton.Size = new System.Drawing.Size(107, 28);
            this.nouveauClientBouton.TabIndex = 18;
            this.nouveauClientBouton.Text = "Nouveau client";
            this.nouveauClientBouton.UseVisualStyleBackColor = true;
            this.nouveauClientBouton.Click += new System.EventHandler(this.nouveauClientBouton_Click);
            // 
            // infoDate
            // 
            this.infoDate.BackColor = System.Drawing.Color.Transparent;
            this.infoDate.BackgroundImage = global::LFB_gestion.Properties.Resources.fondBouton;
            this.infoDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.infoDate.FlatAppearance.BorderSize = 0;
            this.infoDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.infoDate.Location = new System.Drawing.Point(233, 22);
            this.infoDate.Name = "infoDate";
            this.infoDate.Size = new System.Drawing.Size(25, 23);
            this.infoDate.TabIndex = 19;
            this.infoDate.Text = "button1";
            this.infoDate.UseVisualStyleBackColor = true;
            this.infoDate.Click += new System.EventHandler(this.infoDate_Click);
            // 
            // Form_Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LFB_gestion.Properties.Resources.fondEcran;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(341, 544);
            this.Controls.Add(this.infoDate);
            this.Controls.Add(this.nouveauClientBouton);
            this.Controls.Add(this.validerBouton);
            this.Controls.Add(this.dateDebutLabel);
            this.Controls.Add(this.calendrier);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.emplacementLabel);
            this.Controls.Add(this.emplacementsListBox);
            this.Controls.Add(this.clientsListBox);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Reservation";
            this.Text = "Nouvelle réservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox clientsListBox;
        private System.Windows.Forms.ListBox emplacementsListBox;
        private System.Windows.Forms.Label emplacementLabel;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.MonthCalendar calendrier;
        private System.Windows.Forms.Label dateDebutLabel;
        private System.Windows.Forms.Button validerBouton;
        private System.Windows.Forms.Button nouveauClientBouton;
        private System.Windows.Forms.Button infoDate;
    }
}