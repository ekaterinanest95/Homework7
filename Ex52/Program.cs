
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

double[] result = new double[columns];

//double GetAverageOfColumns(int[,] array)
//{
    double average = 0;
    double sum = 0;

      for(int j = 0; j < array.GetLength(1); j++)
    {
         for(int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
            average = sum / rows;
            for(int k = 0; k < result.Length; k++)
            {
                result[k] = average;
                Console.Write($"{result[k]}" + "; ");
                break;
            }
            sum = 0;
            
    }
  //  return double[] result;
//}



//Console.Write($"Среднее арифметическое каждого столбца: {GetAverageOfColumns(array)}");

