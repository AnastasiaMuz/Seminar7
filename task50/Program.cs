// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

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

Console.Write ("Введите номера позиции элемента массива через Enter: "); 
int a = Convert.ToInt32(Console.ReadLine());

int b = Convert.ToInt32(Console.ReadLine());


for(int i = 0; i < matrix.GetLength(0); i++) //0- обозначает строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 1 - обозначает столбцы
        {
            if(i == a && j == b)
            {
                Console.WriteLine(matrix[i,j]);
            }
            if(a >  matrix.GetLength(0) || b > matrix.GetLength(1))
            {
                Console.WriteLine("В массиве нет такого числа"); 
                break;
            }
            
            
            
        }
        
    }