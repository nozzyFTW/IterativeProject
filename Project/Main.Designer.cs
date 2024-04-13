namespace Iterative_Project
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lblPages = new System.Windows.Forms.Label();
            this.lblCrimeAmount = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOutput = new System.Windows.Forms.DataGridView();
            this.lblYear = new System.Windows.Forms.Label();
            this.cbxYear = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxSuburb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxLevelTwoOffence = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxLevelOneOffence = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxLevelThreeOffence = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPages
            // 
            this.lblPages.Location = new System.Drawing.Point(276, 474);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(599, 13);
            this.lblPages.TabIndex = 17;
            this.lblPages.Text = "Page {currentPage} of {totalPages}";
            this.lblPages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCrimeAmount
            // 
            this.lblCrimeAmount.Location = new System.Drawing.Point(276, 457);
            this.lblCrimeAmount.Name = "lblCrimeAmount";
            this.lblCrimeAmount.Size = new System.Drawing.Size(599, 13);
            this.lblCrimeAmount.TabIndex = 16;
            this.lblCrimeAmount.Text = "Showing {dgvOutput.RowCount} out of {dgvOutput.RowCount} Crimes";
            this.lblCrimeAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(879, 452);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 35);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(195, 452);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 35);
            this.btnPrev.TabIndex = 14;
            this.btnPrev.Text = "<<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(38, 299);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(109, 23);
            this.btnSelect.TabIndex = 13;
            this.btnSelect.Text = "Filter";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "SA Crime Search";
            // 
            // dgvOutput
            // 
            this.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutput.Location = new System.Drawing.Point(193, 10);
            this.dgvOutput.Name = "dgvOutput";
            this.dgvOutput.ReadOnly = true;
            this.dgvOutput.Size = new System.Drawing.Size(761, 426);
            this.dgvOutput.TabIndex = 11;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(10, 49);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 10;
            this.lblYear.Text = "Year";
            // 
            // cbxYear
            // 
            this.cbxYear.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbxYear.FormattingEnabled = true;
            this.cbxYear.Items.AddRange(new object[] {
            "- All -"});
            this.cbxYear.Location = new System.Drawing.Point(13, 65);
            this.cbxYear.Name = "cbxYear";
            this.cbxYear.Size = new System.Drawing.Size(163, 21);
            this.cbxYear.Sorted = true;
            this.cbxYear.TabIndex = 9;
            this.cbxYear.TabStop = false;
            this.cbxYear.Text = "Search year here";
            this.cbxYear.Enter += new System.EventHandler(this.cbxYear_Enter);
            this.cbxYear.Leave += new System.EventHandler(this.cbxYear_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Suburb";
            // 
            // cbxSuburb
            // 
            this.cbxSuburb.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbxSuburb.FormattingEnabled = true;
            this.cbxSuburb.Items.AddRange(new object[] {
            "- All -"});
            this.cbxSuburb.Location = new System.Drawing.Point(13, 113);
            this.cbxSuburb.Name = "cbxSuburb";
            this.cbxSuburb.Size = new System.Drawing.Size(163, 21);
            this.cbxSuburb.Sorted = true;
            this.cbxSuburb.TabIndex = 18;
            this.cbxSuburb.TabStop = false;
            this.cbxSuburb.Text = "Search suburb here";
            this.cbxSuburb.Enter += new System.EventHandler(this.cbxSuburb_Enter);
            this.cbxSuburb.Leave += new System.EventHandler(this.cbxSuburb_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Level 2 Offence";
            // 
            // cbxLevelTwoOffence
            // 
            this.cbxLevelTwoOffence.DropDownWidth = 200;
            this.cbxLevelTwoOffence.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbxLevelTwoOffence.FormattingEnabled = true;
            this.cbxLevelTwoOffence.Items.AddRange(new object[] {
            "- All -"});
            this.cbxLevelTwoOffence.Location = new System.Drawing.Point(13, 209);
            this.cbxLevelTwoOffence.Name = "cbxLevelTwoOffence";
            this.cbxLevelTwoOffence.Size = new System.Drawing.Size(163, 21);
            this.cbxLevelTwoOffence.Sorted = true;
            this.cbxLevelTwoOffence.TabIndex = 22;
            this.cbxLevelTwoOffence.TabStop = false;
            this.cbxLevelTwoOffence.Text = "Search offence here";
            this.cbxLevelTwoOffence.Enter += new System.EventHandler(this.cbxLevelTwoOffence_Enter);
            this.cbxLevelTwoOffence.Leave += new System.EventHandler(this.cbxLevelTwoOffence_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Level 1 Offence";
            // 
            // cbxLevelOneOffence
            // 
            this.cbxLevelOneOffence.DropDownWidth = 200;
            this.cbxLevelOneOffence.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbxLevelOneOffence.FormattingEnabled = true;
            this.cbxLevelOneOffence.Items.AddRange(new object[] {
            "- All -"});
            this.cbxLevelOneOffence.Location = new System.Drawing.Point(13, 161);
            this.cbxLevelOneOffence.Name = "cbxLevelOneOffence";
            this.cbxLevelOneOffence.Size = new System.Drawing.Size(163, 21);
            this.cbxLevelOneOffence.Sorted = true;
            this.cbxLevelOneOffence.TabIndex = 20;
            this.cbxLevelOneOffence.TabStop = false;
            this.cbxLevelOneOffence.Text = "Search offence here";
            this.cbxLevelOneOffence.Enter += new System.EventHandler(this.cbxLevelOneOffence_Enter);
            this.cbxLevelOneOffence.Leave += new System.EventHandler(this.cbxLevelOneOffence_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Level 3 Offence";
            // 
            // cbxLevelThreeOffence
            // 
            this.cbxLevelThreeOffence.DropDownWidth = 200;
            this.cbxLevelThreeOffence.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbxLevelThreeOffence.FormattingEnabled = true;
            this.cbxLevelThreeOffence.Items.AddRange(new object[] {
            "- All -"});
            this.cbxLevelThreeOffence.Location = new System.Drawing.Point(13, 260);
            this.cbxLevelThreeOffence.Name = "cbxLevelThreeOffence";
            this.cbxLevelThreeOffence.Size = new System.Drawing.Size(163, 21);
            this.cbxLevelThreeOffence.Sorted = true;
            this.cbxLevelThreeOffence.TabIndex = 24;
            this.cbxLevelThreeOffence.TabStop = false;
            this.cbxLevelThreeOffence.Text = "Search offence here";
            this.cbxLevelThreeOffence.Enter += new System.EventHandler(this.cbxLevelThreeOffence_Enter);
            this.cbxLevelThreeOffence.Leave += new System.EventHandler(this.cbxLevelThreeOffence_Leave);
            // 
            // progressBar1
            // 
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.progressBar1.Location = new System.Drawing.Point(193, 436);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(761, 10);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 26;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 496);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxLevelThreeOffence);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxLevelTwoOffence);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxLevelOneOffence);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxSuburb);
            this.Controls.Add(this.lblPages);
            this.Controls.Add(this.lblCrimeAmount);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOutput);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.cbxYear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "‎";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.FormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.Label lblCrimeAmount;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOutput;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cbxYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxSuburb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxLevelTwoOffence;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxLevelOneOffence;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxLevelThreeOffence;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}