using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto
{
    class Filter
    {
        public static string RemoveSpecialCharacters(string str, bool withSpaces)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if(withSpaces)
                {
                    if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == ' ')
                    {
                        sb.Append(c);
                    }
                }
                else
                {
                    if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                    {
                        sb.Append(c);
                    }
                }
                
            }
            return sb.ToString().ToLower();
        }      
    }
}
