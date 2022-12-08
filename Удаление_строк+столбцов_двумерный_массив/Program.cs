// Удаление строки и столбца на пересечении наименьшего элемента в двумерном массиве.
// Первый вариант:
int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] array = new int[rows, columns];
FillArray(array);
PrintMatrix(array);
PrintMatrix(DeletedMas(array));
int Min(int[,] array)
{
    int min = int.MaxValue; //int.MaxValue - функция для нахождения максимального числа в массиве.
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
            }
        }
    }
    return min;
}
int[] Find(int[,] array)
{
    int b = Min(array);
    int[] m = new int[2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == b)
            {
                m[0] = i;
                m[1] = j;
                break;
            }
        }
    }
    return m;
}
int[,] DeletedMas(int[,] array)
{
    int[] c = Find(array);
    int[,] otv = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int otvI = 0;
    int otvJ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == c[0])
            continue;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == c[1])
                continue;
            otv[otvI, otvJ] = array[i, j];
            otvJ++;
        }
        otvI++;
        otvJ = 0;
    }
    return otv;
}

void PrintMatrix(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            Console.Write($"{image[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void FillArray(int[,] matr)
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
    return Convert.ToInt32(Console.ReadLine());
}

// Второй вариант:
int[,] newArray = new int[rows - 1, columns - 1];
for (int i = 0; i < newArray.GetLength(0); i++)
{
    for (int j = 0; j < newArray.GetLength(1); j++)
    {
        if (i < rowDelete && j < columnDelete) //rowDelete и columnDelete - переменые, в которые нужно выести
            newArray[i, j] = array[i, j];      //индексы минимального числа в заданном двумерном массиве.
        else if (i < rowDelete && j >= columnDelete)
            newArray[i, j] = array[i, j + 1];
        else if (i >= rowDelete && j < columnDelete)
            newArray[i, j] = array[i + 1, j];
        else
            newArray[i, j] = array[i + 1, j + 1];
    }
}