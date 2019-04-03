using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
     
        private static int[] tab = new int[5];
        private static int index = 0;

        static void Main(string[] args)
        {
            bool czyKoniec = false;
            

            while (czyKoniec == false)
            {
                Console.WriteLine("Podaj liczbe którą chcesz wpisać do tablicy: ");
                int numerek = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Environment.NewLine);
                add(numerek);
                Console.WriteLine("Wielkość tablicy: " + tab.Length);
                for(int i =0; i<index; i++)
                {
                    Console.WriteLine(tab[i]);
                }



            }
        }



        static void add(int x)
        {
            if(index >= tab.Length)
            {
                wyjatek(x);
                makeItBigger(2);
                tab[index++] = x;
            }
            else
            {
                tab[index++] = x;
            } 
        }

        static void makeItBigger(int x)
        {
            int[] tab2 = new int[tab.Length];
            Array.Copy(tab, tab2, index);
            tab = new int[x * tab.Length];
            Array.Copy(tab2, tab, index);

        }
        static int wyjatek(int x)
        {
            if (x >= tab.Length)
            {
                throw new System.IndexOutOfRangeException("Wyleciałeś poza skale!");
            }
            return tab[x];
        }

    }
}
