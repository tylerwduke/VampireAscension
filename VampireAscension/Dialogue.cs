using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace VampireAscension
{
    internal class Dialogue
    {
        public static void Speak(string dialogue)
        {
            foreach (char c in dialogue) {
                Console.Write(c);
                Thread.Sleep(30);
            }
            Console.WriteLine();
        }

        public static string Response()
        {
            Console.Write(">>> ");
            string response = Console.ReadLine();
            return response;
        }

    }
}
