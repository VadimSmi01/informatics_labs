using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace task_1_sorting
{
    class Program
    {
        static public string Comand;
        static void Main(string[] args)
        {
            int dopuslovie;
            double[] arr = new double[8];
            bool arrayEntered = false;
            while (true)
            {
               // Comand = Console.ReadLine();
                //if (Comand == "menu")
                {
                    Console.WriteLine("СПИСОК ДЕЙСТВИЙ");
                    Console.WriteLine("[1] Заполнение массива");
                    Console.WriteLine("[2] Полная сортировка пузырьком");
                    Console.WriteLine("[3] Альтернативная сортировка пузырьком");
                    Console.WriteLine("[4] Выход");
                    Comand = Console.ReadLine();
                    switch (Comand)
                    {

                        case "1": //ввод массива
                            try
                            {
                                Console.WriteLine("Введите восемь чисел");
                                for (int i = 0; i < arr.Length; i++)
                                {
                                    Console.Write("{0}-е число: ", i + 1);
                                    arr[i] = double.Parse(Console.ReadLine());
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Возникла ошибка,вы ввели не число");
                            }
                            arrayEntered = true;
                            break;

                        case "2": //сортировка пузырьком
                            if (arrayEntered)
                            {
                                try
                                {
                                    Console.WriteLine("Выбор направления сортировки");
                                    Console.WriteLine("1. По возрастанию");
                                    Console.WriteLine("2. По убыванию");
                                    Console.WriteLine();
                                    dopuslovie = int.Parse(Console.ReadLine());


                                    if (dopuslovie == 1)
                                    {


                                        // сортировка
                                        double b;
                                        for (int i = 0; i < arr.Length - 1; i++)
                                        {
                                            for (int j = i + 1; j < arr.Length; j++)
                                            {
                                                if (arr[i] > arr[j])
                                                {
                                                    b = arr[i];
                                                    arr[i] = arr[j];
                                                    arr[j] = b;
                                                }
                                            }
                                        }

                                        // вывод
                                        Console.WriteLine("Вывод отсортированного массива");
                                        
                                        {
                                            Console.WriteLine("[{0}]", string.Join(", ", arr));
                                        }
                                        Console.ReadLine();
                                    }
                                    else if (dopuslovie == 2)
                                    {
                                        // сортировка
                                        double t;
                                        for (int i = 0; i < arr.Length - 1; i++)
                                        {
                                            for (int j = i + 1; j < arr.Length; j++)
                                            {
                                                if (arr[i] < arr[j])
                                                {
                                                    t = arr[i];
                                                    arr[i] = arr[j];
                                                    arr[j] = t;
                                                }
                                            }
                                        }

                                        // вывод
                                        Console.WriteLine("Вывод отсортированного массива");
                                        
                                        {
                                            Console.WriteLine("[{0}]", string.Join(", ", arr));
                                        }
                                        Console.ReadLine();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Введенно неизвестное действие");
                                    }
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Возникла ошибка,вы ввели не верную команду");
                                }
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Возникла ошибка,вы не заполнили массив");
                            }
                            break;

                        case "3":
                            if (arrayEntered)
                            {
                                double[] ms1 = new double[4];
                                double[] ms2 = new double[4];
                                for (int i = 0; i < arr.Length / 2; i++)
                                {
                                    ms1[i] = arr[i];
                                    ms2[i] = (arr[i] + arr.Length / 2);

                                }

                                double z;
                                for (int i = 0; i < ms1.Length - 1; i++)
                                {
                                    for (int j = i + 1; j < ms1.Length; j++)
                                    {
                                        if (ms1[i] > ms1[j])
                                        {
                                            z = ms1[i];
                                            ms1[i] = ms1[j];
                                            ms1[j] = z;
                                        }
                                    }
                                }

                                double u;
                                for (int i = 0; i < ms2.Length - 1; i++)
                                {
                                    for (int j = i + 1; j < ms2.Length; j++)
                                    {
                                        if (ms2[i] < ms2[j])
                                        {
                                            u = ms2[i];
                                            ms2[i] = ms2[j];
                                            ms2[j] = u;
                                        }
                                    }
                                }

                                {
                                    double[] zaz = new double[8];
                                    Array.Copy(ms1, 0, zaz, 0, 4);
                                    Array.Copy(ms2, 0, zaz, 4, 4);
                                    Console.WriteLine("Вывод отсортированного массива");
                                    
                                    {
                                        Console.WriteLine("[{0}]", string.Join(", ", zaz));
                                    }
                                }
                                Console.ReadLine();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Возникла ошибка,вы не заполнили массив");
                            }
                            break;

                        case "4":
                            {
                                Environment.Exit(0);
                            }
                            break;

                        default:
                            Console.WriteLine("Ошибка, ввели не то действие");
                            break;
                            
                    }






                }

            }
               
            
            
            
            
            
            
            
            
            // ввод чисел
          /*      int[] nums = new int[8];
            Console.WriteLine("Введите восемь чисел");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("{0}-е число: ", i + 1);
                nums[i] = Int32.Parse(Console.ReadLine());
            }

            // сортировка
            int temp;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }

            // вывод
            Console.WriteLine("Вывод отсортированного массива");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.ReadLine(); */
        }
    }
}
        
    

