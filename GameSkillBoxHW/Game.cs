using System;
using System.Collections.Generic;
using System.Text;

namespace GameSkillBoxHW
{
    class Game
    {
        public int mode;
        public static int score = 20;
        public int SetMode() //Выбор режима игры
        {
            Console.WriteLine("Выберите режим игры:\n1)Многопользовательский\n2)Однопользователский");
            mode = Convert.ToInt32(Console.ReadLine());
            return mode;
        }
        public void StartGame(int mode, Player player1, Player player2) // логика самой игры
        {
            while (score > 0)

            {
                Console.WriteLine($"Ход {player1.name},\nТекущее количество очков:{score}");
                player1.FirStep(player1);
                Console.WriteLine($"Ход {player2.name},\nТекущее количество очков:{score}");
                player2.SecStep(mode, player2);
            }
        }
    }
}
