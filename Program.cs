using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Labs
{
    class Program
    {
         
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> x = new List<int>();
            double summ1 = 0; double summ2 = 0; double _x = 0; double s1 = 0; double s2 = 0;
            int N; double sum = 0, umn = 0, del = 0, min = 0;
            double sum1 = 0, umn1 = 0, del1 = 0, min1 = 0;

            Console.WriteLine("Введите значение N: ");
            N = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            for (int i = 0; i < N; i++)
            {
                x.Add(1 + rnd.Next() % 10);
            }
           

            foreach (var item in x)
            {
                foreach (var kk in x)
                {
                    summ2 += kk; sum++; 
                }
                _x = summ2 / N; del++;

                summ1 += Math.Pow((item - _x), 2); 
                min++; 
                sum++;
                umn++;
            }
            s1 = Math.Pow(summ1 / (N - 1), 2);
            min++;
            del++; 
            umn++;
            umn--;
            Console.WriteLine("Пример s1: ");          
            Console.WriteLine("S= " + s1 + "\nОпераций сложений: " + sum + "\nОпераций умножения: " + umn + "\nОпераций деления: " + del + "\nОпераций вычитания: " + min);
            Console.WriteLine("_____________________");
            /////////////////////////////////////////////////
            ///
            double summ3 = 0; double summ4 = 0;

            foreach (var item in x)
            {
                summ3 += Math.Pow(item, 2);
                sum1++;
                umn1++;
            }

            foreach (var item in x)
            {
                summ4 += item;
                sum1++;
            }

            s2 = (summ3 - Math.Pow(summ4, 2) / N) / (N - 1);
            min1++;

            del1++;
            Console.WriteLine("Пример s2: ");
            Console.WriteLine("S= " + s2 + "\nОпераций сложения: " + sum1 + "\nОпераций умножения: " + umn1 + "\nОпераций деления: " + del1 + "\nОпераций вычитания: " + min1);
            Console.ReadKey();
            ///////////////////////////////
            Console.WriteLine("Итог сравнения:");
            Console.WriteLine();
            if (sum < sum1)
                Console.WriteLine("Суммы второго примера " + sum1 + " " + "превосходят по количеству суммы первого " + sum);
            else if (sum == sum1)
                Console.WriteLine("Количество сумм в примере равны.");
            else
                Console.WriteLine("Суммы первого примера " + sum + " " + "превосходят по количеству суммы второго " + sum1);
            
                
            if (umn < umn1)
                Console.WriteLine("Умножения второго примера " + umn1 + " " + "превосходят по количеству умножения первого " + umn);
            else if (umn == umn1)
                Console.WriteLine("Количество умножений в примере равны.");
            else
                Console.WriteLine("Умножения первого примера " + umn + " " + "превосходят по количеству умножения второго " + umn1);

            if (del < del1)
                Console.WriteLine("Деления второго примера " + del1 + " " + "превосходят по количеству деления первого " + del);
            else if (del == del1)
                Console.WriteLine("Количество делений в примере равны.");
            else
                Console.WriteLine("Деления первого примера " + del + " " + "превосходят по количеству деления второго " + del1);

            if (min < min1)
                Console.WriteLine("Минусы второго примера " + min1 + " " + "превосходят по количеству минусы первого " + min);
            else if (min == min1)
                Console.WriteLine("Количество вычитайний в примере равны.");
            else
                Console.WriteLine("Минусы первого примера " + min + " " + "превосходят по количеству минусы второго " + min1);
        }
       
    }
}
