namespace hwlab5ArraysProp
{
    internal class Program
    {


        static void AddItemArray(int[] value)
        {

            int sumArray = 0;

            foreach (var item in value)
            {
                sumArray += item;
            }

            Console.WriteLine($"Сумма элементов массива равна {sumArray}");

        }

        static void AverageItemArrray(int[] value)
        {
            double sumArray = 0;
            double count = 0;

            foreach (var item in value)
            {
                sumArray += item;
                count++;
            }

            double averageMass = (double)(sumArray / count);

            Console.WriteLine($"Среднее значение элементов массива: {averageMass}");
        }

        static void CountAddNegPos(int[] value)
        {
            int negativeSum = 0;
            int positiveSum = 0;

            foreach (var item in value)
            {
                if (item < 0)
                {
                    negativeSum += item;
                }
                else
                {
                    positiveSum += item;
                }


            }

            Console.WriteLine($"Сумма отрицательных элементов:{negativeSum} Сумма положительных элементов {positiveSum} ");
        }


        static void CountAddEventOddIndex(int[] value)
        {

            int oddSum = 0;
            int evenSum = 0;
            for (int i = 0; i < value.Length; i++)
            {
                if (i % 2 == 0)
                {
                    evenSum += value[i];
                }
                else
                {
                    oddSum += value[i];
                }
            }



            Console.WriteLine($"Сумма элементов с четными индексами:{evenSum} Сумма элементов c нечетными индексами {oddSum} ");
        }



        static void MinMaxElementArray(int[] value)
        {

            int rangeMul = 1;
            int minElement = value[0];
            int indexMin = 0;

            int maxElement = value[0];
            int indexMax = 0;

            for (int i = 1; i < value.Length; i++)
            {
                if (value[i] < minElement)
                {
                    minElement = value[i];
                    indexMin = i;
                }
            }

            for (int i = 1; i < value.Length; i++)
            {
                if (value[i] > maxElement)
                {
                    maxElement = value[i];
                    indexMax = i;
                }
            }

            for (int i = 0; i < value.Length; i++)
            {
                if (i > indexMin && i < indexMax)
                {
                    rangeMul *= value[i];
                }
            }

            Console.WriteLine($"Минbмальный элемент массива {minElement} индекс элемента:{indexMin}");
            Console.WriteLine($"Максимальный элемент массива {maxElement} индекс элемента:{indexMax}");
            Console.WriteLine($"Произведение элементов в итервале от минемального до максимального индекса:{rangeMul}");

        }


        static void Main(string[] args)
        {
            Console.WriteLine($"Введите колличество элементов массива");
            int it = int.Parse(Console.ReadLine());

            int[] arr = new int[it];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Введите {i + 1} элемент массива");
                arr[i] = int.Parse(Console.ReadLine());


            }

            AddItemArray(arr);
            AverageItemArrray(arr);
            CountAddNegPos(arr);
            CountAddEventOddIndex(arr);
            MinMaxElementArray(arr);






        }



    }





}