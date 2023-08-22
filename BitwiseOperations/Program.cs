using System;

namespace BitwiseOperations
{
    public class Complement
    {
        public string OnesComp(string binary)
        {
            char[] complement = new char[binary.Length];
            for (int i = 0; i < binary.Length; i++)
            {
                complement[i] = (binary[i] == '0') ? '1' : '0';
            }
            return new string(complement);
        }

        public string TowsComp(string binary)
        {
            char[] twosComplement = new char[binary.Length];
            int carry = 1;

            for (int i = 0; i < binary.Length; i++)
            {
                // LOGIC 1 ////
                int sum = Convert.ToInt16(twosComplement[i]) + carry;
                switch(sum)
                {
                    case 0:
                        {
                            twosComplement[i] = '0';
                            carry = 0;
                            break;
                        }
                    case 1:
                        {
                            twosComplement[i] = '1';
                            carry = 0;
                            break;
                        }
                    case 2:
                        {
                            twosComplement[i] = '1';
                            carry = 1;
                            break;
                        }
                }


            }
            return new string(twosComplement);
        }
        public static void Main()
        {

        }
    }

    
}
