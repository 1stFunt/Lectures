//Методы. Вид 1 (не принимает, не возвращает):
void Method1()
{
    Console.WriteLine("Автор...");
}
Method1();

//Вид 2 (принимает, не возвращает):
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Текст", 4);

//Вид 3 (не принимает, возвращает):
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

//Вид 4 (принимает, возвращает):
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "asdf");
Console.WriteLine(res);