/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/

Console.Clear();
Console.WriteLine("Введите количество элементов в массиве ");
int numberElements = Convert.ToInt32(Console.ReadLine());
int RandomNumbers(int numberElements, int min, int max)
{
   int[] randomNumbers = new int[numberElements];
   int sumElenents = 0;
   Console.Write("Получившийся массив: ");
   for (int i = 0; i<randomNumbers.Length; i++)
   {
    randomNumbers[i]= new Random().Next(min,max);
    Console.Write(randomNumbers[i]+ " ");
    if(i%2!=1)
    {
        sumElenents=sumElenents + randomNumbers[i];
    }
   }
   return sumElenents;
} 
int randomNumbers = RandomNumbers(numberElements, 1, 10);
Console.WriteLine();
Console.WriteLine($"Сумма элементов массива стоящих на нечётных позициях равна: {randomNumbers}");

