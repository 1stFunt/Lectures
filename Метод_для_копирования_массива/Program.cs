//Поэлементное копирование массива.

int size = ReadInt("Введите размер массива: ");
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
int[] copyNumbers = CopyArray(numbers);

PrintArray(numbers);
PrintArray(copyNumbers);

int[] CopyArray(int[] array) //Метод для копирования массива.
{
    int[] copyArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copyArray[i] = array[i];
    }
    return copyArray;
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 99);
    }
}
void PrintArray(int[] array)
{
    for (int index = 0; index < array.Length; index++)
        continue;
    Console.WriteLine("[" + String.Join(", ", array) + "]");
}