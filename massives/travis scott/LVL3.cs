using System;

namespace travis_scott
{
    class LVL3
    {
        private int[][] array;

        public LVL3(int a1, bool f)
        {
            array = new int[a1][];

            if (!f)
            {
                RndFill();
            }

            else
            {
                UserFill();
            }
        }




        public void global_average()
        {
            int sum = 0;
            int el = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    int x = array[i][j];
                    sum += x;
                    el++;
                }
            }
            Console.WriteLine($"Среднее арифметическое целого массива: {sum / el}");
        }


        public void local_average()
        {
            int sum = 0;
            int el = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int[] arr = array[i];
                foreach (int x in arr)
                {
                    sum += x;
                    el++;
                }
                Console.WriteLine($"Ср.арифм. [{i}] подмассива: {sum / el}");
                sum = 0;
                el = 0;
            }
        }


        public void Print()
        {
            PrintIn(array);
        }

        private void PrintIn(int[][] arr)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (j == arr[i].Length - 1)
                    {
                        Console.WriteLine(arr[i][j]);
                    }


                    else
                    {
                        Console.Write($"{arr[i][j]} ");
                    }
                }
            }
        }


        public void SwapOnInd()
        {
            int[][] arr = new int[array.Length][];
            for (int i = 0; i < array.Length; i++)
            {
                arr[i] = new int[array[i].Length];
                for (int j = 0; j < array[i].Length; j++)
                {
                    int x = array[i][j];
                    if (x % 2 == 0)
                    {
                        arr[i][j] = i * j;
                    }

                    else
                    {
                        arr[i][j] = x;
                    }
                }
            }
            PrintIn(arr);
        }

        private void UserFill()
        {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"Длина {i} массива: ");
                    int l = int.Parse(Console.ReadLine());
                    array[i] = new int[l];
                    for (int j = 0; j < l; j++)
                    {
                        Console.Write($"Элемент [{i},{j}]: ");
                        int x = int.Parse(Console.ReadLine());
                        array[i][j] = x;
                    }
                }
        }

        private void RndFill()
        {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"Длина {i} массива: ");
                    int l = int.Parse(Console.ReadLine());
                    array[i] = new int[l];
                    for (int j = 0; j < l; j++)
                    {
                        int x = Program.Rnd.Next(-1000, 1000);
                        array[i][j] = x;
                    }
                }
        }
    }
}
