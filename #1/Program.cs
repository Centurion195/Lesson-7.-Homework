// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

int[,] CreateAndFillArray(int rows, int columns, int lower, int hightest){
    int[,] array = new int[rows, columns];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = random.Next(lower, hightest);
    }
    return array;
}

int ReadInt(string message){
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void PrintArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
           Console.Write($"{array[i,j]}\t");
        Console.WriteLine();
    }
}

void ArithmeticMeanColumnsArray(int[,] array){
    double sum = 0;
    for (int i = 0; i < array.GetLength(1); i++){
        for (int j = 0; j < array.GetLength(0); j++)
            sum +=array[j,i];
        Console.Write($"{Math.Round(sum/array.GetLength(0),2)}\t");
        sum = 0;
    }
}

Console.Clear();
int rows = ReadInt("Enter the number of rows: ");
int columns = ReadInt("Enter the number of columns: ");
int lowest = 1;
int hightest = 10;

int[,] array = CreateAndFillArray(rows, columns, lowest, hightest);
PrintArray(array);
Console.WriteLine();
ArithmeticMeanColumnsArray(array);