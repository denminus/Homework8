/* Составить частотный словарь элементов  массива
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
Пример: Есть набор данных
{ 1, 9, 9, 0, 2, 8, 0, 9 }
частотный массив может быть представлен так:
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза

*/
void PrintArray(int[] array)                     
{
    Console.Write(String.Join(' ', array));
    Console.WriteLine();
}



int[] CreateArray (int size, int min, int max)
{
    int[]array = new int[size];
    for (int i=0; i< array.Length; i++)    
    array[i] = new Random().Next(min, max+1);
    return array;
}



void SelectSort(int []array)
{
    
    for (int i=0; i<array.Length-1; i++)
    {
        int minPosition = i;
        for (int j=i+1; j<array.Length; j++)
        {
            if (array[j]< array[minPosition] ) minPosition = j;
        }

        int temporary= array[i];      
        array[i]=array[minPosition];
        array[minPosition]=temporary;
        
    }
}

void ChastotniyMassiv(int[] array)
{
    int value = array[0];
    int quantity = 0;
         for (int j = 0; j < array.Length; j++)
            {
                if (array[0] == array[j])
                {
                    value = array[j];
                    quantity++;
                }
            }

            Console.WriteLine($"Значение {value} повторяется {quantity} раз");
    
    
    
    for (int i = 0; i < array.Length; i++)
    {   
        if (value != array[i])
        {
            quantity = 0;
            for (int j = 0; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    value = array[j];
                    quantity++;
                }
            }

            Console.WriteLine($"Значение {value} повторяется {quantity} раз");
        }


    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int size =ReadInt("Введите длинну массива ");
int min =ReadInt("Введите левую часть диапазона ");
int max =ReadInt("Введите правую часть диапазона ");



int[] massiv= CreateArray (size, min,max);
Console.Write("Ваш массив ");

PrintArray(massiv);
SelectSort(massiv);
ChastotniyMassiv(massiv);