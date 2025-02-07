using System.Collections.Specialized;

namespace _1
{
    internal class Program
    {
        static void Task1()
        {
            string name;
            int age;

            name = Console.ReadLine();

            if (int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine($"Здравствуйте, {name}. Ваш возраст: {age}.");
            }
            else
            {
                Console.WriteLine("Неверный ввод!");
            }
        }

        static void Task2()
        {
            int My_int = 123;
            double My_double = 123.123456;
            char My_char = '#';
            string My_string = "аАбБвВ";

            Console.WriteLine($"Число int: {My_int}");
            Console.WriteLine($"Число double: {My_double}");
            Console.WriteLine($"Символ char: {My_char}");
            Console.WriteLine($"Строка string: {My_string}");
        }

        static void Task3()
        {
            int parsed_number;
            string my_number;

            my_number = Console.ReadLine();

            if (int.TryParse(Console.ReadLine(), out parsed_number))
            {
                Console.WriteLine(parsed_number);
            }
            else
            {
                Console.WriteLine("Неверный ввод!");
            }
        }

        static void Task4()
        {
            int parsed_number;
            string my_number;

            my_number = Console.ReadLine();

            if (int.TryParse(Console.ReadLine(), out parsed_number))
            {
                if (parsed_number < 0)
                {
                    Console.WriteLine($"Число {parsed_number} отрицательное");
                }
                else if (parsed_number > 0)
                {
                    Console.WriteLine($"Число {parsed_number} положительное");
                }
                else
                {
                    Console.WriteLine("Введённое число - ноль");
                }
            }
            else
            {
                Console.WriteLine("Неверный ввод!");
            }
        }

        static void Task5()
        {
            int parsed_number;
            string my_number;

            my_number = Console.ReadLine();

            if (int.TryParse(Console.ReadLine(), out parsed_number))
            {
                switch (parsed_number)
                {
                    case 1:
                        Console.WriteLine("Январь");
                        break;
                    case 2:
                        Console.WriteLine("Февраль");
                        break;
                    case 3:
                        Console.WriteLine("Март");
                        break;
                    case 4:
                        Console.WriteLine("Апрель");
                        break;
                    case 5:
                        Console.WriteLine("Май");
                        break;
                    case 6:
                        Console.WriteLine("Июнь");
                        break;
                    case 7:
                        Console.WriteLine("Июль");
                        break;
                    case 8:
                        Console.WriteLine("Август");
                        break;
                    case 9:
                        Console.WriteLine("Сентябрь");
                        break;
                    case 10:
                        Console.WriteLine("Октябрь");
                        break;
                    case 11:
                        Console.WriteLine("Ноябрь");
                        break;
                    case 12:
                        Console.WriteLine("Декабрь");
                        break;
                    default:
                        Console.WriteLine("Неверный ввод!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Неверный ввод!");
            }
        }

        static void Task6()
        {
            int max_num = 100;

            for (int i = 2; i <= max_num; i += 2)
            {
                Console.Write($"{i} ");
            }
        }

        static void Task7()
        {
            int sum = 0, i = 0, max_num = 50;

            while (i <= max_num)
            {
                sum += i;
                i++;
            }

            Console.WriteLine(sum);
        }

        static void Task8()
        {
            int array_size = 10;

            int[] array = new int[array_size];

            for (int i = 0; i < array_size; i++)
            {
                array[i] = i + 1;
                Console.Write($"{array[i]} ");
            }
        }

        static void Task9()
        {
            Console.WriteLine(Random.Shared.Next(0, 11));
        }

        static void Task10()
        {
            int size = 3;

            int[,] matrix = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = Random.Shared.Next(0, 10);
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        static int Task11(int a, int b)
        {
            return a + b;
        }


        static void Task12()
        {
            List<int> list = new List<int>();

            int rand_range = 10, rand_count = 5;

            for (int i = 0; i < rand_count; i++)
            {
                list.Add(Random.Shared.Next(0, rand_range));
                Console.Write($"{list[i]} ");
            }

            Console.WriteLine();

            Console.Write(list.Sum());
        }


        static void Main(string[] args)
        {
            Task12();

            int a, b;

            if (int.TryParse(Console.ReadLine(), out a) && int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine(Task11(a, b));
            }
            else
            {
                Console.WriteLine("Неверный ввод!");
            }
        }
    }
}
