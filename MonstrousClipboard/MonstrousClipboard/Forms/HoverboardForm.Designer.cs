namespace Hoverboard
{
    partial class HoverboardForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoverboardForm));
            this.pasteBtn = new System.Windows.Forms.Button();
            this.tbClipboard = new System.Windows.Forms.TextBox();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayContextMenu = new System.Windows.Forms.ContextMenu();
            this.restoreMenuItem = new System.Windows.Forms.MenuItem();
            this.closeMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.lowerCaseMenuItem = new System.Windows.Forms.MenuItem();
            this.upperCaseMenuItem = new System.Windows.Forms.MenuItem();
            this.titleCaseMenuItem = new System.Windows.Forms.MenuItem();
            this.removeSpacesMenuItem = new System.Windows.Forms.MenuItem();
            this.oneLineMenuItem = new System.Windows.Forms.MenuItem();
            this.customMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.aboutTrayItem = new System.Windows.Forms.MenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defineShortcutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.effectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.builtInEffectsStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lowerCaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upperCaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleCaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSpacesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oneLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customEffectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.applyEffectBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pasteBtn
            // 
            this.pasteBtn.Location = new System.Drawing.Point(93, 249);
            this.pasteBtn.Name = "pasteBtn";
            this.pasteBtn.Size = new System.Drawing.Size(75, 23);
            this.pasteBtn.TabIndex = 1;
            this.pasteBtn.Text = "Refresh";
            this.pasteBtn.UseVisualStyleBackColor = true;
            this.pasteBtn.Click += new System.EventHandler(this.pasteBtn_Click);
            // 
            // tbClipboard
            // 
            this.tbClipboard.BackColor = System.Drawing.Color.White;
            this.tbClipboard.Enabled = false;
            this.tbClipboard.Location = new System.Drawing.Point(12, 45);
            this.tbClipboard.Multiline = true;
            this.tbClipboard.Name = "tbClipboard";
            this.tbClipboard.Size = new System.Drawing.Size(462, 198);
            this.tbClipboard.TabIndex = 2;
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenu = this.trayContextMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "MonsterClipboard";
            this.trayIcon.Visible = true;
            // 
            // trayContextMenu
            // 
            this.trayContextMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.restoreMenuItem,
            this.closeMenuItem,
            this.menuItem9,
            this.menuItem2,
            this.menuItem1,
            this.aboutTrayItem});
            // 
            // restoreMenuItem
            // 
            this.restoreMenuItem.Enabled = false;
            this.restoreMenuItem.Index = 0;
            this.restoreMenuItem.Text = "Restore";
            this.restoreMenuItem.Click += new System.EventHandler(this.restoreMenuItem_Click);
            // 
            // closeMenuItem
            // 
            this.closeMenuItem.Index = 1;
            this.closeMenuItem.Text = "Close";
            this.closeMenuItem.Click += new System.EventHandler(this.closeMenuItem_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 2;
            this.menuItem9.Text = "-";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 3;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.lowerCaseMenuItem,
            this.upperCaseMenuItem,
            this.titleCaseMenuItem,
            this.removeSpacesMenuItem,
            this.oneLineMenuItem,
            this.customMenuItem});
            this.menuItem2.Text = "Effect";
            // 
            // lowerCaseMenuItem
            // 
            this.lowerCaseMenuItem.Index = 0;
            this.lowerCaseMenuItem.Text = "Lower Case";
            this.lowerCaseMenuItem.Click += new System.EventHandler(this.lowerCaseMenuItem_Click);
            // 
            // upperCaseMenuItem
            // 
            this.upperCaseMenuItem.Index = 1;
            this.upperCaseMenuItem.Text = "Upper Case";
            this.upperCaseMenuItem.Click += new System.EventHandler(this.upperCaseMenuItem_Click);
            // 
            // titleCaseMenuItem
            // 
            this.titleCaseMenuItem.Index = 2;
            this.titleCaseMenuItem.Text = "Title Case";
            this.titleCaseMenuItem.Click += new System.EventHandler(this.titleCaseMenuItem_Click);
            // 
            // removeSpacesMenuItem
            // 
            this.removeSpacesMenuItem.Index = 3;
            this.removeSpacesMenuItem.Text = "Remove Spaces";
            this.removeSpacesMenuItem.Click += new System.EventHandler(this.removeSpacesMenuItem_Click);
            // 
            // oneLineMenuItem
            // 
            this.oneLineMenuItem.Index = 4;
            this.oneLineMenuItem.Text = "One-Line";
            this.oneLineMenuItem.Click += new System.EventHandler(this.oneLineMenuItem_Click);
            // 
            // customMenuItem
            // 
            this.customMenuItem.Index = 5;
            this.customMenuItem.Text = "Custom";
            this.customMenuItem.Click += new System.EventHandler(this.customMenuItem_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 4;
            this.menuItem1.Text = "-";
            // 
            // aboutTrayItem
            // 
            this.aboutTrayItem.Index = 5;
            this.aboutTrayItem.Text = "About...";
            this.aboutTrayItem.Click += new System.EventHandler(this.aboutTrayItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.effectsToolStripMenuItem,
            this.helpStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(490, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defineShortcutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // defineShortcutToolStripMenuItem
            // 
            this.defineShortcutToolStripMenuItem.Name = "defineShortcutToolStripMenuItem";
            this.defineShortcutToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.defineShortcutToolStripMenuItem.Size = new System.Drawing.Size(172, 20);
            this.defineShortcutToolStripMenuItem.Text = "Define Shortcut...";
            this.defineShortcutToolStripMenuItem.Click += new System.EventHandler(this.defineShortcutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // effectsToolStripMenuItem
            // 
            this.effectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.builtInEffectsStripMenuItem1,
            this.customEffectToolStripMenuItem});
            this.effectsToolStripMenuItem.Name = "effectsToolStripMenuItem";
            this.effectsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.effectsToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.effectsToolStripMenuItem.Text = "Effects";
            // 
            // builtInEffectsStripMenuItem1
            // 
            this.builtInEffectsStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lowerCaseToolStripMenuItem,
            this.upperCaseToolStripMenuItem,
            this.titleCaseToolStripMenuItem,
            this.removeSpacesToolStripMenuItem,
            this.oneLineToolStripMenuItem,
            this.customToolStripMenuItem});
            this.builtInEffectsStripMenuItem1.Name = "builtInEffectsStripMenuItem1";
            this.builtInEffectsStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.builtInEffectsStripMenuItem1.Text = "Selected Effect";
            // 
            // lowerCaseToolStripMenuItem
            // 
            this.lowerCaseToolStripMenuItem.Name = "lowerCaseToolStripMenuItem";
            this.lowerCaseToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.lowerCaseToolStripMenuItem.Text = "Lower Case";
            this.lowerCaseToolStripMenuItem.Click += new System.EventHandler(this.lowerCaseToolStripMenuItem_Click);
            // 
            // upperCaseToolStripMenuItem
            // 
            this.upperCaseToolStripMenuItem.Name = "upperCaseToolStripMenuItem";
            this.upperCaseToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.upperCaseToolStripMenuItem.Text = "Upper Case";
            this.upperCaseToolStripMenuItem.Click += new System.EventHandler(this.upperCaseToolStripMenuItem_Click);
            // 
            // titleCaseToolStripMenuItem
            // 
            this.titleCaseToolStripMenuItem.Name = "titleCaseToolStripMenuItem";
            this.titleCaseToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.titleCaseToolStripMenuItem.Text = "Title Case";
            this.titleCaseToolStripMenuItem.Click += new System.EventHandler(this.titleCaseToolStripMenuItem_Click);
            // 
            // removeSpacesToolStripMenuItem
            // 
            this.removeSpacesToolStripMenuItem.Name = "removeSpacesToolStripMenuItem";
            this.removeSpacesToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.removeSpacesToolStripMenuItem.Text = "Remove Spaces";
            this.removeSpacesToolStripMenuItem.Click += new System.EventHandler(this.removeSpacesToolStripMenuItem_Click);
            // 
            // oneLineToolStripMenuItem
            // 
            this.oneLineToolStripMenuItem.Name = "oneLineToolStripMenuItem";
            this.oneLineToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.oneLineToolStripMenuItem.Text = "One-Line";
            this.oneLineToolStripMenuItem.Click += new System.EventHandler(this.oneLineToolStripMenuItem_Click);
            // 
            // customToolStripMenuItem
            // 
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            this.customToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.customToolStripMenuItem.Text = "Custom";
            this.customToolStripMenuItem.Click += new System.EventHandler(this.customToolStripMenuItem_Click);
            // 
            // customEffectToolStripMenuItem
            // 
            this.customEffectToolStripMenuItem.Name = "customEffectToolStripMenuItem";
            this.customEffectToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.customEffectToolStripMenuItem.Text = "Edit Custom...";
            this.customEffectToolStripMenuItem.Click += new System.EventHandler(this.customEffectToolStripMenuItem_Click);
            // 
            // helpStripMenuItem1
            // 
            this.helpStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToUseToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutStripMenuItem1});
            this.helpStripMenuItem1.Name = "helpStripMenuItem1";
            this.helpStripMenuItem1.Size = new System.Drawing.Size(40, 20);
            this.helpStripMenuItem1.Text = "Help";
            // 
            // howToUseToolStripMenuItem
            // 
            this.howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            this.howToUseToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.howToUseToolStripMenuItem.Text = "How To Use";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(139, 6);
            // 
            // aboutStripMenuItem1
            // 
            this.aboutStripMenuItem1.BackColor = System.Drawing.SystemColors.Control;
            this.aboutStripMenuItem1.Name = "aboutStripMenuItem1";
            this.aboutStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.aboutStripMenuItem1.Text = "About...";
            this.aboutStripMenuItem1.Click += new System.EventHandler(this.aboutStripMenuItem1_Click);
            // 
            // applyEffectBtn
            // 
            this.applyEffectBtn.Location = new System.Drawing.Point(12, 249);
            this.applyEffectBtn.Name = "applyEffectBtn";
            this.applyEffectBtn.Size = new System.Drawing.Size(75, 23);
            this.applyEffectBtn.TabIndex = 4;
            this.applyEffectBtn.Text = "Apply Effect";
            this.applyEffectBtn.UseVisualStyleBackColor = true;
            this.applyEffectBtn.Click += new System.EventHandler(this.applyEffectBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Clipboard Contents:";
            // 
            // HoverboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 282);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.applyEffectBtn);
            this.Controls.Add(this.tbClipboard);
            this.Controls.Add(this.pasteBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HoverboardForm";
            this.Text = "Hoverboard";
            this.Load += new System.EventHandler(this.MonsterClipboardForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Button pasteBtn;
        private System.Windows.Forms.TextBox tbClipboard;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenu trayContextMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem effectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem builtInEffectsStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lowerCaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upperCaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem titleCaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSpacesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customEffectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
        private System.Windows.Forms.MenuItem restoreMenuItem;
        private System.Windows.Forms.MenuItem closeMenuItem;
        private System.Windows.Forms.MenuItem aboutTrayItem;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.ToolStripMenuItem defineShortcutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button applyEffectBtn;
        private System.Windows.Forms.ToolStripMenuItem oneLineToolStripMenuItem;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem lowerCaseMenuItem;
        private System.Windows.Forms.MenuItem upperCaseMenuItem;
        private System.Windows.Forms.MenuItem titleCaseMenuItem;
        private System.Windows.Forms.MenuItem removeSpacesMenuItem;
        private System.Windows.Forms.MenuItem oneLineMenuItem;
        private System.Windows.Forms.MenuItem customMenuItem;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.Label label1;
    }
}

