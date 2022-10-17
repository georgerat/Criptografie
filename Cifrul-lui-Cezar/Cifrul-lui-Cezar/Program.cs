using System;

namespace Cifrul_lui_Cezar
{
    class Program
    {
        static void Main()
        {
            //Cifrul lui Cezar - inlocuieste fiecare litera din alfabet cu a treia litera care urmeaza in alfabet.
            //E(x) = (x + 3) % 26 , x = 0->25; D(x) = (x - 3) % 26;
            //HELLO WORLD -> text clar
            //KHOOR ZRUOG -> text criptat

            //Citire text

            Console.WriteLine($"Textul clar:");
            string t = Console.ReadLine();
            Console.WriteLine();

            //Criptare text

            string text_criptat = "";
            for (int i = 0; i < t.Length; i++)
            {
                if ((t[i] >= 'a' && t[i] <= 'w') || (t[i] >= 'A' && t[i] <= 'W'))
                {
                    text_criptat = text_criptat + (char)(t[i] + 3);
                }
                else if (t[i] == 'x')
                    text_criptat = text_criptat + 'a';
                else if (t[i] == 'y')
                    text_criptat = text_criptat + 'b';
                else if (t[i] == 'z')
                    text_criptat = text_criptat + 'c';
                else if (t[i] == 'X')
                    text_criptat = text_criptat + 'A';
                else if (t[i] == 'Y')
                    text_criptat = text_criptat + 'B';
                else if (t[i] == 'Z')
                    text_criptat = text_criptat + 'C';
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
                if ((text_criptat[i] >= 'd' && text_criptat[i] <= 'z') || (text_criptat[i] >= 'D' && text_criptat[i] <= 'Z'))
                {
                    t = t + (char)(text_criptat[i] - 3);
                }
                else if (text_criptat[i] == 'a')
                    t = t + 'x';
                else if (text_criptat[i] == 'b')
                    t = t + 'y';
                else if (text_criptat[i] == 'c')
                    t = t + 'z';
                else if (text_criptat[i] == 'A')
                    t = t + 'X';
                else if (text_criptat[i] == 'B')
                    t = t + 'Y';
                else if (text_criptat[i] == 'C')
                    t = t + 'Z';
                else
                    t = t + text_criptat[i];
            }
            Console.WriteLine($"Textul decodat:");
            Console.WriteLine(t);
            Console.WriteLine();
        }
    }
}
