using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo3_Test_Unitaire
{
    class IsDickStringMain
    {

        public static bool IsDyckString(string s, Dictionary<string, string> alphabet)
        {
            Stack st = new Stack();
            // st.Push(3); to push something on the stack and st.Pop() to remove last added element
            try
            {
                for (int i = 0; i < s.Length; i++)
                {
                    var elem = s[i].ToString();

                    if (alphabet.ContainsKey(elem))
                    // verifies if that element corresponds to one of the Keys of alphabet
                    {
                        st.Push(s[i]);
                    }
                    else if (alphabet.ContainsValue(elem))
                    // verifies if that element corresponds to one of the Values of alphabet
                    {
                        var last = st.Peek().ToString(); // last element of the stack(pile)

                        if (elem == alphabet[last])
                        // if elem is a value, closing dyck, going to compare if the value that corresponds
                        // to the last element of the stack is the same as elem
                        {
                            st.Pop();
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                return st.Count == 0;   // if the number of elements in the stack after all the caracters of 
                                        // the string have been passed exceeds zero than false
            }
            catch (InvalidOperationException)
            {
                return false;
            }
        }
    }
}