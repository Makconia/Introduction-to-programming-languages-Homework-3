// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Не ограничился пятизначными числами, сделал универсально для чисел любой длины

System.Console.WriteLine("Введите число: ");
string x = Console.ReadLine();
int size = x.Length;
int i = 0;
int y = x.Length - 1;
int z = 0;
if (size < 2)
{
    System.Console.WriteLine("Число должно быть больше 9");
}
else
{
    while (i < size / 2)
    {
        if (x[i] == x[y])
        {
            i++;
            y = y - 1;
        }
        else
        {
            z++;
            i = size;
        }
    }
    string rez = z == 0 ? "Число является палиндромом" : "Число не является палиндромом";
    System.Console.WriteLine(rez);
}