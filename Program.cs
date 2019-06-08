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
                        int elem = 0;
                        Console.WriteLine("Введите элемент для поиска");
                        try
                        {
                            if (!int.TryParse(Console.ReadLine(), out elem))
                            {
                                throw new Exception("Введено некоррекатное значение для поиска в массиве");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"{e.Message}\nВведите корректное значение для поиска");
                            if (!int.TryParse(Console.ReadLine(), out elem))
                            {
                                Console.WriteLine("Программа завершает работу...");
                            }
                        }
                        finally
                        {
                            int result = b.BSearch(arr, elem);
                            if (result != -1)
                            {
                                Console.WriteLine($"Элемент найден на позиции ->{result}");
                            }
                            else
                            {
                                Console.WriteLine("Элемент не обнаружен");
                            }
                        }
                        break;
                    }
                case 1:
                    {
                        arr = l.GetArray(1);
                        s.ArraySort(arr);
                        ShowArray(arr);
                        int elem = 0;
                        Console.WriteLine("Введите элемент для поиска");
                        try
                        {
                            if (!int.TryParse(Console.ReadLine(), out elem))
                            {
                                throw new Exception("Введено некоррекатное значение для поиска в массиве");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"{e.Message}\nВведите корректное значение для поиска");
                            if (!int.TryParse(Console.ReadLine(), out elem))
                            {
                                Console.WriteLine("Программа завершает работу...");
                            }
                        }
                        finally
                        {
                            int result = b.BSearch(arr, elem);
                            if (result != -1)
                            {
                                Console.WriteLine($"Элемент найден на позиции ->{result}");
                            }
                            else
                            {
                                Console.WriteLine("Элемент не обнаружен");
                            }
                        }
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