//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь (из Homework_6).
//Вариант с методом:
Console.Write("Введите числа через запятую: ");
int[] input = ParseArray(Console.ReadLine());
int positive = 0;
for (int i = 0; i < input.Length; i++)
{
    if (input[i] > 0) positive++;
}
int[] ParseArray(string inputNumbers) //метод парсинга
{
    int numbersCount = 1;
    for (int i = 0; i < inputNumbers.Length; i++)
    {
        if (inputNumbers[i] == ',')
            numbersCount++;
    }
    int[] numbers = new int[numbersCount];
    int numberIndex = 0;
    string temp = "";
    for (int i = 0; i < inputNumbers.Length; i++)
    {
        if (inputNumbers[i] == ',')
        {
            numbers[numberIndex++] = Convert.ToInt32(temp);
            temp = "";
        }
        else
        {
            temp += inputNumbers[i];
        }
    }
    numbers[numberIndex] = Convert.ToInt32(temp);
    return numbers;
}
Console.WriteLine(String.Join(",", input) + " -> " + positive);

//Мой вариант из домашки:
Console.Write("Введите целые числа через запятую: ");
string? numbers = (Console.ReadLine());
int count = 1;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == ',') count++;
}
int[] newNumbers = new int[count];
int index = 0;
for (int i = 0; i < numbers.Length; i++)
{
    string temp = "";
    while (numbers[i] != ',')
    {
        if (i != numbers.Length - 1)
        {
            temp += numbers[i++];
        }
        else
        {
            temp += numbers[i];
            break;
        }
    }
    newNumbers[index++] = Convert.ToInt32(temp);
}
int positive = 0;
for (int i = 0; i < newNumbers.Length; i++)
{
    if (newNumbers[i] > 0) positive++;
}
Console.WriteLine(String.Join(",", newNumbers) + " -> " + positive);