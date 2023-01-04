using System;

namespace Substitutie_monoalfabetica
{
    class Program
    {
        static void Main()
        {
            //Substitutie monoalfabetica

            //Citire text

            Console.WriteLine($"Textul clar:");
            string t = Console.ReadLine();
            Console.WriteLine();

            //Creare permutare alfabet - alfabet criptat

            char[] LitereleAlfabetului = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] AlfabetCriptat = new char[LitereleAlfabetului.Length];
            bool[] visited = new bool[26];
            Random random = new Random();

            for (int i = 0; i < 26; i++)
            {
                int r = random.Next(26);
                while (visited[r] == true)
                    r = random.Next(26);
                AlfabetCriptat[i] = LitereleAlfabetului[r];
                visited[r] = true;
            }

            Console.Write("Alfabetul normal:  ");
            Console.WriteLine(LitereleAlfabetului);
            Console.Write("Alfabetul criptat: ");
            Console.WriteLine(AlfabetCriptat);
            Console.WriteLine();

            //Criptare text

            t = t.ToLower();
            string text_criptat = "";
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] >= 'a' && t[i] <= 'z')
                {
                    int PozitiaLuiTinAlfabet = -1;
                    for (int j = 0; j < 26; j++)
                    {
                        if (LitereleAlfabetului[j] == t[i])
                        {
                            PozitiaLuiTinAlfabet = j;
                            break;
                        }
                    }
                    text_criptat = text_criptat + (char)(AlfabetCriptat[PozitiaLuiTinAlfabet]);
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
                    int PozitiaLuiTinAlfabetCriptat = -1;
                    for (int j = 0; j < 26; j++)
                    {
                        if (AlfabetCriptat[j] == text_criptat[i])
                        {
                            PozitiaLuiTinAlfabetCriptat = j;
                            break;
                        }
                    }
                    t = t + (char)(LitereleAlfabetului[PozitiaLuiTinAlfabetCriptat]);
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
