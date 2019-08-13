using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LanguageExtensionsLibrary
{
    public static class StringExtensions
    {
        /// <summary>
        /// Given a string with upper and lower cased letters separate them before each upper cased characters
        /// </summary>
        /// <param name="sender">String to work against</param>
        /// <returns>String with spaces between upper-case letters</returns>
        public static string SplitCamelCase(this string sender)
        {
            var item = Regex.Replace(
                Regex.Replace(sender, @"(\P{Ll})(\P{Ll}\p{Ll})", "$1 $2"), 
                @"(\p{Ll})(\P{Ll})", "$1 $2");

            var options = RegexOptions.None;
            var regex = new Regex("[ ]{2,}", options);

            return regex.Replace(item, " ");
        }
        /// <summary>
        /// Determine if string is empty
        /// </summary>
        /// <param name="sender">String to test if null or whitespace</param>
        /// <returns>true if empty or false if not empty</returns>
        public static bool IsNullOrWhiteSpace(this string sender)
        {
            return string.IsNullOrWhiteSpace(sender);
        }
    }
}
