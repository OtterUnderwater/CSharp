using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Library7Inheritance
{
    internal class BaseClass5
    {
        protected string str;
        public BaseClass5(string str)
        {
            this.str = str;
        }
        public virtual string GetText()
        {
            return str;
        }
    }

    internal class NewClass5 : BaseClass5
    {
        protected string str2;

        public NewClass5(string str, string str2) : base(str)
        {
            this.str2 = str2;
        }

        public override string GetText()
        {
            return str + " " + str2;
        }

        public void SplitText(string str3)
        {
            string[] parts = str3.Split(' ');
            if (parts.Length >= 2)
            {
                str = parts[0];
                str2 = parts[1];
            }
            else
            {
                str = str3;
                str2 = "";
            }
        }

        public override string ToString()
        {
            return $"NewClass5: {str} {str2}";
        }
    }
}
