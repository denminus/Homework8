// Найти произведение двух матриц

void PrintMatr(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillMatr(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] ProductOfMatrices(int[,] matr1, int[,] matr2)
{
    int[,] matr = new int[matr1.GetLength(0), matr2.GetLength(1)];

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = 0;
            for (int l = 0; l < matr1.GetLength(1); l++)
            {
                matr[i, j] = matr[i, j] + matr1[i, l] * matr2[l, j];
            }



        }
        
    }
    return matr;
}



int m = ReadInt("Введите количество строк : ");
int n = ReadInt("Введите количество столбцов: ");


int[,] matrix1 = new int[m, n];
int[,] matrix2 = new int[n, m];
FillMatr(matrix1);
FillMatr(matrix2);
Console.WriteLine("Матрица №1 ");
PrintMatr(matrix1);
Console.WriteLine("Матрица №2 ");
PrintMatr(matrix2);
Console.WriteLine("Произведение матриц ");

int [,] matrix= ProductOfMatrices(matrix1, matrix2);

PrintMatr(matrix);


