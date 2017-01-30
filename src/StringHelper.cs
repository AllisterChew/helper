using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public class StringHelper
    {
        public string ToCamelCase(string input)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

            return textInfo.ToTitleCase(input);
        }

        public string TruncateWord(string input, int length)
        {
            if ( String.IsNullOrEmpty(input) || input.Length < length || input.IndexOf(" ", length) == -1)
                return input;

            return String.Format("{0}...", input.Substring(0, input.IndexOf(" ", length)));
        }

        public int StringToInt(string input)
        {
            int value = 0;

            if(!Int32.TryParse(input, out value))
            {
                return -1;
            }

            return value;
        }
    }
}
