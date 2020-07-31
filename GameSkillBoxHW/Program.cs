using System;
using System.Runtime.CompilerServices;

namespace GameSkillBoxHW
{
    public class Player
    {
        public string name;

        public bool mystep = true;
        public string setName() //Ввод имени игрока
        {
            name = Console.ReadLine();
            return name;
        }
        public void Step() // Ход игрока
        { 
            int curStep = Convert.ToInt32(Console.ReadLine());
            Game.score -= curStep;
        }

    }

    class Game
    {
        public int mode;
        public static int score = 20;
        public int SetMode()
        {
            Console.WriteLine("Выберите режим игры:\n1)Многопользовательский  \n2)Однопользователский");
            mode = Convert.ToInt32(Console.ReadLine());
            return mode;
        }
        public int GameStep(int mode, Player player1, Player player2)
        {
            if (mode == 1)
            {
                player1.Step();
                player2.Step();
                return 1;
            }
            else
            {
                return 2;
            }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            int score = 20;
            Game newgame = new Game();
            if (Convert.ToInt16(Console.ReadLine()) == 1)
            {
                Console.WriteLine("Введите имя 1 игрока:");
                Player User1 = new Player();
                User1.setName();

                Console.WriteLine("Введите имя 2 игрока:");
                Player User2 = new Player();
                User1.setName();

                int step = 1;
                while (score > 0)
                {
                    
                    if (step == 1) 
                    {
                        if (score <= 4)
                        {
                            Console.WriteLine($" Победил {User1.name} ");
                            score = 0;
                        }
                        Console.WriteLine($"Ход {User1.name} (Введите 1, 2, 3, 4):");
                        score -= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(score);
                        step = 2;
                    }
                    if(step == 2) 
                    {
                        if (score <= 4)
                        {
                            Console.WriteLine($" Победил {User2.name} ");
                            score = 0;
                        }
                        if (score <= 4) Console.WriteLine($" Победил {User2.name} ");
                        Console.WriteLine($"Ход {User2} (Введите 1, 2, 3, 4):");
                        score -= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(score);
                        step = 1;
                    }
                    
                    
                }
                Console.WriteLine("Gameover!");
            }
            else
            {
                
            }
            ;
            Console.ReadKey();
        }
    }
}
