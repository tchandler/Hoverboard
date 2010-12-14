namespace Hoverboard
{
    partial class ShortcutDefineForm
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
            this.setBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.key1CB = new System.Windows.Forms.ComboBox();
            this.key2CB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // setBtn
            // 
            this.setBtn.Location = new System.Drawing.Point(12, 90);
            this.setBtn.Name = "setBtn";
            this.setBtn.Size = new System.Drawing.Size(75, 23);
            this.setBtn.TabIndex = 1;
            this.setBtn.Text = "Set";
            this.setBtn.UseVisualStyleBackColor = true;
            this.setBtn.Click += new System.EventHandler(this.setBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Shortcut:";
            // 
            // key1CB
            // 
            this.key1CB.FormattingEnabled = true;
            this.key1CB.Location = new System.Drawing.Point(13, 34);
            this.key1CB.Name = "key1CB";
            this.key1CB.Size = new System.Drawing.Size(86, 21);
            this.key1CB.TabIndex = 3;
            // 
            // key2CB
            // 
            this.key2CB.FormattingEnabled = true;
            this.key2CB.Location = new System.Drawing.Point(124, 34);
            this.key2CB.Name = "key2CB";
            this.key2CB.Size = new System.Drawing.Size(86, 21);
            this.key2CB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "+";
            // 
            // ShortcutDefineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 129);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.key2CB);
            this.Controls.Add(this.key1CB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setBtn);
            this.Name = "ShortcutDefineForm";
            this.ShowInTaskbar = false;
            this.Text = "Define Shortcut";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button setBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox key1CB;
        private System.Windows.Forms.ComboBox key2CB;
        private System.Windows.Forms.Label label2;
    }
}