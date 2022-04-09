void CreateArrayNull(int[,] mass)
{
    for(int i = 0; i < mass.GetLength(0); i++)
    {
        for(int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = 0;
        }
    }
}

void FillArray(int[,] mass)
{
    for(int i = 0; i < mass.GetLength(0); i++)
    {
        for(int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write(mass[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк в массиве: ");
int str = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число с котрого будет начинаться массив: ");
int numb = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[str, column];

void ContourArray(int[,] mass)
{
    int j = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        if(i == 0)
        {
            while(j < column)
            {
                array[i, j] = numb;
                numb++;
                j++;
            }
        }
        else if(i == str - 1)
        {
            while(j > 0)
            {
                array[i, j - 1] = numb;
                numb++;
                j--;
            }
        }
        else 
        {
            array[i, j-1] = numb;
            numb++;
        }
    }

    for(int h = str-1; h > 1; h--)
    {
        array[h-1, 0] = numb;
        numb++;
    }
}

void CreateArray(int a, int b)
{
    if(array[a, b] == 0)
    {
       array[a, b] = numb;
       numb++;
       CreateArray(a, b+1);
       CreateArray(a+1, b);
       CreateArray(a, b-1);
       CreateArray(a-1, b);
    }
}

CreateArrayNull(array);
ContourArray(array);
CreateArray(1, 1);
FillArray(array);