using System;

namespace Cifrul__n
{
    class Program
    {
        static void Main()
        {
            //Cifrul +n
            //En(x) = (x + n) % 26 , Dn(x) = (x - n) % 26

            //Citire text

            Console.WriteLine($"Textul clar:");
            string t = Console.ReadLine();
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //Criptare text

            string text_criptat = "";
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] >= 'a' && t[i] <= 'z')
                {
                    text_criptat = text_criptat + (char)((t[i] + n - 'a') % 26 + 'a');
                }
                else if (t[i] >= 'A' && t[i] <= 'Z')
                {
                    text_criptat = text_criptat + (char)((t[i] + n - 'A') % 26 + 'A');
                }
                else
                    text_criptat = text_criptat + t[i];
            }
            Console.WriteLine($"Textul codat:");
            Console.WriteLine(text_criptat);
            Console.WriteLine();

            //Decriptare text

            t = "";
            for (int i = 0; i < text_criptat.Length; i++)
            {
                if (text_criptat[i] >= 'a' && text_criptat[i] <= 'z')
                {
                    t = t + (char)((text_criptat[i] + 26 - n - 'a') % 26 + 'a');
                }
                else if (text_criptat[i] >= 'A' && text_criptat[i] <= 'Z')
                {
                    t = t + (char)((text_criptat[i] + 26 - n - 'A') % 26 + 'A');
                }
                else
                    t = t + text_criptat[i];
            }
            Console.WriteLine($"Textul decodat:");
            Console.WriteLine(t);
            Console.WriteLine();
        }
    }
}
