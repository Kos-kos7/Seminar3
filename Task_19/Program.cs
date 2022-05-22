// Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.

Console.WriteLine("Введите целое пятизначное число =>");
int number = int.Parse(Console.ReadLine());

// 34543
if(number > 9999 && number < 100000)
{
int digit1 = number / 10000; //3
int digit2 = number / 1000 % 10; //4
int digit3 = number / 100 % 10; //5
int digit4 = number / 10 % 10; //4
int digit5 = number % 10; //3

string isPolyYesOut = $"Число {number} является полиндромом";
string isPolyNoOut = $"Число {number} является полиндромом";
Console.WriteLine(digit1 == digit5 && digit2 == digit4 ? isPolyYesOut : isPolyNoOut);
}




