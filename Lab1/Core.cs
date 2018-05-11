using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Klasa z funkcją main, udostpniejąca prosty interfejs konsolowy, umożliwiający wywołanie rozwiązań poszczególnych zadań
/// </summary>
namespace Lab1
{
    class Core
    {
        static void Main(string[] args)
        {
            byte choice;//zmienna dla switch
            Console.WriteLine("Wybierz zadanie:\n\r1-Ex.1 \n\r2-Ex.2\n\r3-Ex.3");
            try
            {
                choice = Convert.ToByte(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.Write("To nie jest wartość liczbowa!!!");
                choice = 0;
                Console.ReadLine();
            }
            catch (System.OverflowException)
            {
               
                choice = 0;
            }

            switch (choice)
            {
                case 1://część realizująca Ex.1
                    Ex1 sol = new Ex1();
                    int value;
                    Console.Write("Podaj wartość zmiennej: ");
                    try
                    {
                        value = Convert.ToInt32(Console.ReadLine());
                        if (value < 1)
                        {
                            Console.WriteLine("Wartość musi być większa bądź równa 1!");
                            Console.ReadLine();
                            Environment.Exit(-1);
                        }
                        Console.WriteLine($"Największa odległosć binarna dla podanej liczby wynosi: {sol.solution1(value)}");
                        Console.ReadLine();
                    }
                    catch (System.FormatException)
                    {
                        Console.Write("To nie jest wartość liczbowa!!!");
                        Console.ReadLine();
                    }
                    
                    break;
                case 2: //część realizująca Ex.2
                    try
                    {
                        Console.Write("Podaj długość tablicy: ");
                        int N = Convert.ToInt32(Console.ReadLine());
                        while (N < 0 || N > 100)
                        {
                            Console.WriteLine("N musi być liczbą z zakresu od 0 do 100.");
                            Console.Write("Podaj długość tablicy: ");
                            N = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.Write("Podaj wartości tablicy: \n\r");
                        int [] A = new int[N];
                        for (byte i=0;i<N;i++)
                        {
                            Console.Write($"Wartośc {i}: ");
                            try
                            {

                                    A[i] = Convert.ToInt32(Console.ReadLine());

                                if (A[i] > 1000 || A[i] < -1000)
                                {
                                    Console.WriteLine("Wartość musi być z zakresu od -1000 do 1000.");
                                    i--;
                                }
                            }
                            catch (System.FormatException)
                            {
                                Console.WriteLine("To nie jest wartość liczbowa!!!");
                                i--;
                            }
                            catch (System.OverflowException)
                            {
                                Console.WriteLine("Przekroczono zakres zmiennej");
                                i--;
                            }
                        }

                        Console.Write("Podaj ilość rotacji: ");
                        int K = Convert.ToInt32(Console.ReadLine());
                        while (K < 0 || K > 100)
                        {
                            Console.WriteLine("K musi być liczbą z zakresu od 0 do 100.");
                            Console.Write("Podaj ilość rotacji: ");
                            K = Convert.ToInt32(Console.ReadLine());
                        }

                        Ex2 sol2 = new Ex2();
                        int[] result = sol2.solution(A, N, K).get_table();
                        Console.Write("Tablica po rotacji: ");
                        result.ToList().ForEach(i => Console.Write(i.ToString()+" "));
                        Console.ReadLine();
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("To nie jest wartość liczbowa!!!");
                        Console.ReadLine();
                    }
                    catch (System.OverflowException)
                    {
                        Console.WriteLine("Przekroczono zakres zmiennej");
                        Console.ReadLine();
                    }
                    break;
                case 3://część realizująca Ex.3
                    Ex3 ex3 = new Ex3();
                    try {
                        Console.Write("Podaj długość tablicy: ");
                        int N = Convert.ToInt32(Console.ReadLine());
                        while (N < 0 || N > 100000)
                        {
                            Console.WriteLine("N musi być liczbą z zakresu od 0 do 100 000.");
                            Console.Write("Podaj długość tablicy: ");
                            N = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.Write("Podaj wartości tablicy: \n\r");
                        int[] B = new int[N];
                        for (byte i = 0; i < N; i++)
                        {
                            Console.Write($"Wartośc {i}: ");
                            try
                            {

                                B[i] = Convert.ToInt32(Console.ReadLine());

                                if (B[i] > 100000 || B[i] < -100000)
                                {
                                    Console.WriteLine("Wartość musi być z zakresu od -1000 do 1000.");
                                    i--;
                                }
                            }
                            catch (System.FormatException)
                            {
                                Console.WriteLine("To nie jest wartość liczbowa!!!");
                                i--;
                            }
                            catch (System.OverflowException)
                            {
                                Console.WriteLine("Przekroczono zakres zmiennej");
                                i--;
                            }
                        }
                        Console.WriteLine($"Ilość różnych elementów w podanej tablicy wynosi {ex3.solution(B)}");
                        Console.ReadLine();
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("To nie jest wartość liczbowa!!!");
                        Console.ReadLine();
                    }
                    catch (System.OverflowException)
                    {
                        Console.WriteLine("Przekroczono zakres zmiennej");
                        Console.ReadLine();
                    }
                    

                    break;
                default:
                    Console.Write("Nie ma takiej opcji.");
                    Console.ReadLine();
                    break;
            }



        }


    }
}
