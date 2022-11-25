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
    int index = 0;
    while (index < coll.Length - 1)
    {
        Console.Write(String.Join(", ", coll[index],""));
        index++;
    }
}
FillArray(array);
PrintArray(array);