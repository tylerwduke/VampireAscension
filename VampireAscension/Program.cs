using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using VampireAscension;

class Program
{
    public static void Main(string[] args)
    {
        Dialogue.Speak("Enter, Ascended One");
        string name = string.Empty;
        
        while (name.Length == 0)
        {
            Dialogue.Speak("What is your name?");
            name = Dialogue.Response();
        }

        Player player = new Player(100, name);
        Dialogue.Speak($"You've awoken in a fog, {name}. The blood ties that bind you to the mortal world are all but a memory. Your clan has fallen, and you are the only one left.");
        Game.Start(player);

    }
}
