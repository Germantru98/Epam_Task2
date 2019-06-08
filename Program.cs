using System;

namespace Epam_Task2
{
    internal class Program
    {
        private static void ShowArray(int[] arr)
        {
            foreach (var i in arr)
            {
                Console.WriteLine("arr= " + i);
            }
        }

        private static void Main(string[] args)
        {
            ArrayLoader l = new ArrayLoader();
            Sort s = new Sort();
            BinarySearch b = new BinarySearch();
            Console.WriteLine("Выберите вариант ввода массива\n0-c клавиатуры\n1-из файла");
            int caseSwitch = int.Parse(Console.ReadLine());
            int[] arr;
            switch (caseSwitch)
            {
                case 0:
                    {
                        arr = l.GetArray(0);
                        s.ArraySort(arr);
                        ShowArray(arr);
                        Console.WriteLine("Выберите элемент для поиска");
                        int elem = int.Parse(Console.ReadLine());
                        b.BSearch(arr, elem, 0, 14);
                        break;
                    }
                case 1:
                    {
                        arr = l.GetArray(1);
                        s.ArraySort(arr);
                        ShowArray(arr);
                        Console.WriteLine("Выберите элемент для поиска");
                        int elem = int.Parse(Console.ReadLine());
                        b.BSearch(arr, elem, 0, 14);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Введено неверное значение");
                        break;
                    }
            }
            
            
        }
    }
}