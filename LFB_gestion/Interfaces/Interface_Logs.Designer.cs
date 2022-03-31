namespace LFB_gestion.Interfaces
{
    partial class Interface_Logs
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
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.clientsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // rechercheTextBox
            // 
            this.rechercheTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // clientsPanel
            // 
            this.clientsPanel.Controls.Add(this.listBoxLog);
            this.clientsPanel.Location = new System.Drawing.Point(204, 220);
            this.clientsPanel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.clientsPanel.Size = new System.Drawing.Size(2155, 882);
            // 
            // ajoutBouton
            // 
            this.ajoutBouton.FlatAppearance.BorderSize = 0;
            // 
            // rechercheBouton
            // 
            this.rechercheBouton.FlatAppearance.BorderSize = 0;
            // 
            // buttonDeconnexion
            // 
            this.buttonDeconnexion.FlatAppearance.BorderSize = 0;
            this.buttonDeconnexion.Location = new System.Drawing.Point(2285, 0);
            this.buttonDeconnexion.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // refreshButton
            // 
            this.refreshButton.FlatAppearance.BorderSize = 0;
            this.refreshButton.Location = new System.Drawing.Point(1220, 159);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // listBoxLog
            // 
            this.listBoxLog.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.ItemHeight = 25;
            this.listBoxLog.Location = new System.Drawing.Point(0, 30);
            this.listBoxLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(1093, 75);
            this.listBoxLog.TabIndex = 0;
            // 
            // Interface_Logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MinimumSize = new System.Drawing.Size(1430, 865);
            this.Name = "Interface_Logs";
            this.Text = "Logs";
            this.clientsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxLog;
    }
}