using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VampireAscension
{
    public class Scene
    {
        public static void RandScene(Player player)
        {
            Random rnd = new Random();
            int num = rnd.Next(10);

            if (num == 1)
            {
                Dialogue.Speak("You encountered a wild boar, struck in it's side by a bullet. It's barely moving, and you can feel it's blood pulse");
                Dialogue.Speak("This is a great feeding opportunity...");
                string response = Dialogue.Response();
                if (response == "feed" && Decisions.decisionList.Contains("feed"))
                {
                    if (player._hp < 100)
                    {
                        Dialogue.Speak("You gained 5 HP");
                        player.GainHp(5);
                    } else
                    {
                        Dialogue.Speak("You feel refreshed, but gain nothing from this feed");
                    }
                }
            } else if (num == 2)
            {
                Dialogue.Speak("You hear faint yells from a distance. Hunters. They have caught wind of your resurrection and are keen on finding you and putting an end to the Vampiric bloodlines once and for all");
                
            }
        }
    }
}
