// Сформировать трехмерный массив не повторяющимися двузначными числами 
// показать его построчно на экран выводя индексы соответствующего элемента

void PrintMatr(int[, , ] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(1); k++)
            {
                
                Console.Write($"{matr[i, j, k]} ");
            }
        }
        Console.WriteLine();
    }
}

void PrintMatrIndex(int[, , ] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(1); k++)
            {
                
                Console.WriteLine($"{matr[i, j, k]} Индекс {i}, {j}, {k} ");
            }
        }
        Console.WriteLine();
    }
}
void FillArray (int[, , ] matr)
{   int count =0;
    for (int i=0;i<matr.GetLength(0); i++)
    {
        for(int j =0; j<matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                matr[i,j,k]=count+10;
                count++;
            }            
                           
                
        }
    }   
    
}                      

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int m = ReadInt("Введите чило значений стороны трехмерного массива  : ");

int[, ,] matrix3 = new int[m, m , m];
FillArray(matrix3);
Console.WriteLine("Матрица исходная ");
PrintMatr(matrix3);
Console.WriteLine("трехмерный массив , построчно c индексами соответствующего элемента ");
PrintMatrIndex(matrix3);

