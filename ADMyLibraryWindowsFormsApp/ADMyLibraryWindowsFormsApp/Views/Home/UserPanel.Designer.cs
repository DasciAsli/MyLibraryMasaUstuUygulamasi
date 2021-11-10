
namespace ADMyLibraryWindowsFormsApp.Views.Home
{
    partial class UserPanel
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
            this.lblKullanici = new System.Windows.Forms.Label();
            this.btnFineList = new System.Windows.Forms.Button();
            this.btnOperations = new System.Windows.Forms.Button();
            this.btnBookList = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.BackColor = System.Drawing.Color.Transparent;
            this.lblKullanici.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.ForeColor = System.Drawing.SystemColors.Window;
            this.lblKullanici.Location = new System.Drawing.Point(338, 133);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(0, 18);
            this.lblKullanici.TabIndex = 50;
            // 
            // btnFineList
            // 
            this.btnFineList.BackColor = System.Drawing.SystemColors.Window;
            this.btnFineList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFineList.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFineList.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnFineList.Location = new System.Drawing.Point(316, 300);
            this.btnFineList.Name = "btnFineList";
            this.btnFineList.Size = new System.Drawing.Size(167, 70);
            this.btnFineList.TabIndex = 49;
            this.btnFineList.Text = "Fine List";
            this.btnFineList.UseVisualStyleBackColor = false;
            this.btnFineList.Click += new System.EventHandler(this.btnFineList_Click);
            // 
            // btnOperations
            // 
            this.btnOperations.BackColor = System.Drawing.SystemColors.Window;
            this.btnOperations.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOperations.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOperations.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnOperations.Location = new System.Drawing.Point(158, 180);
            this.btnOperations.Name = "btnOperations";
            this.btnOperations.Size = new System.Drawing.Size(167, 70);
            this.btnOperations.TabIndex = 48;
            this.btnOperations.Text = "User Operations";
            this.btnOperations.UseVisualStyleBackColor = false;
            this.btnOperations.Click += new System.EventHandler(this.btnOperations_Click);
            // 
            // btnBookList
            // 
            this.btnBookList.BackColor = System.Drawing.SystemColors.Window;
            this.btnBookList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBookList.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBookList.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnBookList.Location = new System.Drawing.Point(476, 180);
            this.btnBookList.Name = "btnBookList";
            this.btnBookList.Size = new System.Drawing.Size(167, 70);
            this.btnBookList.TabIndex = 47;
            this.btnBookList.Text = "Book List";
            this.btnBookList.UseVisualStyleBackColor = false;
            this.btnBookList.Click += new System.EventHandler(this.btnBookList_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(322, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 42);
            this.label3.TabIndex = 46;
            this.label3.Text = "LİBRARY";
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
            this.btnBack.TabIndex = 51;
            this.btnBack.Text = "<<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.btnFineList);
            this.Controls.Add(this.btnOperations);
            this.Controls.Add(this.btnBookList);
            this.Controls.Add(this.label3);
            this.Name = "UserPanel";
            this.Text = "UserPanel";
            this.Load += new System.EventHandler(this.UserPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Button btnFineList;
        private System.Windows.Forms.Button btnOperations;
        private System.Windows.Forms.Button btnBookList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
    }
}