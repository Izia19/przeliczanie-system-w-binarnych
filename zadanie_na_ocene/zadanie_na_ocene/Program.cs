using System;
using zadanie_na_ocene;

namespace zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Systemy_liczbowe systemy = new Systemy_liczbowe();

            bool petla = true;

            while (petla)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("+-------------------Wybierz działane:-----------------------+");
                Console.WriteLine("|                                                           |");
                Console.WriteLine("|   1. Zamien na system binarny/osemkowy/szestnastkowy      |");
                Console.WriteLine("|   2. Zamiana na systemy (2-16)                            |");
                Console.WriteLine("|   3. Zamiana z dowolnego na dowolny                       |");
                Console.WriteLine("|   4. Kalkulator                                           |");
                Console.WriteLine("|   5. Koniec                                               |");
                Console.WriteLine("|                                                           |");
                Console.WriteLine("+-----------------------------------------------------------+");
                Console.ResetColor();

                int wybor = int.Parse(Console.ReadLine());

                switch (wybor)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("Podaj liczbe: ");
                            int liczba = int.Parse(Console.ReadLine());

                            if(liczba == 0)
                            {
                                systemy.komunikaty(2);
                                break;
                            }

                            Console.WriteLine($"Liczba dziesiętna {liczba} w: ");

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"systemie binarnym: {systemy.system_uniwersalny(liczba, 2)}");

                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine($"systemie ósemkowym: {systemy.system_uniwersalny(liczba, 8)}");

                            Console.ForegroundColor = ConsoleColor.Green;
                            string liczba_16 = Convert.ToString(liczba, 16);
                            Console.WriteLine($"systemie szestnastkowy: {liczba_16}");

                            Console.ResetColor();
                            break;
                        }

                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Podaj liczbe: ");
                            int liczba = int.Parse(Console.ReadLine());

                            if (liczba == 0)
                            {
                                systemy.komunikaty(2);
                                break;
                            }

                            Console.WriteLine($"Liczba dziesiętna {liczba} w: ");

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"systemie binarnym: {systemy.system_uniwersalny(liczba, 2)}");

                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($"systemie trojkowym: {systemy.system_uniwersalny(liczba, 3)}");

                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"systemie piatkowy: {systemy.system_uniwersalny(liczba, 5)}");

                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine($"systemie szostkowy: {systemy.system_uniwersalny(liczba, 6)}");

                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine($"systemie siodemkowy: {systemy.system_uniwersalny(liczba, 7)}");

                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine($"systemie ósemkowym: {systemy.system_uniwersalny(liczba, 8)}");

                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine($"systemie dziewiatkowy: {systemy.system_uniwersalny(liczba, 9)}");

                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine($"systemie jedenastkowy: {systemy.systemy_od_10(liczba, 11)}");

                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine($"systemie dwunastkowy: {systemy.systemy_od_10(liczba, 12)}");

                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"systemie trzynastkowy: {systemy.systemy_od_10(liczba, 13)}");

                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine($"systemie czternastkowy: {systemy.systemy_od_10(liczba, 14)}");

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"systemie pietnastkowy: {systemy.systemy_od_10(liczba, 15)}");

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"systemie szestnastkowy: {systemy.systemy_od_10(liczba, 16)}");

                            Console.ResetColor();
                            break;
                        }

                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Z jakiego systemu chcesz zamienic liczbe: ");
                            int system_podania = int.Parse(Console.ReadLine());

                            if (system_podania > 16)
                            {
                                systemy.komunikaty(1);
                                break;
                            }else if (system_podania == 0)
                            {
                                systemy.komunikaty(3);
                                break;
                            }

                            Console.WriteLine("Podaj tą liczbe: ");
                            string liczba = Console.ReadLine();

                            if (Convert.ToInt16(liczba) == 0)
                            {
                                systemy.komunikaty(2);
                                break;
                            }

                            Console.WriteLine("Na jaki system chcesz ja zamienic: ");
                            int system_zamiany = int.Parse(Console.ReadLine());

                            if (system_zamiany > 16)
                            {
                                systemy.komunikaty(1);
                                break;
                            }
                            else if (system_zamiany == 0)
                            {
                                systemy.komunikaty(3);
                                break;
                            }
                            else if (system_zamiany < 10)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine($"Liczba: {liczba} w systemie {system_zamiany}: {systemy.system_uniwersalny(systemy.system10(liczba, system_podania), system_zamiany)}");
                            }
                            else if(system_zamiany > 10)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine($"Liczba: {liczba} w systemie {system_zamiany}: {systemy.systemy_od_10(systemy.system10(liczba, system_podania), system_zamiany)}");
                            }
                            else if(system_zamiany == 10)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine($"Liczba: {liczba} w systemie {system_zamiany}: {systemy.system10(liczba, system_podania)}");
                            }

                            Console.ResetColor();
                            break;
                        }

                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("Z jakiego systemu jest pierwsza liczba: ");
                            int system_podania1 = int.Parse(Console.ReadLine());

                            if (system_podania1 > 16)
                            {
                                systemy.komunikaty(1);
                                break;
                            }
                            else if(system_podania1 == 0)
                            {
                                systemy.komunikaty(3);
                                break;
                            }

                            Console.WriteLine("Podaj tą liczbe: ");
                            string liczba1 = Console.ReadLine();

                            if (Convert.ToInt16(liczba1) == 0)
                            {
                                systemy.komunikaty(2);
                                break;
                            }

                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("+-----Jaką operacje chcesz wykonac:-----+");
                            Console.WriteLine("|                                       |");
                            Console.WriteLine("|   1. +                                |");
                            Console.WriteLine("|   2. -                                |");
                            Console.WriteLine("|   3. *                                |");
                            Console.WriteLine("|   4. /                                |");
                            Console.WriteLine("|                                       |");
                            Console.WriteLine("+---------------------------------------+");
                            Console.ResetColor();

                            int wybor_kalkulator = int.Parse(Console.ReadLine());
                            if ( 1 > wybor_kalkulator || wybor_kalkulator > 4)
                            {
                                systemy.komunikaty(4);
                                break;
                            }

                            Console.WriteLine("Z jakiego systemu jest druga liczba: ");
                            int system_podania2 = int.Parse(Console.ReadLine());

                            if (system_podania2 > 16)
                            {
                                systemy.komunikaty(1);
                                break;
                            }
                            else if (system_podania2 == 0)
                            {
                                systemy.komunikaty(3);
                                break;
                            }

                            Console.WriteLine("Podaj tą liczbe: ");
                            string liczba2 = Console.ReadLine();

                            if (Convert.ToInt16(liczba2) == 0)
                            {
                                systemy.komunikaty(2);
                                break;
                            }

                            Console.WriteLine("W jakim systemie ma byc wynik: ");
                            int system_wynik = int.Parse(Console.ReadLine());

                            if (system_wynik > 16)
                            {
                                systemy.komunikaty(1);
                                break;
                            }
                            else if (system_wynik == 0)
                            {
                                systemy.komunikaty(3);
                                break;
                            }

                            int liczba1_zamieniona = 0;
                            int liczba2_zamieniona = 0;

                            if (system_podania1 == 10)
                            {
                                liczba1_zamieniona = Convert.ToInt16(liczba1);
                            }
                            if(system_podania2 == 10)
                            {
                                liczba2_zamieniona = Convert.ToInt16(liczba2);
                            }
                            else
                            {
                                liczba1_zamieniona = systemy.system10(liczba1, system_podania1);
                                liczba2_zamieniona = systemy.system10(liczba2, system_podania2);
                            }

                            int wynik;
                            string napis;

                            systemy.kalkulator(liczba1_zamieniona, liczba2_zamieniona, wybor_kalkulator,out napis, out wynik);
                    
                            if (system_wynik < 10)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine($"Wynik działania ({napis}) w systemie {system_wynik} to {systemy.system_uniwersalny(wynik,system_wynik)}");

                            }
                            else if (system_wynik > 10)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine($"Wynik działania ({napis}) w systemie {system_wynik} to {systemy.systemy_od_10(wynik, system_wynik)}");
                            }
                            else if (system_wynik == 10)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine($"Wynik działania ({napis}) w systemie {system_wynik} to {wynik}");
                            }

                            Console.ResetColor();
                            break;
                        }

                    case 5:
                        {
                            petla = false;
                            break;
                        }
                }
            }

        }
    }
}
