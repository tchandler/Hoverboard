using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Hoverboard
{
    public partial class CustomEffectForm : Form
    {

        #region Constructor

        public CustomEffectForm()
        {
            InitializeComponent();
            matchRegexTB.Text = Effects.CustomEffectMatch;
            replaceRegexTB.Text = Effects.CustomEffectReplace;

        }

        #endregion

        #region Button Listeners

        /// <summary>
        /// Clears text in the boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearExpBtn_Click(object sender, EventArgs e)
        {
            matchRegexTB.Text = "";
            replaceRegexTB.Text = "";
            testTB.Text = "";
        }

        /// <summary>
        /// Tests the chosen match/replacement on the test text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void testExpBtn_Click(object sender, EventArgs e)
        {
            testTB.Text = Regex.Replace(testTB.Text, matchRegexTB.Text, replaceRegexTB.Text);
        }

        /// <summary>
        /// Saves the match/replacement strings for use as the custom command
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveExpBtn_Click(object sender, EventArgs e)
        {
            Effects.CustomEffectMatch = matchRegexTB.Text;
            Effects.CustomEffectReplace = replaceRegexTB.Text;
        }

        #endregion

    }
}