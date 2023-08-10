namespace PrisonManagementSystem
{
    partial class ChangePassword
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
            this.textName = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.textCurrentPassword = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelCurrentPassword = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.checkShowPassword = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.textName.Location = new System.Drawing.Point(376, 191);
            this.textName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(153, 29);
            this.textName.TabIndex = 0;
            // 
            // textId
            // 
            this.textId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.textId.Location = new System.Drawing.Point(376, 133);
            this.textId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(153, 29);
            this.textId.TabIndex = 1;
            this.textId.TextChanged += new System.EventHandler(this.textId_TextChanged);
            this.textId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textId_KeyPress);
            // 
            // textCurrentPassword
            // 
            this.textCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.textCurrentPassword.Location = new System.Drawing.Point(376, 249);
            this.textCurrentPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textCurrentPassword.Name = "textCurrentPassword";
            this.textCurrentPassword.Size = new System.Drawing.Size(153, 29);
            this.textCurrentPassword.TabIndex = 2;
            this.textCurrentPassword.UseSystemPasswordChar = true;
            this.textCurrentPassword.TextChanged += new System.EventHandler(this.textCurrentPassword_TextChanged);
            this.textCurrentPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textCurrentPassword_KeyUp);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelUserName.Location = new System.Drawing.Point(164, 194);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(126, 24);
            this.labelUserName.TabIndex = 5;
            this.labelUserName.Text = "User Name :";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelId.Location = new System.Drawing.Point(164, 138);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(39, 24);
            this.labelId.TabIndex = 6;
            this.labelId.Text = "Id :";
            // 
            // labelCurrentPassword
            // 
            this.labelCurrentPassword.AutoSize = true;
            this.labelCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelCurrentPassword.Location = new System.Drawing.Point(164, 252);
            this.labelCurrentPassword.Name = "labelCurrentPassword";
            this.labelCurrentPassword.Size = new System.Drawing.Size(187, 24);
            this.labelCurrentPassword.TabIndex = 7;
            this.labelCurrentPassword.Text = "Current Password :";
            this.labelCurrentPassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(155, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(531, 69);
            this.label5.TabIndex = 10;
            this.label5.Text = "Change Password\r\n";
            // 
            // buttonChange
            // 
            this.buttonChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic);
            this.buttonChange.ForeColor = System.Drawing.Color.White;
            this.buttonChange.Location = new System.Drawing.Point(376, 313);
            this.buttonChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(155, 33);
            this.buttonChange.TabIndex = 11;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = false;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic);
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(15, 14);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(108, 34);
            this.buttonBack.TabIndex = 12;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // checkShowPassword
            // 
            this.checkShowPassword.AutoSize = true;
            this.checkShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.checkShowPassword.Location = new System.Drawing.Point(585, 247);
            this.checkShowPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkShowPassword.Name = "checkShowPassword";
            this.checkShowPassword.Size = new System.Drawing.Size(180, 28);
            this.checkShowPassword.TabIndex = 13;
            this.checkShowPassword.Text = "Show Password";
            this.checkShowPassword.UseVisualStyleBackColor = true;
            this.checkShowPassword.CheckedChanged += new System.EventHandler(this.checkShowPassword_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PrisonManagementSystem.Properties.Resources.gui_back;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(833, 372);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(833, 372);
            this.Controls.Add(this.checkShowPassword);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelCurrentPassword);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.textCurrentPassword);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangePassword_FormClosing);
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textCurrentPassword;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelCurrentPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonBack;
        public System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.CheckBox checkShowPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}