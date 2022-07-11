using System;
namespace ConsoleApp29
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Given a non-empty array of integers, return the result of multiplying the values together in order. Example:

            int[,] numbers = { { 1, 8, 5, 63 },{ 4,85,12,35} };
            ReturnMultiplicationMethodOfGivenArray(numbers);
        }
        public static void ReturnMultiplicationMethodOfGivenArray(int[,] numbers)
        {
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    if(i==numbers.GetLength(0)-1 && j == numbers.GetLength(1) - 1)
                    {
                    Console.Write($"{numbers[i,j]}");
                    }

                    else
                    {
                        Console.Write($"{numbers[i, j]} *");
                    }

                }
            }
            
        }
    }
}