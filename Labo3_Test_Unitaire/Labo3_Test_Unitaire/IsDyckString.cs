using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo3_Test_Unitaire
{
    public class Dyck
    {
        /*
        @pre -
        @post The returned value contains true if ’s’ is a Dyck word
        given that the alphabet only contains ’(’ and ’)’
        and false otherwise
        */
        public static bool IsDyckString(string s)
        {
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;

            for (int i = 0; i < s.Length; i++)
            {   
                // not a good method because if we use other values to long, imgaine 36 different pairs.
                while ((count1 >= 0) && (count2 >= 0) && (count3 >= 0))
                {
                    switch (s[i])
                    {
                        case '(':
                            {
                                count1 += 1;
                                break;
                            }
                        case '[':
                            {
                                count2 += 1;
                                break;
                            }
                        case '{':
                            {
                                count3 += 1;
                                break;
                            }
                        case ')':
                            {
                                count1 -= 1;
                                break;
                            }
                        case ']':
                            {
                                count2 -= 1;
                                break;
                            }
                        case '}':
                            {
                                count3 -= 1;
                                break;
                            }
                    }
                    if ((count1 < 0) || (count2 < 0) || (count3 < 0))
                    {
                        return false;
                    }
                }
            }
            return ((count1 == 0) && (count2 == 0) && (count3 == 0));
        }
    }
}
