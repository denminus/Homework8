// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых 
// расположен наименьший элемент.
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
void FillArray (int[,] matr)
{   int count =0;
    for (int i=0;i<matr.GetLength(0); i++)
    {
        for(int j =0; j<matr.GetLength(1); j++)
        {
            matr[i, j] = count;
            count++;            
                           
                
        }
    }   
    
}
            
           


int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}


int [,] RemovRowCol (int[,] matrix)
{   int min = matrix[0, 0] , minrow=0, mincol=0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            
            if (min>matrix[i,j])
            { min=matrix[i,j];
              minrow=i;
              mincol=j;
             }
        }
    }
    int[,] matrdelrow = new int[matrix.GetLength(0)-1, matrix.GetLength(1)];
            int x = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (i == minrow)
                {
                    minrow = -1;
                    continue;
                }
 
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrdelrow [x, j] = matrix[i, j];
                }
                x++;
            }
    int[,] matrdelcol = new int[matrdelrow.GetLength(0), matrdelrow.GetLength(1)-1];
            for (int i = 0; i < matrdelrow.GetLength(0); i++)
            {
                x = 0;
                for (int j = 0; j < matrdelrow.GetLength(1); j++)
                {
                    if (j == mincol)continue;
                    matrdelcol[i, x] = matrdelrow[i, j];
                    x++;
                }
            }       
    return  matrdelcol;   
}





int m = ReadInt("Введите количество строк : ");
int n = ReadInt("Введите количество столбцов: ");


int[,] matrix1 = new int[m, n];
FillArray(matrix1);
Console.WriteLine("Матрица исходная ");
PrintMatr(matrix1);
int [,] matrix= RemovRowCol(matrix1);
Console.WriteLine("Матрица измененная ");
PrintMatr(matrix);
