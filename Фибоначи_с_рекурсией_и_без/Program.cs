//Вывести первые N чисел Фибоначи.
//Вариант без рекурсии:
int count = ReadInt("Введите кол-во членов ряда Фибоначи: ");
int firstNumber = 0;
int secondNumber = 1;
if (count > 0)
    Console.Write(firstNumber + " ");
if (count > 1)
    Console.Write(secondNumber + " ");
for (int i = 2; i < count; i++)
{
    int nextNumber = firstNumber + secondNumber;
    firstNumber = secondNumber;
    secondNumber = nextNumber;
    Console.Write(nextNumber + " ");
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

//Вариант с массивом:
int count = ReadInt("Введите кол-во членов ряда Фибоначи: ");
int[] fibonacci = new int[count];
if (count > 0)
    fibonacci[0] = 0;
if (count > 1)
    fibonacci[1] = 1;
for (int i = 2; i < count; i++)
{
    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
}
Console.Write(String.Join(" ", fibonacci));
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

//Вариант с рекурсией!!!
double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
for (int i = 1; i < 40; i++)
{
    Console.Write(Fibonacci(i) + " ");
}