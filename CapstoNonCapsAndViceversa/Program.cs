using System;

namespace CapstoNonCapsAndViceversa
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            //string[] sArray = s.Split("");
            char[] cArray = s.ToCharArray();

            string FinalString = string.Empty;
            foreach (char item in cArray)
            {
                string Convertedstring = Convert.ToString(item);
                if (char.IsUpper(item))
                {
                    Convertedstring = Convertedstring.ToLower();
                }
                else
                {
                    Convertedstring = Convertedstring.ToUpper();
                }
                FinalString += Convertedstring;
            }
            Console.WriteLine(FinalString);
            Console.ReadLine();
        }
    }
}
