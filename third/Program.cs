using System;

namespace Lessons
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int[] myArray = new int[5];


            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("Введите {0}-й элемент", i + 1);

                myArray[i] = int.Parse(Console.ReadLine());

            }
            Console.Write("Наш масив : ");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");

            }
            Console.WriteLine(" ");
            Console.Write("Четные числа : ");

            int EvenNum = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    Console.Write(myArray[i] + " ");
                    EvenNum += myArray[i];
                }
            }
            Console.WriteLine(" ");
            Console.Write("Cумма четных чисел : " + EvenNum);
            Console.WriteLine(" ");
            int min = myArray[0];
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] < min)
                    min = myArray[i];
            }
            Console.Write("Минимальное число масива : " + min);
            Console.WriteLine(" ");

            Console.Write("Масив на оборот : ");
            for (int i = myArray.Length - 1; i >= 0; i--)
            {
                Console.Write(myArray[i] + " ");
            }
            Console.ReadLine();
        }
    }
}