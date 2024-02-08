using System;


namespace travis_scott
{
    class LVL1
    {
        private int[] array;

        public LVL1(int l, bool f)
        {
            array = new int[l];
            if (!f)
            {
                RndFill();
            }
            else
            {
                UserFill();
            }
        }


        public void Print()
        {
            PrintIn(array);
        }

        private void PrintIn(int[] arr)
        {
            int l1 = arr.Length;
            for (int i = 0; i < l1; i++)
            {
                if (i == l1 - 1) { Console.WriteLine($"{arr[i]}"); }
                else { Console.Write($"{arr[i]} "); }
            }
        }


        public void Average()
        {
            int sum = 0;
            foreach (int el in array)
            {
                sum += el;
            }
            Console.WriteLine(sum / array.Length);
        }


        public void Delete100()
        {
            int new_len = 0;
            int i = 0;
            foreach (int el in array)
            {
                if (Math.Abs(el) <= 100)
                {
                    new_len++;
                }
            }
            int[] new_arr = new int[new_len];
            foreach (int l in array)
            {
                if (Math.Abs(l) < 100)
                {
                    new_arr[i] = l;
                    i++;
                }
            }
            PrintIn(new_arr);
        }


        public void Uniqal()
        {
            int[] newArray = new int[array.Length];
            int uniq = 1;
            for (int i = 0; i < array.Length; i++)
            {
                bool isUniq = true;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        isUniq = false;
                    }
                }
                if (isUniq)
                {
                    newArray[uniq - 1] = array[i];
                    uniq++;
                }
            }
            PrintIn(newArray);
        }

        private void UserFill()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Элемент {i}: ");
                int x = int.Parse(Console.ReadLine());
                array[i] = x;
            }
        }

        private void RndFill()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Program.Rnd.Next(-1000, 1000);
            }
        }
    }
}

