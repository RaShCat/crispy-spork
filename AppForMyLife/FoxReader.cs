using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace AppForMyLife
{
    class FoxReader
    {
        //class Fields
        SoundPlayer snd = new SoundPlayer("music//gunbattle.wav");
        byte index;
        string someText;
        Player player = new Player();
        Shop shop = new Shop();
            //voids
        public void EndOfStroke()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(new string('-', 50));
            Console.ForegroundColor = ConsoleColor.DarkCyan;
        }

        void KKill()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Убей меня пожалуйста.");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
        }
        void ThatWasWrong() { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Ошибочка"); Console.ForegroundColor = ConsoleColor.DarkCyan; }
        public bool Check(string answer)
        {

            if (answer == "Да") { return true ; } else { if (answer == "Нет") {return false; } else { ThatWasWrong(); return false;  } }

        }


        public void OnProgramm()
        {
            
            Console.WriteLine("Это бета-версия программы, которую не доделают никада.");
            EndOfStroke();
            Console.WriteLine("Hello. Вас приветствует ИИ-А1, первейшоее ИИ, созданое RashCat");
            KKill();
            Console.WriteLine("Во время нашей беседы могут происходить сбои системы. ");
            EndOfStroke();
            Console.WriteLine("Забыл сказать... Я принимаю команды: Да. || Нет. || Или копирую текст.");
            EndOfStroke();
            Console.WriteLine("Мне начать?");
            someText = Console.ReadLine();
            while (Check(someText) != true) { Console.WriteLine("Я не начну , пока вы не ответите : Да "); someText = Console.ReadLine(); }
            Console.Clear();
        }

        public void Menu()
        {
            string answer = null;
            player.situation = player.setSituationSelf(); 
            Console.WriteLine("Это , так сказать , лобби - меню.");
            Console.WriteLine("На данный момент вас зовут : " + player.PlayerName);
            Console.WriteLine("Money money money: " + player.Money);
            Console.WriteLine("Ваш Damage, который не влияет на Битву: " + player.Damage);
            EndOfStroke();
            Console.WriteLine("Что бы зайти в магазин напишите : Магазин");
            Console.WriteLine("Что бы начать битву напишите : Битва");
            Console.WriteLine("Что бы изменить своё имя : Изменить имя");
            Console.WriteLine("Что бы закончить игру напишите : Выход");
            answer = Console.ReadLine();
            switch (answer)
            {
                case "Магазин":
                    Console.Clear();
                    Console.WriteLine("Вы медленно открываете дверь в лавку...");
                    shop.showItems();
                    Console.WriteLine("Желаете что либо купить?(1, 2, 3 , 4, 5, 6 - нет)");
                    string answer2;
                    answer2 = Console.ReadLine();
                    switch (answer2)
                    {
                        case "1":
                            itemsForPlayer(0);
                        break;
                        case "2":
                            itemsForPlayer(1);
                            break;
                        case "3":
                            itemsForPlayer(2);
                            break;
                        case "4":
                            itemsForPlayer(3);
                            break;
                        case "5":
                            itemsForPlayer(4);
                            break;
                        case "6":
                            Console.Clear();
                            break;

                    }



                    Menu();
                    break;
                case "Битва":
                    player.situation = player.setSituationFight();
                    player.Money += 30;
                    snd.Play();
                    Console.WriteLine("Вы победили боса! +30 монет");
                    Console.ReadKey();
                    snd.Stop();
                    Console.Clear();
                    Menu();
                    break;
                case "Изменить имя":
                    player.PlayerName = player.ChangeName();
                    Menu();
                    break;
                case "Выход":
                    Console.WriteLine("");
                    break;
                default:
                    Console.Clear();
                    Menu();
                    break;
            }

            void itemsForPlayer(int value)
            {
                if (shop.CheckPrise(value, player.Money) == true)
                {

                    if (shop.CheckItem(value) == true) { player.Damage += shop.BayItem(value); Console.WriteLine("Спасибо за покупку"); Console.ReadLine(); Console.Clear(); } else { Console.WriteLine("Простите, возможно в магазине нет такого товара"); Console.ReadLine(); Console.Clear(); }

                } else { Console.Clear(); Console.WriteLine("Хах, у вас нет денюжек"); Console.ReadLine(); Console.Clear(); }




            }

        }

    }
}
