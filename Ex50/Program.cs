Console.Write("Введите значение строки искомого элемента: ");
int rowsValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение столбца искомого элемента: ");
int columnsValue = Convert.ToInt32(Console.ReadLine());

int[,] array = new int [5, 6];
bool result = false;
var findingElement = array[0, 0];

for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(-10, 11);
        if(rowsValue == i && columnsValue == j)
        {
            result = true; 
            findingElement = array[i, j];
        } 
        Console.Write(array[i, j] + "\t");

    }
    Console.WriteLine();
}

if(result == true) Console.WriteLine($"Элемент {rowsValue}, {columnsValue} -> {findingElement}");
else Console.WriteLine($"Элемент {rowsValue}, {columnsValue} -> такого элемента нет");







