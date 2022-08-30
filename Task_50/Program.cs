// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(0, 10);
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}

Console.Clear();

Console.Write("Введите количество строк: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int j = Convert.ToInt32(Console.ReadLine());
Console.Write("введите номер строки: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("введите номер столбца: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[i, j];
Console.WriteLine();

FillArrayRandomNumbers(array);

PrintArray(array);

if (n > array.GetLength(0) || m > array.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {array[n-1,m-1]}");
}

