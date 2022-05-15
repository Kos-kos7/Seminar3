// Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N

Console.WriteLine("Введите целое число =>");
int n = int.Parse(Console.ReadLine());
for(int i = 1; i <= n; i++)
{
    if(i % 5 == 0){
        Console.WriteLine();
    }
    Console.Write(i * i + " ");
}
