
namespace ADMyLibraryWindowsFormsApp.Views.Home
{
    partial class AdminPanel
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
            this.btnDepositList = new System.Windows.Forms.Button();
            this.btnUserList = new System.Windows.Forms.Button();
            this.btnBookList = new System.Windows.Forms.Button();
            this.btnCategoryList = new System.Windows.Forms.Button();
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
            this.lblKullanici.Location = new System.Drawing.Point(338, 128);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(0, 18);
            this.lblKullanici.TabIndex = 46;
            // 
            // btnDepositList
            // 
            this.btnDepositList.BackColor = System.Drawing.SystemColors.Window;
            this.btnDepositList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDepositList.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepositList.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnDepositList.Location = new System.Drawing.Point(476, 306);
            this.btnDepositList.Name = "btnDepositList";
            this.btnDepositList.Size = new System.Drawing.Size(167, 70);
            this.btnDepositList.TabIndex = 45;
            this.btnDepositList.Text = "Deposit List";
            this.btnDepositList.UseVisualStyleBackColor = false;
            this.btnDepositList.Click += new System.EventHandler(this.btnFineList_Click);
            // 
            // btnUserList
            // 
            this.btnUserList.BackColor = System.Drawing.SystemColors.Window;
            this.btnUserList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUserList.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUserList.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnUserList.Location = new System.Drawing.Point(158, 306);
            this.btnUserList.Name = "btnUserList";
            this.btnUserList.Size = new System.Drawing.Size(167, 70);
            this.btnUserList.TabIndex = 44;
            this.btnUserList.Text = "User List";
            this.btnUserList.UseVisualStyleBackColor = false;
            this.btnUserList.Click += new System.EventHandler(this.btnUserList_Click);
            // 
            // btnBookList
            // 
            this.btnBookList.BackColor = System.Drawing.SystemColors.Window;
            this.btnBookList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBookList.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBookList.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnBookList.Location = new System.Drawing.Point(158, 175);
            this.btnBookList.Name = "btnBookList";
            this.btnBookList.Size = new System.Drawing.Size(167, 70);
            this.btnBookList.TabIndex = 43;
            this.btnBookList.Text = "Book List";
            this.btnBookList.UseVisualStyleBackColor = false;
            this.btnBookList.Click += new System.EventHandler(this.btnBookList_Click);
            // 
            // btnCategoryList
            // 
            this.btnCategoryList.BackColor = System.Drawing.SystemColors.Window;
            this.btnCategoryList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCategoryList.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategoryList.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnCategoryList.Location = new System.Drawing.Point(476, 175);
            this.btnCategoryList.Name = "btnCategoryList";
            this.btnCategoryList.Size = new System.Drawing.Size(167, 70);
            this.btnCategoryList.TabIndex = 42;
            this.btnCategoryList.Text = "Category List";
            this.btnCategoryList.UseVisualStyleBackColor = false;
            this.btnCategoryList.Click += new System.EventHandler(this.btnCategoryList_Click);
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
            this.label3.TabIndex = 41;
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
            this.btnBack.TabIndex = 47;
            this.btnBack.Text = "<<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.btnDepositList);
            this.Controls.Add(this.btnUserList);
            this.Controls.Add(this.btnBookList);
            this.Controls.Add(this.btnCategoryList);
            this.Controls.Add(this.label3);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Button btnDepositList;
        private System.Windows.Forms.Button btnUserList;
        private System.Windows.Forms.Button btnBookList;
        private System.Windows.Forms.Button btnCategoryList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
    }
}