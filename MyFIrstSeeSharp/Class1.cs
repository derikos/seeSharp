using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFIrstSeeSharp
{
    class Algorithms
    {
        public static bool VerifyIfUnique(string s)
        {
            for (int j = 0; j < s.Length; j++)
            {
                char tempChar = s[j];
                for (int i = j + 1; i < s.Length; i++)
                {
                    if (tempChar == s[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
