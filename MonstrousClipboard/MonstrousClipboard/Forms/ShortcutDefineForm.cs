using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hoverboard
{
    public partial class ShortcutDefineForm : Form
    {
        #region Constructor

        public ShortcutDefineForm()
        {
            InitializeComponent();

            //Populate the comboboxes with all possible keys
            key1CB.DataSource = Enum.GetValues(typeof(Keys));
            key1CB.SelectedItem = ShortcutKeys.shortcut[0];
            
            key2CB.DataSource = Enum.GetValues(typeof(Keys));
            key2CB.SelectedItem = ShortcutKeys.shortcut[1];
        }

        #endregion

        #region Button Listener

        /// <summary>
        /// Sets the global shortcut to the chosen key combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setBtn_Click(object sender, EventArgs e)
        {
            List<Keys> newShortcut = new List<Keys>();
            newShortcut.Add((Keys)key1CB.SelectedItem);
            newShortcut.Add((Keys)key2CB.SelectedItem);
            ShortcutKeys.SetCustomShortcutKeys(newShortcut);
        }

        #endregion
    }
}