namespace PrisonManagementSystem
{
    partial class NewPassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.textNewPassword = new System.Windows.Forms.TextBox();
            this.textConfirmPassword = new System.Windows.Forms.TextBox();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.labelMsg = new System.Windows.Forms.Label();
            this.checkShowPassword = new System.Windows.Forms.CheckBox();
            this.btnaBackFoodFrame = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(215, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Password";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelId.Location = new System.Drawing.Point(121, 122);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(39, 24);
            this.labelId.TabIndex = 1;
            this.labelId.Text = "Id :";
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelNewPassword.Location = new System.Drawing.Point(121, 177);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(160, 24);
            this.labelNewPassword.TabIndex = 2;
            this.labelNewPassword.Text = "New Password :";
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelConfirmPassword.Location = new System.Drawing.Point(121, 240);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(190, 24);
            this.labelConfirmPassword.TabIndex = 3;
            this.labelConfirmPassword.Text = "Confirm Password :";
            // 
            // textId
            // 
            this.textId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.textId.Location = new System.Drawing.Point(343, 103);
            this.textId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textId.Name = "textId";
            this.textId.ReadOnly = true;
            this.textId.Size = new System.Drawing.Size(159, 29);
            this.textId.TabIndex = 4;
            // 
            // textNewPassword
            // 
            this.textNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.textNewPassword.Location = new System.Drawing.Point(343, 162);
            this.textNewPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textNewPassword.Name = "textNewPassword";
            this.textNewPassword.Size = new System.Drawing.Size(159, 29);
            this.textNewPassword.TabIndex = 5;
            this.textNewPassword.UseSystemPasswordChar = true;
            // 
            // textConfirmPassword
            // 
            this.textConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.textConfirmPassword.Location = new System.Drawing.Point(343, 222);
            this.textConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textConfirmPassword.Name = "textConfirmPassword";
            this.textConfirmPassword.Size = new System.Drawing.Size(159, 29);
            this.textConfirmPassword.TabIndex = 6;
            this.textConfirmPassword.UseSystemPasswordChar = true;
            this.textConfirmPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textConfirmPassword_KeyUp);
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic);
            this.buttonChangePassword.ForeColor = System.Drawing.Color.White;
            this.buttonChangePassword.Location = new System.Drawing.Point(343, 279);
            this.buttonChangePassword.Margin = new System.Windows.Forms.Padding(4);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(135, 36);
            this.buttonChangePassword.TabIndex = 25;
            this.buttonChangePassword.Text = "Change Password";
            this.buttonChangePassword.UseVisualStyleBackColor = false;
            this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // labelMsg
            // 
            this.labelMsg.AutoSize = true;
            this.labelMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMsg.Location = new System.Drawing.Point(537, 263);
            this.labelMsg.Name = "labelMsg";
            this.labelMsg.Size = new System.Drawing.Size(0, 20);
            this.labelMsg.TabIndex = 8;
            // 
            // checkShowPassword
            // 
            this.checkShowPassword.AutoSize = true;
            this.checkShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.checkShowPassword.Location = new System.Drawing.Point(652, 240);
            this.checkShowPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkShowPassword.Name = "checkShowPassword";
            this.checkShowPassword.Size = new System.Drawing.Size(180, 28);
            this.checkShowPassword.TabIndex = 9;
            this.checkShowPassword.Text = "Show Password";
            this.checkShowPassword.UseVisualStyleBackColor = true;
            this.checkShowPassword.CheckedChanged += new System.EventHandler(this.checkShowPassword_CheckedChanged);
            // 
            // btnaBackFoodFrame
            // 
            this.btnaBackFoodFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnaBackFoodFrame.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic);
            this.btnaBackFoodFrame.ForeColor = System.Drawing.Color.White;
            this.btnaBackFoodFrame.Location = new System.Drawing.Point(16, 15);
            this.btnaBackFoodFrame.Margin = new System.Windows.Forms.Padding(4);
            this.btnaBackFoodFrame.Name = "btnaBackFoodFrame";
            this.btnaBackFoodFrame.Size = new System.Drawing.Size(100, 33);
            this.btnaBackFoodFrame.TabIndex = 26;
            this.btnaBackFoodFrame.Text = "Back";
            this.btnaBackFoodFrame.UseVisualStyleBackColor = false;
            this.btnaBackFoodFrame.Click += new System.EventHandler(this.btnaBackFoodFrame_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PrisonManagementSystem.Properties.Resources.gui_back;
            this.pictureBox1.Location = new System.Drawing.Point(-24, -21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(904, 433);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // NewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(833, 372);
            this.Controls.Add(this.btnaBackFoodFrame);
            this.Controls.Add(this.checkShowPassword);
            this.Controls.Add(this.labelMsg);
            this.Controls.Add(this.buttonChangePassword);
            this.Controls.Add(this.textConfirmPassword);
            this.Controls.Add(this.textNewPassword);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.labelConfirmPassword);
            this.Controls.Add(this.labelNewPassword);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "NewPassword";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewPassword";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewPassword_FormClosing);
            this.Load += new System.EventHandler(this.NewPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textNewPassword;
        private System.Windows.Forms.TextBox textConfirmPassword;
        private System.Windows.Forms.Button buttonChangePassword;
        private System.Windows.Forms.Label labelMsg;
        private System.Windows.Forms.CheckBox checkShowPassword;
        private System.Windows.Forms.Button btnaBackFoodFrame;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}