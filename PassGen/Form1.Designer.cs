namespace PassGen
{
    partial class Form1
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
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.cbNumbers = new System.Windows.Forms.CheckBox();
            this.cbLowercase = new System.Windows.Forms.CheckBox();
            this.cbUppercase = new System.Windows.Forms.CheckBox();
            this.cbSymbols = new System.Windows.Forms.CheckBox();
            this.txtExclude = new System.Windows.Forms.TextBox();
            this.lblExclude = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.nMin = new System.Windows.Forms.NumericUpDown();
            this.lblMax = new System.Windows.Forms.Label();
            this.nMax = new System.Windows.Forms.NumericUpDown();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.gbCharacters = new System.Windows.Forms.GroupBox();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMax)).BeginInit();
            this.gbCharacters.SuspendLayout();
            this.gbOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(12, 12);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.ReadOnly = true;
            this.tbPassword.Size = new System.Drawing.Size(316, 44);
            this.tbPassword.TabIndex = 0;
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbNumbers
            // 
            this.cbNumbers.AutoSize = true;
            this.cbNumbers.Checked = true;
            this.cbNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNumbers.Location = new System.Drawing.Point(6, 19);
            this.cbNumbers.Name = "cbNumbers";
            this.cbNumbers.Size = new System.Drawing.Size(68, 17);
            this.cbNumbers.TabIndex = 1;
            this.cbNumbers.Text = "Numbers";
            this.cbNumbers.UseVisualStyleBackColor = true;
            // 
            // cbLowercase
            // 
            this.cbLowercase.AutoSize = true;
            this.cbLowercase.Checked = true;
            this.cbLowercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLowercase.Location = new System.Drawing.Point(80, 19);
            this.cbLowercase.Name = "cbLowercase";
            this.cbLowercase.Size = new System.Drawing.Size(78, 17);
            this.cbLowercase.TabIndex = 2;
            this.cbLowercase.Text = "Lowercase";
            this.cbLowercase.UseVisualStyleBackColor = true;
            // 
            // cbUppercase
            // 
            this.cbUppercase.AutoSize = true;
            this.cbUppercase.Checked = true;
            this.cbUppercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUppercase.Location = new System.Drawing.Point(164, 19);
            this.cbUppercase.Name = "cbUppercase";
            this.cbUppercase.Size = new System.Drawing.Size(78, 17);
            this.cbUppercase.TabIndex = 3;
            this.cbUppercase.Text = "Uppercase";
            this.cbUppercase.UseVisualStyleBackColor = true;
            // 
            // cbSymbols
            // 
            this.cbSymbols.AutoSize = true;
            this.cbSymbols.Checked = true;
            this.cbSymbols.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSymbols.Location = new System.Drawing.Point(242, 19);
            this.cbSymbols.Name = "cbSymbols";
            this.cbSymbols.Size = new System.Drawing.Size(65, 17);
            this.cbSymbols.TabIndex = 4;
            this.cbSymbols.Text = "Symbols";
            this.cbSymbols.UseVisualStyleBackColor = true;
            // 
            // txtExclude
            // 
            this.txtExclude.Location = new System.Drawing.Point(45, 22);
            this.txtExclude.Name = "txtExclude";
            this.txtExclude.Size = new System.Drawing.Size(102, 20);
            this.txtExclude.TabIndex = 5;
            this.txtExclude.Text = "o0Oil";
            this.txtExclude.TextChanged += new System.EventHandler(this.txtExclude_TextChanged);
            // 
            // lblExclude
            // 
            this.lblExclude.AutoSize = true;
            this.lblExclude.Location = new System.Drawing.Point(3, 25);
            this.lblExclude.Name = "lblExclude";
            this.lblExclude.Size = new System.Drawing.Size(45, 13);
            this.lblExclude.TabIndex = 6;
            this.lblExclude.Text = "Exclude";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(153, 27);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(24, 13);
            this.lblMin.TabIndex = 8;
            this.lblMin.Text = "Min";
            // 
            // nMin
            // 
            this.nMin.Location = new System.Drawing.Point(183, 25);
            this.nMin.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nMin.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nMin.Name = "nMin";
            this.nMin.Size = new System.Drawing.Size(37, 20);
            this.nMin.TabIndex = 9;
            this.nMin.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nMin.ValueChanged += new System.EventHandler(this.nMin_ValueChanged);
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(227, 27);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(27, 13);
            this.lblMax.TabIndex = 10;
            this.lblMax.Text = "Max";
            // 
            // nMax
            // 
            this.nMax.Location = new System.Drawing.Point(261, 25);
            this.nMax.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nMax.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nMax.Name = "nMax";
            this.nMax.Size = new System.Drawing.Size(44, 20);
            this.nMax.TabIndex = 11;
            this.nMax.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(15, 187);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(313, 66);
            this.btnGenerate.TabIndex = 12;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // gbCharacters
            // 
            this.gbCharacters.Controls.Add(this.cbNumbers);
            this.gbCharacters.Controls.Add(this.cbLowercase);
            this.gbCharacters.Controls.Add(this.cbUppercase);
            this.gbCharacters.Controls.Add(this.cbSymbols);
            this.gbCharacters.Location = new System.Drawing.Point(15, 63);
            this.gbCharacters.Name = "gbCharacters";
            this.gbCharacters.Size = new System.Drawing.Size(313, 53);
            this.gbCharacters.TabIndex = 13;
            this.gbCharacters.TabStop = false;
            this.gbCharacters.Text = "Characters";
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.lblExclude);
            this.gbOptions.Controls.Add(this.txtExclude);
            this.gbOptions.Controls.Add(this.nMin);
            this.gbOptions.Controls.Add(this.nMax);
            this.gbOptions.Controls.Add(this.lblMin);
            this.gbOptions.Controls.Add(this.lblMax);
            this.gbOptions.Location = new System.Drawing.Point(15, 123);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(313, 58);
            this.gbOptions.TabIndex = 14;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = " Options ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "K.Andreev - 2016";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(270, 56);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(49, 13);
            this.lblLength.TabIndex = 16;
            this.lblLength.Text = "Length:0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 277);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.gbCharacters);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.tbPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PassGen";
            ((System.ComponentModel.ISupportInitialize)(this.nMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMax)).EndInit();
            this.gbCharacters.ResumeLayout(false);
            this.gbCharacters.PerformLayout();
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.CheckBox cbNumbers;
        private System.Windows.Forms.CheckBox cbLowercase;
        private System.Windows.Forms.CheckBox cbUppercase;
        private System.Windows.Forms.CheckBox cbSymbols;
        private System.Windows.Forms.TextBox txtExclude;
        private System.Windows.Forms.Label lblExclude;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.NumericUpDown nMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.NumericUpDown nMax;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.GroupBox gbCharacters;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLength;
    }
}

