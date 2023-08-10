namespace PrisonManagementSystem
{
    partial class UserHome
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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonExit = new PrisonManagementSystem.Button_Round();
            this.buttonSignUp = new PrisonManagementSystem.Button_Round();
            this.buttonLogin = new PrisonManagementSystem.Button_Round();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(273, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(236, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prison Management";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PrisonManagementSystem.Properties.Resources.back3;
            this.pictureBox2.Location = new System.Drawing.Point(135, -3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(360, 317);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PrisonManagementSystem.Properties.Resources.gui_back;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(633, 309);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BorderColor = System.Drawing.Color.Transparent;
            this.buttonExit.ButtonColor = System.Drawing.Color.Red;
            this.buttonExit.Font = new System.Drawing.Font("Nirmala UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(264, 242);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.buttonExit.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(46)))), ((int)(((byte)(2)))));
            this.buttonExit.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonExit.Size = new System.Drawing.Size(102, 33);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.TextColor = System.Drawing.Color.White;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.BorderColor = System.Drawing.Color.Transparent;
            this.buttonSignUp.ButtonColor = System.Drawing.Color.Indigo;
            this.buttonSignUp.Font = new System.Drawing.Font("Nirmala UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignUp.Location = new System.Drawing.Point(264, 188);
            this.buttonSignUp.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.buttonSignUp.OnHoverButtonColor = System.Drawing.Color.DarkViolet;
            this.buttonSignUp.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonSignUp.Size = new System.Drawing.Size(102, 33);
            this.buttonSignUp.TabIndex = 4;
            this.buttonSignUp.Text = "Sign Up";
            this.buttonSignUp.TextColor = System.Drawing.Color.White;
            this.buttonSignUp.UseVisualStyleBackColor = true;
            this.buttonSignUp.Click += new System.EventHandler(this.button_Round2_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BorderColor = System.Drawing.Color.Transparent;
            this.buttonLogin.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonLogin.Font = new System.Drawing.Font("Nirmala UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(264, 134);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.buttonLogin.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonLogin.Size = new System.Drawing.Size(102, 33);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.TextColor = System.Drawing.Color.White;
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // UserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 302);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loginn";
            this.Load += new System.EventHandler(this.Loginn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Button_Round buttonLogin;
        private Button_Round buttonSignUp;
        private Button_Round buttonExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}