using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkDataModel.Helper
{
    public static class HelperMethod
    {
        public  static string ChangeCharacter(string text)
        {
            text = text.ToLower();
            return text.Replace('ş', 's').
                         Replace('ç', 'c').
                         Replace('ğ', 'g').
                         Replace('ü', 'u').
                         Replace('ı', 'i').
                         Replace('ö', 'o').
                         Replace(' ', '-').
                         Replace("?", "").
                         Replace(",", "").
                         Replace(".", "").
                         Replace("\"", "").
                         Replace("#", "").
                         Replace("*", "-").
                         Replace("'", "").
                         Replace("/", "-").
                         Replace("<", "").
                         Replace(">", "").
                         Replace(";", "").
                         Replace(":", "").
                         Replace("=", "").
                         Replace("&", "").
                         Replace("+", "").
                         Replace("$", "").
                         Replace("%", "").
                         Replace("~", "").
                         Replace("(", "").
                         Replace(")", "").
                         Replace("{", "").
                         Replace("}", "").
                         Replace("!", "").
                         Replace("|", "").
                         Replace("^", "").
                         Replace("[", "").
                         Replace("]", "").
                         Replace("@", "");

        }
    }
}