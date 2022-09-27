// задайте двумерный массив
// напишите программу, которая упорядочит по убыванию элементы каждой строки 

Console.WriteLine("Enter the count of rows");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the count of colums");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, colums];
CreateArray(array);
PrintArray(array);
SortArray(array);
Console.WriteLine();
PrintArray(array);

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(1) - 1; l++)
            {
                if (array[i, l] < array[i, l + 1])
                {
                    int temp = array[i, l + 1];
                    array[i, l + 1] = array[i, l];
                    array[i, l] = temp;
                }
            }

        }

    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}" + "\t");

        }
        Console.WriteLine();
    }
}