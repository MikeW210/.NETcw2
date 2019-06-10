using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate void MyDelegate(int tabSize);
    public class Tablica
    {
        private MyDelegate myDelegate = null;
        private int[] tab = new int[1];
        private int index = 0;
        public Tablica()
        {
            myDelegate += tabSize;

        }
    
        public void tabSize(int sizeOfArray)
        {
            Console.WriteLine("Rozmiar tablicy: " + sizeOfArray);
        }
        


        public void printAllElements()
        {
            for (int i = 0; i < index; i++)
            {
                wypiszTablice(i);
            }

           
        }

        public void add(int x)
        {
            if (index >= tab.Length)
            {

                makeItBigger(2 * tab.Length);
                tab[index++] = x;
            }
            else
            {
                tab[index++] = x;
            }
            myDelegate(tab.Length);
        }

        public void makeItBigger(int x)
        {
            int[] tab2 = new int[tab.Length * 2];
            Array.Copy(tab, tab2, index);
            tab = tab2;

        }
        public int wypiszTablice(int x)
        {
            if (x <= tab.Length)
            {
                Console.WriteLine("ID " + x + " is: " + tab[x]);
                
            }
            else
            {
                throw new System.IndexOutOfRangeException("Wyleciałeś poza skale!");
            }

            return tab[x];
        }
    }
}
