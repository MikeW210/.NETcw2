using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        private static int[] tab;
        private static int index = 0;

        static void Main(string[] args)
        {
            Tablica tab = new Tablica();
            bool czyKoniec = false;

            while (czyKoniec == false)
            {
                Console.WriteLine("Podaj liczbe którą chcesz wpisać do tablicy: ");
                int numerek = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Environment.NewLine);
                tab.add(numerek);

                tab.printAllElements();

                
                
                Console.WriteLine("Chcesz kontynuowac? 1-tak 2-nie");
                int czy = Convert.ToInt32(Console.ReadLine());
                if (czy == 1)
                {
                    czyKoniec = false;
                }
                else
                {
                    czyKoniec = true;      
                }
                
            }

           
            Environment.Exit(0);
        }


        

    }
}
