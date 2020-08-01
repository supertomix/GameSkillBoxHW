using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace GameSkillBoxHW
{
 
    class Program
    {
        static void Main(string[] args)
        {
            Game newgame = new Game();
            int mode = newgame.SetMode();
            Player User1 = new Player();
            User1.setName();
            Player User2 = new Player();
            User2.setName();
            newgame.StartGame(mode, User1, User2);
            Console.WriteLine("Gameover!");

            Console.ReadKey();
        }
    }
}
