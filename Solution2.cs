using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CousantAssessment
{
   public class Solution2
    {
        public void Encrypt(string textToEncrypt)
        {
           
            string word = textToEncrypt;
            var encryptedValue = new StringBuilder();
            
            var wordArray = word.ToCharArray();
                foreach (var item in wordArray)
                {
                    if (Enum.IsDefined(typeof(oddAlphabets), item.ToString())
                        || Enum.IsDefined(typeof(oddAlphabets), item.ToString().ToLower()))
                    {
                        var result = encryptOdd(item.ToString().ToLower());
                        encryptedValue.Append(result);
                    }
                    else
                    {
                        var result = encryptEven(item.ToString().ToLower());
                        encryptedValue.Append(result);
                    }
                }
            Console.WriteLine(encryptedValue);

        }


        public static string encryptOdd(string letter)
        {
            var result = string.Empty;
            foreach (var item in Enum.GetValues(typeof(oddAlphabets)))
            {
                if (item.ToString() == letter)
                {
                    var oddNum = (((int)Enum.Parse(typeof(oddAlphabets), letter)) * 3) + 1;
                    result = $"o{oddNum}";
                    break;
                }
            }
            return result;
        }

        public static string encryptEven(string letter)
        {
            var result = string.Empty;
            foreach (var item in Enum.GetValues(typeof(evenAlphabets)))
            {
                if (item.ToString() == letter)
                {
                    var evenNum = ((int)Enum.Parse(typeof(evenAlphabets), letter)) / 2;
                    result = $"e{evenNum}";
                    break;
                }
            }
            return result;
        }

        enum oddAlphabets
        {
            a = 1, c = 3, e = 5, g = 7, i = 9, k = 11, m = 13, o = 15, q = 17, s = 19, u = 21, w = 23, y = 25
        }

        enum evenAlphabets
        {
            b = 2, d = 4, f = 6, h = 8, j = 10, l = 12, n = 14, p = 16, r = 18, t = 20, v = 22, x = 24, z = 26
        }
    }
}
