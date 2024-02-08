using System;

namespace travis_scott
{
    class LVL2
    {
        private int[,] array;

        public LVL2(int a1, int b1, bool fill)
        {
            array = new int[b1, a1];

            if (fill)
            {
                UserFill();
            }
            else
            {
                RndFill();
            }
        }

        public void Print()
        {
            PrintIn(array);
        }

        private void PrintIn(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (j == arr.GetLength(1) - 1) { Console.WriteLine(arr[i, j]); }
                    else { Console.Write($"{arr[i, j]} "); }
                }
            }
        }


        public void Average()
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
            }
            Console.WriteLine($"Среднее арифметическое: {sum / (array.GetLength(0) * array.GetLength(1))}");
        }


        public void Snake()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    for (int j = array.GetLength(1) - 1; j >= 0; j--)
                    {
                        if (j == 0)
                        {
                            Console.WriteLine($"{array[i, j]}");
                        }
                        else
                        {
                            Console.Write($"{array[i, j]} ");
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (j == array.GetLength(1) - 1)
                        {
                            Console.WriteLine($"{array[i, j]}");
                        }
                        else
                        {
                            Console.Write($"{array[i, j]} ");
                        }
                    }
                }
            }
        }

        private void UserFill()
        {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write($"Элемент ({i},{j}): ");
                        array[i, j] = int.Parse(Console.ReadLine());
                    }
                }
        }

        private void RndFill()
        {
                Random rnd = new Random();
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = Program.Rnd.Next(-1000, 1000);
                    }
                }
        }
    }
}
