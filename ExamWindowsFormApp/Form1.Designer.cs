namespace ExamWindowsFormApp
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
            this.groupBoxStudent = new System.Windows.Forms.GroupBox();
            this.btnAssaign = new System.Windows.Forms.Button();
            this.textBoxStudent = new System.Windows.Forms.TextBox();
            this.groupBoxGrade = new System.Windows.Forms.GroupBox();
            this.comboBoxStudent = new System.Windows.Forms.ComboBox();
            this.comboBoxGrade = new System.Windows.Forms.ComboBox();
            this.btnGrade = new System.Windows.Forms.Button();
            this.groupBoxStatistics = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxStudent.SuspendLayout();
            this.groupBoxGrade.SuspendLayout();
            this.groupBoxStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxStudent
            // 
            this.groupBoxStudent.Controls.Add(this.btnAssaign);
            this.groupBoxStudent.Controls.Add(this.textBoxStudent);
            this.groupBoxStudent.Location = new System.Drawing.Point(32, 24);
            this.groupBoxStudent.Name = "groupBoxStudent";
            this.groupBoxStudent.Size = new System.Drawing.Size(460, 79);
            this.groupBoxStudent.TabIndex = 0;
            this.groupBoxStudent.TabStop = false;
            this.groupBoxStudent.Text = "Student Information";
            // 
            // btnAssaign
            // 
            this.btnAssaign.Location = new System.Drawing.Point(357, 29);
            this.btnAssaign.Name = "btnAssaign";
            this.btnAssaign.Size = new System.Drawing.Size(75, 23);
            this.btnAssaign.TabIndex = 1;
            this.btnAssaign.Text = "Assaign";
            this.btnAssaign.UseVisualStyleBackColor = true;
            this.btnAssaign.Click += new System.EventHandler(this.btnAssaign_Click);
            // 
            // textBoxStudent
            // 
            this.textBoxStudent.Location = new System.Drawing.Point(6, 29);
            this.textBoxStudent.Name = "textBoxStudent";
            this.textBoxStudent.Size = new System.Drawing.Size(327, 20);
            this.textBoxStudent.TabIndex = 2;
            // 
            // groupBoxGrade
            // 
            this.groupBoxGrade.Controls.Add(this.btnGrade);
            this.groupBoxGrade.Controls.Add(this.comboBoxGrade);
            this.groupBoxGrade.Controls.Add(this.comboBoxStudent);
            this.groupBoxGrade.Location = new System.Drawing.Point(32, 109);
            this.groupBoxGrade.Name = "groupBoxGrade";
            this.groupBoxGrade.Size = new System.Drawing.Size(460, 134);
            this.groupBoxGrade.TabIndex = 1;
            this.groupBoxGrade.TabStop = false;
            this.groupBoxGrade.Text = "Grade";
            // 
            // comboBoxStudent
            // 
            this.comboBoxStudent.FormattingEnabled = true;
            this.comboBoxStudent.Location = new System.Drawing.Point(6, 36);
            this.comboBoxStudent.Name = "comboBoxStudent";
            this.comboBoxStudent.Size = new System.Drawing.Size(347, 21);
            this.comboBoxStudent.TabIndex = 0;
            // 
            // comboBoxGrade
            // 
            this.comboBoxGrade.FormattingEnabled = true;
            this.comboBoxGrade.Items.AddRange(new object[] {
            "IG",
            "G",
            "VG"});
            this.comboBoxGrade.Location = new System.Drawing.Point(7, 76);
            this.comboBoxGrade.Name = "comboBoxGrade";
            this.comboBoxGrade.Size = new System.Drawing.Size(156, 21);
            this.comboBoxGrade.TabIndex = 1;
            // 
            // btnGrade
            // 
            this.btnGrade.Location = new System.Drawing.Point(193, 76);
            this.btnGrade.Name = "btnGrade";
            this.btnGrade.Size = new System.Drawing.Size(97, 23);
            this.btnGrade.TabIndex = 2;
            this.btnGrade.Text = "Grade";
            this.btnGrade.UseVisualStyleBackColor = true;
            // 
            // groupBoxStatistics
            // 
            this.groupBoxStatistics.Controls.Add(this.label3);
            this.groupBoxStatistics.Controls.Add(this.label2);
            this.groupBoxStatistics.Controls.Add(this.label1);
            this.groupBoxStatistics.Controls.Add(this.btnGenerate);
            this.groupBoxStatistics.Location = new System.Drawing.Point(39, 264);
            this.groupBoxStatistics.Name = "groupBoxStatistics";
            this.groupBoxStatistics.Size = new System.Drawing.Size(453, 142);
            this.groupBoxStatistics.TabIndex = 2;
            this.groupBoxStatistics.TabStop = false;
            this.groupBoxStatistics.Text = "Statistics";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(350, 102);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IG:0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "G:0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "VG:0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 448);
            this.Controls.Add(this.groupBoxStatistics);
            this.Controls.Add(this.groupBoxGrade);
            this.Controls.Add(this.groupBoxStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxStudent.ResumeLayout(false);
            this.groupBoxStudent.PerformLayout();
            this.groupBoxGrade.ResumeLayout(false);
            this.groupBoxStatistics.ResumeLayout(false);
            this.groupBoxStatistics.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxStudent;
        private System.Windows.Forms.Button btnAssaign;
        private System.Windows.Forms.TextBox textBoxStudent;
        private System.Windows.Forms.GroupBox groupBoxGrade;
        private System.Windows.Forms.Button btnGrade;
        private System.Windows.Forms.ComboBox comboBoxGrade;
        private System.Windows.Forms.ComboBox comboBoxStudent;
        private System.Windows.Forms.GroupBox groupBoxStatistics;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerate;
    }
}

