using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using GlobalInput;

namespace Hoverboard
{
    class ShortcutKeys
    {
        #region Public Fields

        public static List<Keys> shortcut = new List<Keys>(2); //Current shortcut
        public static List<Keys> currentKeys = new List<Keys>(); //Currently pressed keys
        public static UserActivityHook actHook; //Global input library

        #endregion

        #region Public Constructor

        public ShortcutKeys()
        {
            SetUp();
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Sets up or restores defaults
        /// </summary>
        private void SetUp()
        {
            shortcut.Clear();
            shortcut.Add(Keys.L);
            shortcut.Add(Keys.LControlKey);            
        }

        /// <summary>
        /// Sets user picked custom key combos
        /// </summary>
        /// <param name="customShortcut"></param>
        public static void SetCustomShortcutKeys(List<Keys> customShortcut)
        {
            shortcut[0] = customShortcut[0];
            shortcut[1] = customShortcut[1];
        }

        /// <summary>
        /// Checks currently pressed keys against designated shortcut
        /// </summary>
        /// <returns></returns>
        public bool ShortcutPressed()
        {
            int matches = 0;
            int matchesNeeded = shortcut.Count;
            Console.WriteLine("Shortcut Keys(" + shortcut.Count + "): " + shortcut[0].ToString() + " and " + shortcut[1].ToString());
            for (int i = 0, currentCount = currentKeys.Count; i < currentCount; i++)
            {
                Console.WriteLine(currentKeys[i].ToString());
                if(shortcut.Contains(currentKeys[i]))
                    matches++;
                if (matches == matchesNeeded)
                {
                    Console.WriteLine("Keys Pressed");
                    return true;
                }
            }
            return false;
        }

        #endregion
    }
}
