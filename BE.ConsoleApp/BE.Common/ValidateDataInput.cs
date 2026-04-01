using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BE.Common
{
    public static class ValidateDataInput
    {
        public static bool ChecValidatenumber(string inputNumber)
        {
            return int.TryParse(inputNumber, out _);
        }
        public static bool CheckValidateString(string inputString)
        {
            if (string.IsNullOrEmpty(inputString)) return false;
            if(int.TryParse(inputString, out int num )) return false;
            //if (DateTime.TryParse(inputString, "")) return false
            if(inputString.Length > 200) return false;
            return true;
        }
        public static bool CheckSpecicalCharactor(string inputString)
        {
            var regexItem = new Regex("^[a-zA-Z0-9_]*$"); ;
            if (!regexItem.IsMatch(inputString)) return false;
            return true;
        }
        public static bool CheckXSSInput(string input)
        {
            try
            {
                var listDangerousString = new List<string>()
                {
                    "<script", "</script>",
                    "<object", "</object>",
                    "<embed", "</embed>",
                    "<applet", "</applet>",
                    "<iframe", "</iframe>",
                    "<frame", "</frame>",
                    "<frameset", "</frameset>",
                    "<base",
                    "<meta",
                    "<link",
                    "<style", "</style>",
                    "<svg", "</svg>",
                    "<math", "</math>",
                    "<bgsound",
                    "<ilayer", "<layer",
                    "javascript:",
                    "vbscript:",
                    "livescript:",
                    "mocha:",
                    "data:text/html",
                    "data:image/svg+xml",
                    "eval(",
                    "setTimeout(",
                    "setInterval(",
                    "Function(",
                    "alert(",
                    "prompt(",
                    "confirm(",
                    "document.cookie",
                    "document.write",
                    "window.location",
                    "onload=",
                    "onerror=",
                    "onunload=",
                    "onmouseover=",
                    "onmouseout=",
                    "onmouseenter=",
                    "onmouseleave=",
                    "onclick=",
                    "ondblclick=",
                    "onmousedown=",
                    "onmouseup=",
                    "onmousemove=",
                    "onfocus=",
                    "onblur=",
                    "onsubmit=",
                    "onreset=",
                    "onchange=",
                    "onselect=",
                    "onkeydown=",
                    "onkeyup=",
                    "onkeypress=",
                    "onmousewheel=",
                    "onscroll=",
                    "ondrag=",
                    "ondrop=",
                    "oncopy=",
                    "onpaste=",
                    "oncut=",
                    "onpointerdown=",
                    "ontoggle=",
                    "onwheel="
                };
                if (string.IsNullOrEmpty(input)) return false;
                foreach (var dangerous in listDangerousString)
                {
                    if (input.Trim().ToLower().IndexOf(dangerous) >= 0) return false;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
