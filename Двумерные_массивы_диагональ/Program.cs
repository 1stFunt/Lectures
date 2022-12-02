//Найти сумму по главной диагонали (0, 0); (1, 1) b и тд.
//Первый способ (лучший):
int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, columns];
int sum = 0;
FillMatrixRandomNumbers(numbers);
int minLength = numbers.GetLength(0);
if(numbers.GetLength(1) < minLength)
    minLength = numbers.GetLength(1);

for(int i = 0; i < minLength; i++)
{
    sum += numbers[i, i];
}
WriteMatrix(numbers);
Console.WriteLine(sum);

//Второй способ:
/*int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, columns];
int sum = 0;
FillMatrixRandomNumbers(numbers);
for(int i = 0; i < numbers.GetLength(0); i++)
{
    for(int j = 0; j < numbers.GetLength(1); j++)
    {
        if(i == j)
        {
            sum += numbers[i, j];
            break;
        }
    }
}
WriteMatrix(numbers);
Console.WriteLine(sum);*/

void WriteMatrix(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void FillMatrixRandomNumbers(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}