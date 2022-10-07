using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Basic
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 'N'");
            char c = Convert.ToChar(Console.ReadLine());
            //while (true)
            //{
            if (c == Convert.ToChar(ConsoleKey.N))
            {
                while (c == Convert.ToChar(ConsoleKey.N))
                {
                    int CountDown = 0;
                    int login = 3;
                    int min;
                    int max;
                    int length;
                    Array myArray = new Array();

                    while (true)
                    {
                        try
                        {
                            Console.Write("Please enter the min:");
                            min = int.Parse(Console.ReadLine());
                            Console.Write("Please enter the max:");
                            max = int.Parse(Console.ReadLine());
                            if(min>=max)
                            {
                                Console.WriteLine("Min values couldn't greater than the max values...");
                                Thread.Sleep(800);
                                continue;
                            }
                            Console.Write("Enter the array length:");  //bunu döngü içine alıp min max kontrolü sağlayabilir miyiz
                            length = int.Parse(Console.ReadLine());
                            break;
                        }
                        catch (Exception)
                        {
                            if (CountDown < 2)
                            {
                                CountDown++;
                                login--;
                                Console.WriteLine("This Value İs İnvalid. You have {0} left", login);
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Console is closing...");
                                Thread.Sleep(2000);
                                Environment.Exit(0);
                            }
                        }
                    }
                        myArray.RandomArray(length, max, min);
                        myArray.ShowArray(length);

                        Stopwatch _sw2 = new Stopwatch();
                        _sw2.Start();
                        myArray.DetermineSmallest();
                        _sw2.Stop();
                        Console.WriteLine("0'dan büyük en küçük Sayının Bulunması " + _sw2.ElapsedMilliseconds + " ms sürdü.");
                        Console.WriteLine("To Exit Press 'Q' , To Continue Press 'N' ");
                        c = Convert.ToChar(Console.ReadLine());

                        if (c == Convert.ToChar(ConsoleKey.N))
                        {
                            continue;
                        }
                        else if (c == Convert.ToChar(ConsoleKey.Q))
                        {
                            Console.WriteLine("You Pressed 'Q'. Program is Closing...");
                            Thread.Sleep(2500);
                            Environment.Exit(0);
                        }
                }
            }
            else
            {
                Console.WriteLine("Program Kapatılıyor N'ye basmadınız...");
                Thread.Sleep(1500);
            }
        }
    }
}
