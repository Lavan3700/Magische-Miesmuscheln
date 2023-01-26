using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magische_Miesmuscheln
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool nochEineFrage;
            do
            {
                nochEineFrage = askQuestions();
            } while (nochEineFrage);

            Console.ReadLine(); //Damit die Console nicht zu geht
        }

        static bool askQuestions()
        {
                Console.Write("Stelle mir deine Frage: ");
                string userQuestion = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Deine Frage: " + userQuestion);
                Console.WriteLine("\nWahrsage: " + Antwort());

                Console.WriteLine("\n \nWillst du mir noch eine Frage stellen? Ja/Nein");
                string nextQuestion = Console.ReadLine().ToLower(); //ToLower damit seine einageb alles in klein geschrieben wird
                if (nextQuestion == "ja")
                {
                Console.Clear();   
                    return true;
                }  
                else
                {
                    return false;
                }
        }
        static string Antwort()
        {
            string[] anwser = new string[4];

            anwser[0] = "Ja auf jeden Fall.";
            anwser[1] = "Nein niemals.";
            anwser[2] = "Vielleicht.";
            anwser[3] = "Stelle deine Frage erenut.";

            Random radomNumberGenator = new Random();

            return anwser[radomNumberGenator.Next(0, 4)];
        }
    }
}
