using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surya.Learning.Strings
    {
    class StringHelper
        {
        public static string Reverse (string inputString)
            {
            char[] charArray = inputString.ToArray ();
            for (int i = 0, j = inputString.Length - 1; i < j; i++, j--)
                {
                char c = charArray[i];
                charArray[i] = charArray[j];
                charArray[j] = c;
                }

            return new String (charArray);
            }
        }
    }
