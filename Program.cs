using System;

namespace discord_nicetext
{
    class Program
    {
        static string[] numberStrings = new string[] { ":zero:", ":one:", ":two:", ":three:", ":four:", ":five:", ":six:", ":seven:", ":eight:", ":nine:" };
        static void Main(string[] args)
        {
            Console.WriteLine("Input text: ");
            char[] arrInput = Console.ReadLine().ToCharArray();
            
            string sOutput = "";
            for(ushort i=0;i<arrInput.Length;i++)
            {
                if(Char.IsLetter(arrInput[i]))
                {
                    sOutput += $":regional_indicator_{Char.ToLower(arrInput[i])}: ";
                }   
                else if(Char.IsDigit(arrInput[i]))
                {
                    sOutput += numberStrings.GetValue(Convert.ToInt32(arrInput[i].ToString())) + " ";
                }
                else if (Char.IsWhiteSpace(arrInput[i]))
                {
                    sOutput += "  ";
                }
                else
                {
                    sOutput += arrInput[i];
                }
            }

            Console.WriteLine(sOutput);
        }
    }
}
