int rows = 4;
int columns = 3;

int[,] array = new int[4, 3];

for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(11);
        Console.Write(array[i, j] + "\t");

    }
    Console.WriteLine();
}
Console.WriteLine();

double[] average = new double[columns];

    for(int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
         for(int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        average[j] = sum / rows;
    }

Console.Write("Среднее арифметическое каждого столбца: ");

for(int l=0; l<average.Length-1 ;l++)
{
    Console.Write($"{average[l]}" + "; ");
}
Console.Write($"{average[average.Length-1]}" + "; ");
