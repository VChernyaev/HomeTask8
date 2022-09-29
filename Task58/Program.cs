// программа, которая находит произведение двух матриц
Console.WriteLine("Enter the count of rows");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the count of colums");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, colums];
int[,] secondArray = new int[rows,colums];
int[,] resultArray = new int[rows, colums];

FillArrayRandom(array);
PrintArray(array);

Console.WriteLine();

FillArrayRandom(secondArray);
PrintArray(secondArray);

Console.WriteLine();

if (array.GetLength(0) != secondArray.GetLength(1))
{
    Console.WriteLine("Умножение невозможно");
    return;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            resultArray[i, j] += array[i, k] * secondArray[k, j];
        }
    }
}

PrintArray(resultArray);


void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

 
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}