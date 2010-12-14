using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GlobalInput;


namespace Hoverboard
{
    public partial class HoverboardForm : System.Windows.Forms.Form
    {

        ShortcutKeys shortcutKeyHandler = new ShortcutKeys();
        #region Constructor

        public HoverboardForm()
        {
            InitializeComponent();
            
            #region Global Hook Stuff

            ShortcutKeys.actHook = new UserActivityHook(); // crate an instance with global hooks

            //global input listeners
            ShortcutKeys.actHook.OnMouseActivity += new MouseEventHandler(MouseMoved);
            ShortcutKeys.actHook.KeyDown += new KeyEventHandler(MyKeyDown);
            ShortcutKeys.actHook.KeyPress += new KeyPressEventHandler(MyKeyPress);
            ShortcutKeys.actHook.KeyUp += new KeyEventHandler(MyKeyUp);

            #endregion

            //local listeners for various purposes
            this.Resize += new EventHandler(Form1_Resize);
            trayIcon.DoubleClick += new EventHandler(trayIcon_DoubleClick);
            this.SizeChanged += new EventHandler(MonsterClipboardForm_SizeChanged);

            //initial setup
            tbClipboard.Text = Clipboard.GetText();
            lowerCaseToolStripMenuItem.Checked = true;
        }

        #endregion

        #region Private Methods

        private void UpdateEffects(SelectedEffect se)
        {
            //set current effect
            Effects.CurrentEffect = se;
            
            //clear check marks
            //is there a better way to do this?
            lowerCaseToolStripMenuItem.Checked = false;
            lowerCaseMenuItem.Checked = false;

            titleCaseToolStripMenuItem.Checked = false;
            titleCaseMenuItem.Checked = false;
            
            removeSpacesToolStripMenuItem.Checked = false;
            removeSpacesMenuItem.Checked = false;
            
            upperCaseToolStripMenuItem.Checked = false;
            upperCaseMenuItem.Checked = false;
            
            customToolStripMenuItem.Checked = false;
            customMenuItem.Checked = false;
            
            oneLineToolStripMenuItem.Checked = false;
            oneLineMenuItem.Checked = false;

            //check off the good ones
            switch (se)
            {
                case SelectedEffect.Custom:
                    customToolStripMenuItem.Checked = true;
                    customMenuItem.Checked = true;
                    break;
                case SelectedEffect.LowerCase:
                    lowerCaseToolStripMenuItem.Checked = true;
                    lowerCaseMenuItem.Checked = true;
                    break;
                case SelectedEffect.OneLine:
                    oneLineToolStripMenuItem.Checked = true;
                    oneLineMenuItem.Checked = true;
                    break;
                case SelectedEffect.RemoveSpaces:
                    removeSpacesToolStripMenuItem.Checked = true;
                    removeSpacesMenuItem.Checked = true;
                    break;
                case SelectedEffect.TitleCase:
                    titleCaseToolStripMenuItem.Checked = true;
                    titleCaseMenuItem.Checked = true;
                    break;
                case SelectedEffect.UpperCase:
                    upperCaseToolStripMenuItem.Checked = true;
                    upperCaseMenuItem.Checked = true;
                    break;
            }
        }

        #endregion

        #region Event Methods

        #region Form Event Methods

        void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
        }

        void MonsterClipboardForm_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                restoreMenuItem.Enabled = true;
            else
                restoreMenuItem.Enabled = false;
        }

        #endregion

        #region Tray Icon Event Methods

        void trayIcon_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void restoreMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void closeMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutTrayItem_Click(object sender, EventArgs e)
        {
            new AboutForm().Show();
        }

        #region Tray Effect Selection

        private void lowerCaseMenuItem_Click(object sender, EventArgs e)
        {
            UpdateEffects(SelectedEffect.LowerCase);
        }

        private void upperCaseMenuItem_Click(object sender, EventArgs e)
        {
            UpdateEffects(SelectedEffect.UpperCase);
        }

        private void titleCaseMenuItem_Click(object sender, EventArgs e)
        {
            UpdateEffects(SelectedEffect.TitleCase);
        }

        private void removeSpacesMenuItem_Click(object sender, EventArgs e)
        {
            UpdateEffects(SelectedEffect.RemoveSpaces);
        }

        private void oneLineMenuItem_Click(object sender, EventArgs e)
        {
            UpdateEffects(SelectedEffect.OneLine);
        }

        private void customMenuItem_Click(object sender, EventArgs e)
        {
            UpdateEffects(SelectedEffect.Custom);
        }

        #endregion

        #endregion  

        #region Global Input Event Methods

        void MouseMoved(object sender, MouseEventArgs e)
        {
            //throw new Exception("The method or operation is not implemented.");
        }

        void MyKeyUp(object sender, KeyEventArgs e)
        {
            if (ShortcutKeys.currentKeys.Contains(e.KeyCode))
                ShortcutKeys.currentKeys.Remove(e.KeyCode);
        }

        void MyKeyPress(object sender, KeyPressEventArgs e)
        {
            //throw new Exception("The method or operation is not implemented.");
        }

        void MyKeyDown(object sender, KeyEventArgs e)
        {               
            if (!ShortcutKeys.currentKeys.Contains(e.KeyCode))
                ShortcutKeys.currentKeys.Add(e.KeyCode);

            if (shortcutKeyHandler.ShortcutPressed())
            {
                if (!Clipboard.GetText().Equals(""))
                {
                    Clipboard.SetText(Effects.ApplySelectedEffect(Clipboard.GetText()));
                    tbClipboard.Text = Clipboard.GetText();
                }
            }
        }

        #endregion

        #region Button Event Methods

        private void pasteBtn_Click(object sender, EventArgs e)
        {
            tbClipboard.Text = Clipboard.GetText();
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbClipboard.Text);
        }

        private void applyEffectBtn_Click(object sender, EventArgs e)
        {
            tbClipboard.Text = Effects.ApplySelectedEffect(tbClipboard.Text);
            Clipboard.SetText(tbClipboard.Text);
        }

        #endregion

        #region Menu Event Methods

        private void defineShortcutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ShortcutDefineForm().Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void customEffectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CustomEffectForm().Show();
        }

        private void aboutStripMenuItem1_Click(object sender, EventArgs e)
        {
            new AboutForm().Show();
        }

        #region Effect Selection Methods

        private void lowerCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateEffects(SelectedEffect.LowerCase);
        }

        private void upperCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateEffects(SelectedEffect.UpperCase);
        }

        private void titleCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateEffects(SelectedEffect.TitleCase);
        }

        private void removeSpacesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateEffects(SelectedEffect.RemoveSpaces);
        }

        private void oneLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateEffects(SelectedEffect.OneLine);
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateEffects(SelectedEffect.Custom);
        }

        #endregion

        private void MonsterClipboardForm_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #endregion
    }
}