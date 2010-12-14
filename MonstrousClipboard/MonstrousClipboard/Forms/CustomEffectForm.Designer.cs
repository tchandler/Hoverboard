namespace Hoverboard
{
    partial class CustomEffectForm
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
            this.matchRegexTB = new System.Windows.Forms.TextBox();
            this.clearExpBtn = new System.Windows.Forms.Button();
            this.saveExpBtn = new System.Windows.Forms.Button();
            this.testExpBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.testTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.replaceRegexTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // matchRegexTB
            // 
            this.matchRegexTB.Location = new System.Drawing.Point(9, 21);
            this.matchRegexTB.Name = "matchRegexTB";
            this.matchRegexTB.Size = new System.Drawing.Size(185, 20);
            this.matchRegexTB.TabIndex = 0;
            // 
            // clearExpBtn
            // 
            this.clearExpBtn.Location = new System.Drawing.Point(9, 86);
            this.clearExpBtn.Name = "clearExpBtn";
            this.clearExpBtn.Size = new System.Drawing.Size(75, 23);
            this.clearExpBtn.TabIndex = 1;
            this.clearExpBtn.Text = "Clear";
            this.clearExpBtn.UseVisualStyleBackColor = true;
            this.clearExpBtn.Click += new System.EventHandler(this.clearExpBtn_Click);
            // 
            // saveExpBtn
            // 
            this.saveExpBtn.Location = new System.Drawing.Point(310, 86);
            this.saveExpBtn.Name = "saveExpBtn";
            this.saveExpBtn.Size = new System.Drawing.Size(75, 23);
            this.saveExpBtn.TabIndex = 2;
            this.saveExpBtn.Text = "Save";
            this.saveExpBtn.UseVisualStyleBackColor = true;
            this.saveExpBtn.Click += new System.EventHandler(this.saveExpBtn_Click);
            // 
            // testExpBtn
            // 
            this.testExpBtn.Location = new System.Drawing.Point(163, 86);
            this.testExpBtn.Name = "testExpBtn";
            this.testExpBtn.Size = new System.Drawing.Size(75, 23);
            this.testExpBtn.TabIndex = 3;
            this.testExpBtn.Text = "Test";
            this.testExpBtn.UseVisualStyleBackColor = true;
            this.testExpBtn.Click += new System.EventHandler(this.testExpBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Match Expression:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Text To Test Regex On:";
            // 
            // testTB
            // 
            this.testTB.Location = new System.Drawing.Point(9, 60);
            this.testTB.Name = "testTB";
            this.testTB.Size = new System.Drawing.Size(376, 20);
            this.testTB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(200, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Replacement Expression:";
            // 
            // replaceRegexTB
            // 
            this.replaceRegexTB.Location = new System.Drawing.Point(200, 21);
            this.replaceRegexTB.Name = "replaceRegexTB";
            this.replaceRegexTB.Size = new System.Drawing.Size(185, 20);
            this.replaceRegexTB.TabIndex = 7;
            // 
            // CustomEffectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 116);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.replaceRegexTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.testTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.testExpBtn);
            this.Controls.Add(this.saveExpBtn);
            this.Controls.Add(this.clearExpBtn);
            this.Controls.Add(this.matchRegexTB);
            this.Name = "CustomEffectForm";
            this.ShowInTaskbar = false;
            this.Text = "Create Effect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox matchRegexTB;
        private System.Windows.Forms.Button clearExpBtn;
        private System.Windows.Forms.Button saveExpBtn;
        private System.Windows.Forms.Button testExpBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox testTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox replaceRegexTB;
    }
}