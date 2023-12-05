using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_na_ocene
{
    public class Systemy_liczbowe
    {
        public Systemy_liczbowe() { }

        public string system_uniwersalny(int liczba, int system)
        {
            string liczba2 = "";
            while (liczba > 0)
            {
                int reszta = liczba % system;
                liczba2 = reszta.ToString() + liczba2;
                liczba = liczba / system;
            }
            return liczba2;
        }

        public string systemy_od_10(int liczba, int system)
        {
            string cyfry = "";
            if(system == 11)
            {
                cyfry = "0123456789a"; 
            }
            if (system == 12)
            {
                cyfry = "0123456789ab";
            }
            if (system == 13)
            {
                cyfry = "0123456789abc";
            }
            if (system == 14)
            {
                cyfry = "0123456789abcd";
            }
            if (system == 15)
            {
                cyfry = "0123456789abcde";
            }
            if (system == 16)
            {
                cyfry = "0123456789abcdef";
            }

            string wynik = "";

            while (liczba > 0)
            {
                int reszta = liczba % system; 
                wynik = cyfry[reszta] + wynik; 
                liczba = liczba / system;
            }

            return wynik;
        }


        public int system10(string liczba, int system)
        {
            int liczba_10 = 0;

            // przechodzimy od lewej do prawej po znakach liczby
            for (int i = 0; i < liczba.Length; i++)
            {
                char cyfra = liczba[i];
                int przeliczona_cyfra = 0;

                if (cyfra >= '0' && cyfra <= '9') //sprawdza czy znak cyfra jest cyfra od 0 - 9
                {
                    przeliczona_cyfra = int.Parse(cyfra.ToString()); 
                }
                else if (cyfra >= 'A' && cyfra <= 'Z') //sprawdza czy znak cyfra jest litera od A - Z
                {
                    przeliczona_cyfra = cyfra - 'A' + 10;
                }
                else if(cyfra >= 'a' && cyfra <= 'z')  //sprawdza czy znak cyfra jest litera od a - z
                {
                    przeliczona_cyfra = cyfra - 'a' + 10;
                }
                else
                {
                    throw new ArgumentException("Nieprawidłowa liczba.");
                }

                liczba_10 = liczba_10 * system + przeliczona_cyfra;
            }

            return liczba_10;

        }

        public void kalkulator(int liczba1, int liczba2, int ktore_dzialanie, out string napis, out int wynik)
        {
             wynik = 0;
             napis = "";

            if (ktore_dzialanie == 1)
            {
                wynik = liczba1 + liczba2;
                napis = $"{liczba1} + {liczba2}";
            }
            else if (ktore_dzialanie == 2)
            {
                wynik = liczba1 - liczba2;
                napis = $"{liczba1} - {liczba2}";
            }
            else if (ktore_dzialanie == 3)
            {
                wynik = liczba1 * liczba2;
                napis = $"{liczba1} * {liczba2}";
            }
            else if (ktore_dzialanie == 4)
            {
                wynik = liczba1 / liczba2;
                napis = $"{liczba1} / {liczba2}";
            }
        } 

        public void komunikaty(int ktory)
        {
            if(ktory == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("+-----------------------------------------------------------------------------+");
                Console.WriteLine("|                                                                             |");
                Console.WriteLine("|   Przepraszamy program nie obsluguje wiekszych systemów liczbowych niż 16   |");
                Console.WriteLine("|                                                                             |");
                Console.WriteLine("+-----------------------------------------------------------------------------+");
                Console.ResetColor();
            }
            else if(ktory == 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("+---------------------------+");
                Console.WriteLine("|                           |");
                Console.WriteLine("|  !Podaj poprawna liczbe!  |");
                Console.WriteLine("|                           |");
                Console.WriteLine("+---------------------------+");
                Console.ResetColor();
            }
            else if(ktory == 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("+------------------------------------------+");
                Console.WriteLine("|                                          |");
                Console.WriteLine("|   !System liczby nie moze byc rowny 0!   |");
                Console.WriteLine("|                                          |");
                Console.WriteLine("+------------------------------------------+");
                Console.ResetColor();
            }
            else if (ktory == 4)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("+------------------------------+");
                Console.WriteLine("|                              |");
                Console.WriteLine("|   Nie ma takiego dzialania   |");
                Console.WriteLine("|                              |");
                Console.WriteLine("+------------------------------+");
                Console.ResetColor();
            }
        }
    }
}
