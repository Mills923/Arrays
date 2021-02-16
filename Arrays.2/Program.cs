using System;

namespace FlatteningArray
{
    class Program
    {
        static void FlattenArray()
        {
            string[] fruit = new string[3] { "apple", "banana", "cherry" };

            //fruit.GetLength(0) = 3
            //fruit.GetLength(1) = error. only a single dimension array


            int[,,] thirdDimension =
            {
                {
                    {1,2,10,20 },
                    {3,4,15,16 },
                    {5,6,17,18 }
                },
                {
                    {110,111,120,121 },
                    {112,113,130,131 },
                    {114,115,140,141 }
                }
            };
            //thirdDimension.GetLength(0) = 2
            //thirdDimension.GetLength(1) = 3
            //thirdDimension.GetLength(2) =4
            //thirdDimension[1,2,2] = 140



            int[,] multi =
            {
                {1,25,3, 10  },
                {45,5,6, 11  },
                {7,82,9, 12  }
            };

            //int arraySize = multi.GetLength(0);
            //arraySize *= multi.GetLength(1);
            //int[] flat = new int[arraySize];

            int[] flat = new int[multi.Length];
            int count = 0;

            for (int i = 0; i < multi.GetLength(0); i++)
            {
                for (int j = 0; j < multi.GetLength(1); j++)
                {
                    flat[count++] = multi[i, j];

                }

            }
            foreach (var n in flat)
            {
                Console.Write(n + ", ");
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            FlattenArray();
        }
    }
}