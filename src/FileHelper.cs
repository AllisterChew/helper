using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public class FileHelper
    {
        public string ReadFileAsText(string path)
        {
            string text = System.IO.File.ReadAllText(path);

            return text;
        }
    }
}
