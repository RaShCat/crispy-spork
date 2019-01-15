using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForMyLife
{
    class Program
    {
        

        static void Main(string[] args)
        {
            
            FoxReader Fox = new FoxReader();
            Fox.OnProgramm();
            Player player = new Player();
            Fox.Menu();

            Console.WriteLine("Надеюсь, Вы хоть где-нибудь улыбнулись");
            
            Console.ReadLine();

        }
    }
}
