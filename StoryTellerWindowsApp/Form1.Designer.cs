namespace StoryTellerWindowsApp
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
            this.NameOfChild = new System.Windows.Forms.Label();
            this.cbScary = new System.Windows.Forms.CheckBox();
            this.tbNameOfChild = new System.Windows.Forms.TextBox();
            this.ageOfChild = new System.Windows.Forms.Label();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.btnTellStory = new System.Windows.Forms.Button();
            this.tbstory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.SuspendLayout();
            // 
            // NameOfChild
            // 
            this.NameOfChild.AutoSize = true;
            this.NameOfChild.Location = new System.Drawing.Point(25, 23);
            this.NameOfChild.Name = "NameOfChild";
            this.NameOfChild.Size = new System.Drawing.Size(75, 13);
            this.NameOfChild.TabIndex = 0;
            this.NameOfChild.Text = "Name Of Child";
            // 
            // cbScary
            // 
            this.cbScary.AutoSize = true;
            this.cbScary.Location = new System.Drawing.Point(31, 131);
            this.cbScary.Name = "cbScary";
            this.cbScary.Size = new System.Drawing.Size(102, 17);
            this.cbScary.TabIndex = 1;
            this.cbScary.Text = "Should be scary";
            this.cbScary.UseVisualStyleBackColor = true;
            // 
            // tbNameOfChild
            // 
            this.tbNameOfChild.Location = new System.Drawing.Point(28, 48);
            this.tbNameOfChild.Name = "tbNameOfChild";
            this.tbNameOfChild.Size = new System.Drawing.Size(184, 20);
            this.tbNameOfChild.TabIndex = 2;
            this.tbNameOfChild.TextChanged += new System.EventHandler(this.tbNameOfChild_TextChanged);
            // 
            // ageOfChild
            // 
            this.ageOfChild.AutoSize = true;
            this.ageOfChild.Location = new System.Drawing.Point(28, 93);
            this.ageOfChild.Name = "ageOfChild";
            this.ageOfChild.Size = new System.Drawing.Size(0, 13);
            this.ageOfChild.TabIndex = 3;
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(121, 89);
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(65, 20);
            this.numAge.TabIndex = 4;
            // 
            // btnTellStory
            // 
            this.btnTellStory.Location = new System.Drawing.Point(31, 165);
            this.btnTellStory.Name = "btnTellStory";
            this.btnTellStory.Size = new System.Drawing.Size(75, 23);
            this.btnTellStory.TabIndex = 5;
            this.btnTellStory.Text = "Tell Story";
            this.btnTellStory.UseVisualStyleBackColor = true;
            this.btnTellStory.Click += new System.EventHandler(this.btnTellStory_Click);
            // 
            // tbstory
            // 
            this.tbstory.Location = new System.Drawing.Point(-1, 256);
            this.tbstory.Multiline = true;
            this.tbstory.Name = "tbstory";
            this.tbstory.Size = new System.Drawing.Size(390, 107);
            this.tbstory.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Age of Child";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 370);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbstory);
            this.Controls.Add(this.btnTellStory);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.ageOfChild);
            this.Controls.Add(this.tbNameOfChild);
            this.Controls.Add(this.cbScary);
            this.Controls.Add(this.NameOfChild);
            this.Name = "Form1";
            this.Text = "StorytellerForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameOfChild;
        private System.Windows.Forms.CheckBox cbScary;
        private System.Windows.Forms.TextBox tbNameOfChild;
        private System.Windows.Forms.Label ageOfChild;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.Button btnTellStory;
        private System.Windows.Forms.TextBox tbstory;
        private System.Windows.Forms.Label label1;
    }
}

