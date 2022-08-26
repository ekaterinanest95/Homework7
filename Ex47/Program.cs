double [,] array = new double [3, 4];

for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = Convert.ToDouble(new Random().Next(-10, 11) / 10.0);
        Console.Write(array[i, j] + "\t");

    }
    Console.WriteLine();
}


