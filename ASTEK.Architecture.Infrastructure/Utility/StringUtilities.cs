using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.Infrastructure.Utility
{
    public static class StringUtilities
    {
        public static bool IsNotNullOrWhiteSpace(string element)
        {
            return !string.IsNullOrWhiteSpace(element);
        }

        public static bool MinimumLength(string element, int minLength)
        {   
            return (element.Length >= minLength);
        }

        public static string UserName(string firstName, string name)
        {
            var builder = new StringBuilder();
            builder.Append(firstName);
            builder.Append(" ");
            builder.Append(name);

            return builder.ToString();
        }

        public static string LimitTextLength(string text, int length)
        {
            if(text.Length <= length)
            {
                return text;
            }

            var sb = new StringBuilder();
            sb.Append(text.Substring(0, length));
            sb.Append("...");

            return sb.ToString();
        }

        public static string GetListFormated(string target)
        {
            string result = target;

            if (result.StartsWith("-"))
            {
                result = result.Substring(1);
            }

            result = result.Replace("\n-", ConfigurationManager.AppSettings.Get("TargetSeparator"));

            return result;
        }

        public static string GetListFromFormated(string listFormated)
        {
            string result = listFormated;

            result = result.Replace(ConfigurationManager.AppSettings.Get("TargetSeparator"), "\n-");

            result = string.Concat("-", result);

            return result;
        }
    }
}
