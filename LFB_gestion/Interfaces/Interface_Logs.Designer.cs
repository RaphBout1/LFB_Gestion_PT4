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
            // clientsPanel
            // 
            this.clientsPanel.Controls.Add(this.listBoxLog);
            this.clientsPanel.Location = new System.Drawing.Point(64, 93);
            this.clientsPanel.Size = new System.Drawing.Size(672, 372);
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
            this.buttonDeconnexion.Location = new System.Drawing.Point(590, 0);
            // 
            // listBoxLog
            // 
            this.listBoxLog.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.ItemHeight = 20;
            this.listBoxLog.Location = new System.Drawing.Point(3, 3);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(120, 80);
            this.listBoxLog.TabIndex = 0;
            // 
            // Interface_Logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Interface_Logs";
            this.Text = "Interface_Logs";
            this.clientsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxLog;
    }
}