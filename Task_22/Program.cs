// Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N

Console.WriteLine("Введите целое число =>");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("|{0,10}|{1,10}|", "Число", "Квадрат");
for(int i = 1; i <= n; i++)
{
    Console.WriteLine("|{0,10}|{1,10}|", i, i * i);
}
