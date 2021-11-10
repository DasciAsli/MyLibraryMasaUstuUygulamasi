
namespace ADMyLibraryWindowsFormsApp.Views.Home
{
    partial class AdminUserPanel
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.btnAdminPanel = new System.Windows.Forms.Button();
            this.btnUserPanel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(64, 44);
            this.btnBack.TabIndex = 52;
            this.btnBack.Text = "<<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.BackColor = System.Drawing.Color.Transparent;
            this.lblKullanici.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.ForeColor = System.Drawing.SystemColors.Window;
            this.lblKullanici.Location = new System.Drawing.Point(338, 128);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(0, 18);
            this.lblKullanici.TabIndex = 51;
            // 
            // btnAdminPanel
            // 
            this.btnAdminPanel.BackColor = System.Drawing.SystemColors.Window;
            this.btnAdminPanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdminPanel.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminPanel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnAdminPanel.Location = new System.Drawing.Point(158, 175);
            this.btnAdminPanel.Name = "btnAdminPanel";
            this.btnAdminPanel.Size = new System.Drawing.Size(167, 70);
            this.btnAdminPanel.TabIndex = 50;
            this.btnAdminPanel.Text = "Admin Panel";
            this.btnAdminPanel.UseVisualStyleBackColor = false;
            this.btnAdminPanel.Click += new System.EventHandler(this.btnAdminPanel_Click);
            // 
            // btnUserPanel
            // 
            this.btnUserPanel.BackColor = System.Drawing.SystemColors.Window;
            this.btnUserPanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUserPanel.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUserPanel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnUserPanel.Location = new System.Drawing.Point(467, 175);
            this.btnUserPanel.Name = "btnUserPanel";
            this.btnUserPanel.Size = new System.Drawing.Size(167, 70);
            this.btnUserPanel.TabIndex = 49;
            this.btnUserPanel.Text = "UserPanel";
            this.btnUserPanel.UseVisualStyleBackColor = false;
            this.btnUserPanel.Click += new System.EventHandler(this.btnUserPanel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(322, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 42);
            this.label3.TabIndex = 48;
            this.label3.Text = "LİBRARY";
            // 
            // AdminUserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(760, 406);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.btnAdminPanel);
            this.Controls.Add(this.btnUserPanel);
            this.Controls.Add(this.label3);
            this.Name = "AdminUserPanel";
            this.Text = "AdminUserPanel";
            this.Load += new System.EventHandler(this.AdminUserPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Button btnAdminPanel;
        private System.Windows.Forms.Button btnUserPanel;
        private System.Windows.Forms.Label label3;
    }
}