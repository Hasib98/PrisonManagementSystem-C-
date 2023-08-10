namespace PrisonManagementSystem
{
    partial class ManagementPage
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonmngprsnr = new System.Windows.Forms.Button();
            this.buttonFoodmng = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic);
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(16, 15);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 36);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonmngprsnr
            // 
            this.buttonmngprsnr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonmngprsnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic);
            this.buttonmngprsnr.ForeColor = System.Drawing.Color.White;
            this.buttonmngprsnr.Location = new System.Drawing.Point(324, 106);
            this.buttonmngprsnr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonmngprsnr.Name = "buttonmngprsnr";
            this.buttonmngprsnr.Size = new System.Drawing.Size(193, 37);
            this.buttonmngprsnr.TabIndex = 1;
            this.buttonmngprsnr.Text = "Manage Prisoner";
            this.buttonmngprsnr.UseVisualStyleBackColor = false;
            this.buttonmngprsnr.Click += new System.EventHandler(this.buttonmngprsnr_Click);
            // 
            // buttonFoodmng
            // 
            this.buttonFoodmng.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonFoodmng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic);
            this.buttonFoodmng.ForeColor = System.Drawing.Color.White;
            this.buttonFoodmng.Location = new System.Drawing.Point(324, 198);
            this.buttonFoodmng.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFoodmng.Name = "buttonFoodmng";
            this.buttonFoodmng.Size = new System.Drawing.Size(193, 37);
            this.buttonFoodmng.TabIndex = 2;
            this.buttonFoodmng.Text = "Daily Food Listing";
            this.buttonFoodmng.UseVisualStyleBackColor = false;
            this.buttonFoodmng.Click += new System.EventHandler(this.buttonFoodmng_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic);
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Location = new System.Drawing.Point(647, 320);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(159, 37);
            this.buttonLogout.TabIndex = 3;
            this.buttonLogout.Text = "Log out";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PrisonManagementSystem.Properties.Resources.gui_back;
            this.pictureBox1.Location = new System.Drawing.Point(-20, -14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(879, 409);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ManagementPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 372);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonFoodmng);
            this.Controls.Add(this.buttonmngprsnr);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "ManagementPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagementPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagementPage_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonmngprsnr;
        private System.Windows.Forms.Button buttonFoodmng;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}