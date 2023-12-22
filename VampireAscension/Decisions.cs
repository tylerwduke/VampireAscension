using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VampireAscension
{
    public class Decisions
    {
        public static List<string> decisionList = new List<string>() { "walk", "feed" };
        public static List<string> directions = new List<string>(4) { "north", "south", "east", "west" };


        public static string walkHandler(string direction)
        {
            Dialogue.Speak($"You walked {direction}");
            return direction;
        }

    }
}
