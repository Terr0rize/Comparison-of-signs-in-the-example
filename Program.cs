using System;
using System.Collections.Generic;
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

            Console.WriteLine("Пример s1: ");          
            Console.WriteLine("S= " + s1 + "\nОпераций сложений: " + sum + "\nОпераций умножения: " + umn + "\nОпераций деления: " + del + "\nОпераций вычитания: " + min);
            Console.WriteLine("_____________________");
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
            min1 += 2;
            umn1++; 
            del1 += 2;
            Console.WriteLine("Пример s2: ");
            Console.WriteLine("S= " + s2 + "\nОпераций сложения: " + sum1 + "\nОпераций умножения: " + umn1 + "\nОпераций деления: " + del1 + "\nОпераций вычитания: " + min1);
            Console.ReadKey();           
        }

    }
}