using System;
using System.Collections.Generic;
using System.Windows.Forms;

/* *****************MonstrousClipboard*****************
 * Created by Thomas Chandler (The Yeti)
 * May 28th, 2008
 * 
 * Uses UserActivityHook.cs by George Mamaladze
 * http://www.codeproject.com/KB/cs/globalhook.aspx
 * ***************************************************/

namespace Hoverboard
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HoverboardForm());
        }
    }
}