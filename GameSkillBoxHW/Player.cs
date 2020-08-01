using System;
using System.Collections.Generic;
using System.Text;

namespace GameSkillBoxHW
{
    public class Player
    {
        public string name;
        public string setName() //Ввод имени игрока
        {
            Console.WriteLine("Введите имя:");
            name = Console.ReadLine();
            return name;
        }
        public void FirStep(Player player1) // Ход игрока
        {
            int curStep = Convert.ToInt32(Console.ReadLine());
            Game.score -= curStep;
            if (Game.score == 0) Console.WriteLine($"Победил {player1.name},\n Goodjob!");
        }
        public void SecStep(int mode, Player player2) // Ход игрока
        {
            if (mode == 1)
            {
                int curStep = Convert.ToInt32(Console.ReadLine());
                Game.score -= curStep;
                if (Game.score == 0) Console.WriteLine($"Победил {player2.name},\n Goodjob!");
            }
            else if (mode == 2)
            {
                Random rnd = new Random();
                Game.score -= rnd.Next(1, 5);
                if (Game.score == 0) Console.WriteLine($"Победил Робот,\n Goodjob!");
            }
        }
    }
}
