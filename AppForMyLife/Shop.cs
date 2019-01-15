using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AppForMyLife
{
    
    class Shop
    {
        
        SoundPlayer sndPlayer = new SoundPlayer("music//creak.wav");
        string[] inventoryOfShop = new string[] {"Сухарик" , "Жало пчелы", "Палка" , "Палка с камнем" , "Дубинка" };
        int[] priceOfShop = new int[] {100, 200, 300, 400, 500 };
        int[] damageOfItems = new int[] { 10, 20, 30, 40, 50 };
        public bool CheckItem(int value)
        {
            if (inventoryOfShop[value] == "") { return false; } else { return true;}
        }
        public int BayItem(int value)
        {
            inventoryOfShop[value] = "";
            return damageOfItems[value];
        }
        public void showItems()
        {
            
            sndPlayer.Play();
            Console.WriteLine("Дароу, вот майн вещи пакупай:");
            
            for (int i = 0; i < 5; i++)
            {
                
                Console.WriteLine(inventoryOfShop[i] + " Цена: " + priceOfShop[i] + " Damage: " + damageOfItems[i]);
                
                Thread.Sleep(500);
            }

        }
        public bool CheckPrise(int value, int playerMoney)
        {
            if (priceOfShop[value] < playerMoney) { return true; } else { return false; }
        }

    }
}
