//Первый способ:
Console.WriteLine("Введите десятичное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string binaryNumber = ""; //пустая строка или string.Empty
int baseNumber = 2;
while (number > 0)
{
    int divider = number % baseNumber;
    binaryNumber = divider + binaryNumber;
    number /= baseNumber;
}
Console.WriteLine(binaryNumber);

//Второй способ:
Console.WriteLine("Введите десятичное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string binaryNumber = "";
int baseNumber = 2;
int tempNumber = number;
int count = 0;
while (tempNumber > 0)
{
    count++;
    tempNumber /= baseNumber;
}
int[] binary = new int[count];
for (int i = binary.Length - 1; i >= 0; i--)
{
    binary[i] = number % baseNumber;
    number /= baseNumber;
}
Console.WriteLine(String.Join("", binary));

//Мой способ:
int[] arr = { 1024, 512, 256, 128, 64, 32, 16, 8, 4, 2, 1, };
int[] newarr = new int[arr.Length];
Console.WriteLine("Введите число до 1023: ");
int number = Convert.ToInt32(Console.ReadLine());
int i2 = 1;
for (int i = 0; i < arr.Length-1; i++)
{
    if (number < arr[i] && number >= arr[i2])
    {
        number -= arr[i2];
        newarr[i2] = 1;
        i2++;
    }
    else i2++;
}
Console.WriteLine(String.Join("", newarr));