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

        public static void Main()
        {

        }
    }

    
}
