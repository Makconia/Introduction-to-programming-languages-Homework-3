// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

System.Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= N)
{
    if (i == N)
    {
        System.Console.Write(i * i * i);
        i++;
    }
    else
    {
        System.Console.Write(i * i * i + ", ");
        i++;
    }
}