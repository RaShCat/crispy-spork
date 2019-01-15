using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForMyLife
{
    class Player
    {
        //FoxReader Fox = new FoxReader();
        string playerName;
        int money;
        int damage = 30;
        public int Damage { get { return damage; } set { damage = value; } }
        
        




        public int Money { get { return money; } set { money = value; } }
        public string PlayerName { get { return playerName; } set { playerName = value; } }
        public bool situation = true;

        public string ChangeName() {
            if (situation == true)
            {
                FoxReader Fox = new FoxReader();
                Console.WriteLine("Происходит инициализация...");
                Console.WriteLine("Смена никнейма...");
                Console.ForegroundColor = ConsoleColor.Magenta;
                playerName = Console.ReadLine();
                Console.WriteLine("Никнейм успешно изменен," + playerName + " ...");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.ReadLine();
                Console.Clear();


                return playerName;
                
            }
            else { return playerName; }
        }
        
        public bool setSituationFight() { situation = false; return situation; }
        public bool setSituationSelf() { situation = true; return situation; }

    }
}
