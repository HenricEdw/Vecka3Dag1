using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skapa instans
            Player player = new Player();

            //Testa att ändra och läsa ut lite värden via properties
            //Debugga gärna!
            player.PlayerName = "Nytt Namn";
            player.Score = 1000;
            player.TimePlayed = 10;
            var scoreTime = player.ScoreByTimePlayed;

            Console.WriteLine($"Spelare {player.PlayerName} har {player.Score} poäng!");
            Console.ReadLine();
        }
    }
}
