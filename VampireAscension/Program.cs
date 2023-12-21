using System.Runtime.CompilerServices;
using VampireAscension;

class Program
{
    public static void Main(string[] args)
    {
        Dialogue.Speak("Enter, Ascended One");
        Dialogue.Speak("What is your name?");
        string name = Dialogue.Response();
        Player player = new Player(100, name);
        Game.Start(player);
    }
}
