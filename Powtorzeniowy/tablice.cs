using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powtorzeniowy
{
    public class Tablice
    {
        public void Wyswietl(int[] tab)
        {
            for(int i = 0; i <tab.Length; i++)
            {
                Console.WriteLine(tab[i] + ",");
            
            }
        }
        public int[] Tworzenie_tablicy()
        {
            Console.WriteLine("ile znakow ma miec tablca");
            int dl = int.Parse(Console.ReadLine());
            int[] ints = new int[dl];
            for (int i = 0; i < dl; i++)
            {
                Console.Write("podaj kolejny elemnet");
                ints[i] = int.Parse(Console.ReadLine());
            }
            return ints;
        }
        public void Sortowanie_babelkowe(int[] tablica) 
        {
            
            for (int i = 0;i < tablica.Length; i++) 
            {
                for (int j = 1; j<tablica.Length-i; j++)
                {
                    if (tablica[j - 1] > tablica[j]) 
                    {
                        int temp = tablica[j-1]; tablica[j-1] = tablica[j]; tablica[j] = temp;
                    }
                }
            }
        }
        public void Przeszukaj(int[]tab)
        {
            Console.WriteLine("jakiej liczby szukasz? ");
            int szukana = int.Parse(Console.ReadLine());
            bool liczba_istnieje = false;
            int ile_razy = 0;
            for (int i = 0; i<tab.Length; i++)
            {
                if (tab[i] == szukana)
                {
                    liczba_istnieje= true;
                    ile_razy++;
                }
            }
            if (liczba_istnieje == true)
            {
                Console.WriteLine($"liczba wystepuje w tabllicy {ile_razy} razy ");
            }
            else
            {
                Console.WriteLine("liczba nie wystepuje w tablicy");
            }
        }
    }
}
