// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] FillMatrix(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 10)
{
    int[,] matrix = new int[rowsCount, columnsCount];
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) //0- обозначает строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 1 - обозначает столбцы
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matrix;

}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++) //0- обозначает строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 1 - обозначает столбцы
        {
            Console.Write(matrix [i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.Write ("Введите m и n через Enter: "); //число строк
int m = Convert.ToInt32(Console.ReadLine());

int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine();



for(int i = 0; i < matrix.GetLength(1); i++) //0- обозначает столбцы
    {
        double sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++) // 1 - обозначает строки
        {
           sum = sum + matrix[j,i];
            
        }
        Console.WriteLine(sum);
        double averageSum = sum/m;
        Console.WriteLine(averageSum);

    }
