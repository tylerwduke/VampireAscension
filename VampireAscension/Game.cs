using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VampireAscension
{
    public class Game
    {
        public static void Start(Player player) {
            bool _exit = false;
            while (!_exit)
            {
                Console.WriteLine("What will you do?");

                if (Dialogue.Response() == "quit")
                {
                    Dialogue.Speak("Quitting...");
                    _exit = true;
                }

                if (Dialogue.Response() == "walk" && Decisions.decisionList.Contains("walk"))
                {
                    Dialogue.Speak("Which direction?");
                    string direction = Dialogue.Response();
                    if (Decisions.directions.Contains(direction))
                    {
                        Decisions.walkHandler(direction);
                    } else
                    {
                        Dialogue.Speak("Not a valid direction! (north, south, east, west) ");
                    }
                }
            }
        }

    }
}
