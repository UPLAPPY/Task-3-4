﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf_to_2024._02._02
{
    sealed class Array2: BaseArr, IBaseArr, IPrinter
    {
        private int[,] arr;

        private static Random rnd = new Random();

        public Array2(bool AvtoInput)
        {
            Create(AvtoInput);
        }

        public override void Create(bool avto_input)
        {
            Console.WriteLine("Введите количество строк и столбцов массива, \n" +
                    "Каждое значение с новой строки:");
            int stroki = Convert.ToInt32(Console.ReadLine());
            int stolbiki = Convert.ToInt32(Console.ReadLine());
            arr = new int[stroki, stolbiki];
            base.Create(avto_input);
        }

        public override void AvtoInput()
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(1, 33);
                }
            }
        }

        public override void ArrayInput()
        {
            Console.WriteLine("Введите элементы, каждый с новой строки");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public override void PrintArray()
        {
                        for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public override void Average()
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i, j];
                }
            }
            Console.WriteLine(sum / (arr.GetLength(0) * arr.GetLength(1)));
        }
    }
}