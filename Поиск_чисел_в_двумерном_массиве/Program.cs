// Создать словарь, сколько раз встречается число в массиве.
// Первый способ:
int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] array = new int[rows, columns];
FillArray(array);
PrintMatrix(array);
SortArray(array);
PrintMatrix(array);
int[,] dictionary = FrequencyDictionary(array);
for (int i = 0; i < dictionary.GetLength(0); i++)
{
    Console.WriteLine($"{dictionary[i, 0]} встречается {dictionary[i, 1]}");
}
int[,] FrequencyDictionary(int[,] matrix)
{
    int size = CalculateCountNumbers(matrix);
    int[,] dictionary = new int[size, 2];
    int dictionaryIndex = 0;
    dictionary[dictionaryIndex, 0] = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (dictionary[dictionaryIndex, 0] == matrix[i, j])
                dictionary[dictionaryIndex, 1]++;
            else
            {
                dictionaryIndex++;
                dictionary[dictionaryIndex, 0] = matrix[i, j];
                dictionary[dictionaryIndex, 1] = 1; //или ++ (как выше)
            }
        }
    }
    return dictionary;
}
void SortArray(int[,] matrix) //метод сортировки двумерного массива от большего к меньшему
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int a = 0; a < matrix.GetLength(0); a++)
            {
                for (int b = 0; b < matrix.GetLength(1); b++)
                {
                    if (matrix[a, b] < matrix[i, j])
                    {
                        int temp = matrix[i, j];
                        matrix[i, j] = matrix[a, b];
                        matrix[a, b] = temp;
                    }
                }
            }
        }
    }
}
int CalculateCountNumbers(int[,] sortArray)
{
    int countNumbers = 1;
    int tempNumber = sortArray[0, 0];
    for (int i = 0; i < sortArray.GetLength(0); i++)
    {
        for (int j = 0; j < sortArray.GetLength(1); j++)
        {
            if (tempNumber != sortArray[i, j])
            {
                tempNumber = sortArray[i, j];
                countNumbers++;
            }
        }
    }
    return countNumbers;
}

//Второй способ:
int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] array = new int[rows, columns];
int minValue = array[0, 0];
int maxValue = array[0, 0];
FillArray(array);
PrintMatrix(array);
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] < minValue)
            minValue = array[i, j];
        if (array[i, j] > maxValue)
            maxValue = array[i, j];
    }
}
int[] quantity = new int[maxValue - minValue + 1];
for (int count = 0; count < quantity.Length; count++)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == minValue)
            {
                quantity[count]++;
            }
        }
    }
    if (quantity[count] > 0)
    {
        Console.WriteLine($"{minValue} встречается {quantity[count]} раз");
    }
    minValue++;
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
