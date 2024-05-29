using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _12_week_4_ZadanieDomowe1_lekcja11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string _userDecision = null;
            

            do
            {
                Console.WriteLine("Podaj liczbę");
                try
                {

                    if (!long.TryParse(Console.ReadLine(), out long userNumber))
                    {
                        throw new Exception("Niepoprawna wartość, podaj LICZBĘ");
                    }

                    var result = userNumber % 2;

                    if (result != 0)
                    { 
                        Console.WriteLine("Podałeś liczbę NIEPARZYSTĄ");
                        Console.WriteLine();
                        Console.WriteLine("Czy chcesz kontynuować? T/N");
                        var userDecision = Console.ReadLine();
                        _userDecision = userDecision;
                    }
                    else
                    {
                        Console.WriteLine("Podałeś liczbę PARZYSTĄ");
                        Console.WriteLine();
                        Console.WriteLine("Czy chcesz kontynuować? T/N");
                        var userDecision = Console.ReadLine();
                        _userDecision = userDecision;
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine();
                    Console.WriteLine(ex.Message.ToString());
                    Console.ReadLine();

                }
            } while (_userDecision != "N");
            Console.WriteLine();
            Console.WriteLine("Dziękuję!");
            Console.ReadLine();
        }
    }
}
