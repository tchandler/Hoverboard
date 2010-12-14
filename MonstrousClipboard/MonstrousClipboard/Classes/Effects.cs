using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Hoverboard
{
    /// <summary>
    /// Class containing the different effects built into the program
    /// as well as handling storage and application of custom regex
    /// 
    /// Later versions might make it possible to load custom effect
    /// sets from files, probably xml based, but for now only one custom
    /// regex may be stored
    /// </summary>
    static class Effects
    {

        #region Properties

        // A regular expression for custom effects
        static private String customEffectMatch = "";

        static public String CustomEffectMatch
        {
            get { return customEffectMatch; }
            set { customEffectMatch = value; }
        }

        //semi-regex, replacement text
        //has some intersting formatting possibilites
        //need to document them in the program so users know
        //what options they have for this
        static private String customEffectReplace = "";

        static public String CustomEffectReplace
        {
            get { return customEffectReplace; }
            set { customEffectReplace = value; }
        }

        //The current active effect, defaults to LowerCase
        static private SelectedEffect currentEffect = SelectedEffect.LowerCase;

        static public SelectedEffect CurrentEffect
        {
            get { return currentEffect; }
            set { currentEffect = value; }
        }

        #endregion


        #region Effect Methods

        /// <summary>
        /// Sends clipboard text to appropriate method based on SelectedEffect
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        static public String ApplySelectedEffect(String input)
        {
            switch(currentEffect)
            {
                case SelectedEffect.LowerCase:
                    return LowerCase(input);
                    
                case SelectedEffect.RemoveSpaces:
                    return RemoveSpaces(input);
                    
                case SelectedEffect.UpperCase:
                    return UpperCase(input);
                    
                case SelectedEffect.TitleCase:
                    return TitleCase(input);

                case SelectedEffect.OneLine:
                    return OneLine(input);
                    
                case SelectedEffect.Custom:
                    return ApplyCustom(input);
                    
            }
            return input;
        }

        /// <summary>
        /// Removes spaces from entire string
        /// (TODO: Make this remove tabs or create separate tab removal)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        static private String RemoveSpaces(String input)
        {
            return input.Replace(" ", "");
        }

        /// <summary>
        /// Applies Lower Case to entire string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        static private String LowerCase(String input)
        {
            return input.ToLower();
        }

        /// <summary>
        /// Applies Upper Case to entire string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        static private String UpperCase(String input)
        {
            return input.ToUpper();
        }

        /// <summary>
        /// Applies Title Casing
        /// (Title Casing is capitalizing the 
        /// first letter of each word)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        static private String TitleCase(String input)
        {
            String[] words = input.Split(' ');
            StringBuilder sb = new StringBuilder();
            for (int i = 0, wordsLength = words.Length; i < wordsLength; i++)
            {
                if (words[i] == "")
                {
                    sb.Append(words[i]);
                }
                else
                {
                    sb.Append(words[i].Substring(0, 1).ToUpper());
                    sb.Append(words[i].Substring(1).ToLower());
                }
                if (i != wordsLength - 1)
                    sb.Append(" ");
            }
            return sb.ToString();
        }

        /// <summary>
        /// Removes linebreaks (both \n and \r)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        static private String OneLine(String input)
        {
            return input.Replace("\n", "").Replace("\r", "");
        }

        /// <summary>
        /// Applies user-defined effect
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        static private String ApplyCustom(String input)
        {
            return Regex.Replace(input, customEffectMatch, customEffectReplace);
        }

        #endregion
    }

    /// <summary>
    /// Enumerator for selectable effects
    /// </summary>
    enum SelectedEffect
    {
        RemoveSpaces, LowerCase, UpperCase, TitleCase, OneLine, Custom
    }

}
