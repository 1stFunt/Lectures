// Напишите программу, которая задаёт массив из N элементов и выводит их на экран. Вывод сделать отдельным методом.
Console.WriteLine("Введите натуральное число (N): ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
void FillArray(int[] coll)
{
    int index = 0;
    while (index < coll.Length)
    {
        coll[index] = new Random().Next(1, 100);
        index++;
    }
}
void PrintArray(int[] coll)
{
    for (int index = 0; index < coll.Length; index++)
        continue;
    Console.Write(number + "->[" + String.Join(", ", array) + "]");
}
FillArray(array);
PrintArray(array);

// Второй пример. БЕЗ методов печати и рандома!
// Напишите программу, которая определяет, присутствует ли заданное число в массиве. Например: 4; массив [4, 5, 6, 7] -> Да
Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите искомое число: ");
int find = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[length];

string numberFound = "Нет"; //Если без этой строки, тогда через if, else if.
for (int i = 0; i < length; i++)
{
    numbers[i] = new Random().Next(0, 10);
    if (numbers[i] == find)
    {
        numberFound = "Да";
        break;
    }
}
Console.Write(find + "; массив [" + String.Join(", ", numbers) + "] -> " + numberFound);