namespace PrisonManagementSystem
{
    partial class Prisoner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prisoner));
            this.labelPrisoner = new System.Windows.Forms.Label();
            this.lblPrisonerName = new System.Windows.Forms.Label();
            this.labelPrisonerAge = new System.Windows.Forms.Label();
            this.lblPrisonerGender = new System.Windows.Forms.Label();
            this.lblCrimeType = new System.Windows.Forms.Label();
            this.textPrisonerName = new System.Windows.Forms.TextBox();
            this.textPrisonerAge = new System.Windows.Forms.TextBox();
            this.textCrimeType = new System.Windows.Forms.TextBox();
            this.comboPrisonerGender = new System.Windows.Forms.ComboBox();
            this.buttonPrisonerAdd = new System.Windows.Forms.Button();
            this.buttonPrisonerDelete = new System.Windows.Forms.Button();
            this.buttonPrisonerUpdate = new System.Windows.Forms.Button();
            this.dgvPrisonerList = new System.Windows.Forms.DataGridView();
            this.labelPrisonerSearch = new System.Windows.Forms.Label();
            this.textPrisonerSearch = new System.Windows.Forms.TextBox();
            this.buttonPrisonerClear = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrisonerList)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPrisoner
            // 
            this.labelPrisoner.AutoSize = true;
            this.labelPrisoner.BackColor = System.Drawing.Color.Transparent;
            this.labelPrisoner.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.labelPrisoner.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPrisoner.Location = new System.Drawing.Point(137, 11);
            this.labelPrisoner.Name = "labelPrisoner";
            this.labelPrisoner.Size = new System.Drawing.Size(250, 67);
            this.labelPrisoner.TabIndex = 0;
            this.labelPrisoner.Text = "Prisoner";
            // 
            // lblPrisonerName
            // 
            this.lblPrisonerName.AutoSize = true;
            this.lblPrisonerName.BackColor = System.Drawing.Color.Transparent;
            this.lblPrisonerName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrisonerName.Location = new System.Drawing.Point(28, 159);
            this.lblPrisonerName.Name = "lblPrisonerName";
            this.lblPrisonerName.Size = new System.Drawing.Size(102, 17);
            this.lblPrisonerName.TabIndex = 2;
            this.lblPrisonerName.Text = "Prisoner Name";
            this.lblPrisonerName.Click += new System.EventHandler(this.lblPrisonerName_Click);
            // 
            // labelPrisonerAge
            // 
            this.labelPrisonerAge.AutoSize = true;
            this.labelPrisonerAge.BackColor = System.Drawing.Color.Transparent;
            this.labelPrisonerAge.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPrisonerAge.Location = new System.Drawing.Point(28, 231);
            this.labelPrisonerAge.Name = "labelPrisonerAge";
            this.labelPrisonerAge.Size = new System.Drawing.Size(33, 17);
            this.labelPrisonerAge.TabIndex = 3;
            this.labelPrisonerAge.Text = "Age";
            // 
            // lblPrisonerGender
            // 
            this.lblPrisonerGender.AutoSize = true;
            this.lblPrisonerGender.BackColor = System.Drawing.Color.Transparent;
            this.lblPrisonerGender.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrisonerGender.Location = new System.Drawing.Point(28, 300);
            this.lblPrisonerGender.Name = "lblPrisonerGender";
            this.lblPrisonerGender.Size = new System.Drawing.Size(56, 17);
            this.lblPrisonerGender.TabIndex = 4;
            this.lblPrisonerGender.Text = "Gender";
            // 
            // lblCrimeType
            // 
            this.lblCrimeType.AutoSize = true;
            this.lblCrimeType.BackColor = System.Drawing.Color.Transparent;
            this.lblCrimeType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCrimeType.Location = new System.Drawing.Point(25, 382);
            this.lblCrimeType.Name = "lblCrimeType";
            this.lblCrimeType.Size = new System.Drawing.Size(80, 17);
            this.lblCrimeType.TabIndex = 5;
            this.lblCrimeType.Text = "Crime Type";
            // 
            // textPrisonerName
            // 
            this.textPrisonerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textPrisonerName.Location = new System.Drawing.Point(175, 159);
            this.textPrisonerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textPrisonerName.Name = "textPrisonerName";
            this.textPrisonerName.Size = new System.Drawing.Size(123, 22);
            this.textPrisonerName.TabIndex = 7;
            // 
            // textPrisonerAge
            // 
            this.textPrisonerAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textPrisonerAge.Location = new System.Drawing.Point(175, 231);
            this.textPrisonerAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textPrisonerAge.Name = "textPrisonerAge";
            this.textPrisonerAge.Size = new System.Drawing.Size(123, 22);
            this.textPrisonerAge.TabIndex = 8;
            // 
            // textCrimeType
            // 
            this.textCrimeType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textCrimeType.Location = new System.Drawing.Point(177, 377);
            this.textCrimeType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textCrimeType.Name = "textCrimeType";
            this.textCrimeType.Size = new System.Drawing.Size(123, 22);
            this.textCrimeType.TabIndex = 9;
            // 
            // comboPrisonerGender
            // 
            this.comboPrisonerGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.comboPrisonerGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPrisonerGender.FormattingEnabled = true;
            this.comboPrisonerGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboPrisonerGender.Location = new System.Drawing.Point(177, 297);
            this.comboPrisonerGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboPrisonerGender.Name = "comboPrisonerGender";
            this.comboPrisonerGender.Size = new System.Drawing.Size(121, 24);
            this.comboPrisonerGender.TabIndex = 10;
            this.comboPrisonerGender.SelectedIndexChanged += new System.EventHandler(this.comboPrisonerGender_SelectedIndexChanged);
            // 
            // buttonPrisonerAdd
            // 
            this.buttonPrisonerAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonPrisonerAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic);
            this.buttonPrisonerAdd.ForeColor = System.Drawing.Color.White;
            this.buttonPrisonerAdd.Location = new System.Drawing.Point(40, 466);
            this.buttonPrisonerAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPrisonerAdd.Name = "buttonPrisonerAdd";
            this.buttonPrisonerAdd.Size = new System.Drawing.Size(90, 44);
            this.buttonPrisonerAdd.TabIndex = 11;
            this.buttonPrisonerAdd.Text = "Add";
            this.buttonPrisonerAdd.UseVisualStyleBackColor = false;
            this.buttonPrisonerAdd.Click += new System.EventHandler(this.buttonPrisonerAdd_Click);
            // 
            // buttonPrisonerDelete
            // 
            this.buttonPrisonerDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonPrisonerDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic);
            this.buttonPrisonerDelete.ForeColor = System.Drawing.Color.White;
            this.buttonPrisonerDelete.Location = new System.Drawing.Point(189, 466);
            this.buttonPrisonerDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPrisonerDelete.Name = "buttonPrisonerDelete";
            this.buttonPrisonerDelete.Size = new System.Drawing.Size(89, 44);
            this.buttonPrisonerDelete.TabIndex = 12;
            this.buttonPrisonerDelete.Text = "Delete";
            this.buttonPrisonerDelete.UseVisualStyleBackColor = false;
            this.buttonPrisonerDelete.Click += new System.EventHandler(this.buttonPrisonerDelete_Click);
            // 
            // buttonPrisonerUpdate
            // 
            this.buttonPrisonerUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonPrisonerUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic);
            this.buttonPrisonerUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonPrisonerUpdate.Location = new System.Drawing.Point(347, 466);
            this.buttonPrisonerUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPrisonerUpdate.Name = "buttonPrisonerUpdate";
            this.buttonPrisonerUpdate.Size = new System.Drawing.Size(94, 44);
            this.buttonPrisonerUpdate.TabIndex = 13;
            this.buttonPrisonerUpdate.Text = "Update";
            this.buttonPrisonerUpdate.UseVisualStyleBackColor = false;
            this.buttonPrisonerUpdate.Click += new System.EventHandler(this.buttonPrisonerUpdate_Click);
            // 
            // dgvPrisonerList
            // 
            this.dgvPrisonerList.AllowUserToResizeColumns = false;
            this.dgvPrisonerList.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvPrisonerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrisonerList.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvPrisonerList.Location = new System.Drawing.Point(331, 159);
            this.dgvPrisonerList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPrisonerList.Name = "dgvPrisonerList";
            this.dgvPrisonerList.ReadOnly = true;
            this.dgvPrisonerList.RowHeadersWidth = 51;
            this.dgvPrisonerList.RowTemplate.Height = 24;
            this.dgvPrisonerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrisonerList.Size = new System.Drawing.Size(731, 277);
            this.dgvPrisonerList.TabIndex = 14;
            this.dgvPrisonerList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrisonerList_CellClick);
            // 
            // labelPrisonerSearch
            // 
            this.labelPrisonerSearch.AutoSize = true;
            this.labelPrisonerSearch.BackColor = System.Drawing.Color.Transparent;
            this.labelPrisonerSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPrisonerSearch.Location = new System.Drawing.Point(331, 106);
            this.labelPrisonerSearch.Name = "labelPrisonerSearch";
            this.labelPrisonerSearch.Size = new System.Drawing.Size(53, 17);
            this.labelPrisonerSearch.TabIndex = 15;
            this.labelPrisonerSearch.Text = "Search";
            // 
            // textPrisonerSearch
            // 
            this.textPrisonerSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textPrisonerSearch.Location = new System.Drawing.Point(413, 106);
            this.textPrisonerSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textPrisonerSearch.Name = "textPrisonerSearch";
            this.textPrisonerSearch.Size = new System.Drawing.Size(197, 22);
            this.textPrisonerSearch.TabIndex = 16;
            this.textPrisonerSearch.TextChanged += new System.EventHandler(this.textPrisonerSearch_TextChanged);
            // 
            // buttonPrisonerClear
            // 
            this.buttonPrisonerClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonPrisonerClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic);
            this.buttonPrisonerClear.ForeColor = System.Drawing.Color.White;
            this.buttonPrisonerClear.Location = new System.Drawing.Point(495, 466);
            this.buttonPrisonerClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPrisonerClear.Name = "buttonPrisonerClear";
            this.buttonPrisonerClear.Size = new System.Drawing.Size(88, 44);
            this.buttonPrisonerClear.TabIndex = 17;
            this.buttonPrisonerClear.Text = "Clear";
            this.buttonPrisonerClear.UseVisualStyleBackColor = false;
            this.buttonPrisonerClear.Click += new System.EventHandler(this.buttonPrisonerClear_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic);
            this.buttonLogOut.ForeColor = System.Drawing.Color.White;
            this.buttonLogOut.Location = new System.Drawing.Point(1011, 498);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(125, 32);
            this.buttonLogOut.TabIndex = 18;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click_1);
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic);
            this.buttonPrint.ForeColor = System.Drawing.Color.White;
            this.buttonPrint.Location = new System.Drawing.Point(980, 441);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(81, 32);
            this.buttonPrint.TabIndex = 19;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic);
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(15, 14);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(81, 32);
            this.buttonBack.TabIndex = 20;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // Prisoner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1164, 567);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonPrisonerClear);
            this.Controls.Add(this.textPrisonerSearch);
            this.Controls.Add(this.labelPrisonerSearch);
            this.Controls.Add(this.dgvPrisonerList);
            this.Controls.Add(this.buttonPrisonerUpdate);
            this.Controls.Add(this.buttonPrisonerDelete);
            this.Controls.Add(this.buttonPrisonerAdd);
            this.Controls.Add(this.comboPrisonerGender);
            this.Controls.Add(this.textCrimeType);
            this.Controls.Add(this.textPrisonerAge);
            this.Controls.Add(this.textPrisonerName);
            this.Controls.Add(this.lblCrimeType);
            this.Controls.Add(this.lblPrisonerGender);
            this.Controls.Add(this.labelPrisonerAge);
            this.Controls.Add(this.lblPrisonerName);
            this.Controls.Add(this.labelPrisoner);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Prisoner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prisoner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Prisoner_FormClosing);
            this.Load += new System.EventHandler(this.Prisoner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrisonerList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPrisoner;
        private System.Windows.Forms.Label lblPrisonerName;
        private System.Windows.Forms.Label labelPrisonerAge;
        private System.Windows.Forms.Label lblPrisonerGender;
        private System.Windows.Forms.Label lblCrimeType;
        private System.Windows.Forms.TextBox textPrisonerName;
        private System.Windows.Forms.TextBox textPrisonerAge;
        private System.Windows.Forms.TextBox textCrimeType;
        private System.Windows.Forms.ComboBox comboPrisonerGender;
        private System.Windows.Forms.Button buttonPrisonerAdd;
        private System.Windows.Forms.Button buttonPrisonerDelete;
        private System.Windows.Forms.Button buttonPrisonerUpdate;
        private System.Windows.Forms.DataGridView dgvPrisonerList;
        private System.Windows.Forms.Label labelPrisonerSearch;
        private System.Windows.Forms.TextBox textPrisonerSearch;
        private System.Windows.Forms.Button buttonPrisonerClear;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button buttonBack;
    }
}

