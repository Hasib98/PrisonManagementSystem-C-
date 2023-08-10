namespace PrisonManagementSystem
{
    partial class Foods
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
            this.txtboxitem = new System.Windows.Forms.TextBox();
            this.numericUpDownQty = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvFoodList = new System.Windows.Forms.DataGridView();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnaBackFoodFrame = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxitem
            // 
            this.txtboxitem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtboxitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtboxitem.Location = new System.Drawing.Point(141, 80);
            this.txtboxitem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxitem.Name = "txtboxitem";
            this.txtboxitem.Size = new System.Drawing.Size(211, 29);
            this.txtboxitem.TabIndex = 0;
            // 
            // numericUpDownQty
            // 
            this.numericUpDownQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.numericUpDownQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.numericUpDownQty.Location = new System.Drawing.Point(493, 80);
            this.numericUpDownQty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownQty.Name = "numericUpDownQty";
            this.numericUpDownQty.Size = new System.Drawing.Size(107, 29);
            this.numericUpDownQty.TabIndex = 1;
            this.numericUpDownQty.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(685, 80);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 36);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(16, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Add Items:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(392, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quanity:";
            // 
            // dgvFoodList
            // 
            this.dgvFoodList.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvFoodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodList.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvFoodList.Location = new System.Drawing.Point(67, 155);
            this.dgvFoodList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFoodList.Name = "dgvFoodList";
            this.dgvFoodList.ReadOnly = true;
            this.dgvFoodList.RowHeadersWidth = 51;
            this.dgvFoodList.RowTemplate.Height = 24;
            this.dgvFoodList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoodList.Size = new System.Drawing.Size(363, 146);
            this.dgvFoodList.TabIndex = 15;
            this.dgvFoodList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrisonerList_CellContentClick);
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic);
            this.btnprint.ForeColor = System.Drawing.Color.White;
            this.btnprint.Location = new System.Drawing.Point(453, 213);
            this.btnprint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(100, 36);
            this.btnprint.TabIndex = 16;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnaBackFoodFrame
            // 
            this.btnaBackFoodFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnaBackFoodFrame.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic);
            this.btnaBackFoodFrame.ForeColor = System.Drawing.Color.White;
            this.btnaBackFoodFrame.Location = new System.Drawing.Point(16, 4);
            this.btnaBackFoodFrame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnaBackFoodFrame.Name = "btnaBackFoodFrame";
            this.btnaBackFoodFrame.Size = new System.Drawing.Size(100, 34);
            this.btnaBackFoodFrame.TabIndex = 17;
            this.btnaBackFoodFrame.Text = "Back";
            this.btnaBackFoodFrame.UseVisualStyleBackColor = false;
            this.btnaBackFoodFrame.Click += new System.EventHandler(this.btnaBackFoodFrame_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic);
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Location = new System.Drawing.Point(671, 322);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(147, 34);
            this.buttonLogout.TabIndex = 18;
            this.buttonLogout.Text = "Log Out";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(453, 155);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 33);
            this.button1.TabIndex = 19;
            this.button1.Text = "Clear List";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PrisonManagementSystem.Properties.Resources.gui_back;
            this.pictureBox1.Location = new System.Drawing.Point(-12, -9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(860, 395);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Foods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 372);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.btnaBackFoodFrame);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.dgvFoodList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numericUpDownQty);
            this.Controls.Add(this.txtboxitem);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Foods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Foods";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Foods_FormClosing);
            this.Load += new System.EventHandler(this.Foods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxitem;
        private System.Windows.Forms.NumericUpDown numericUpDownQty;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvFoodList;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnaBackFoodFrame;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}