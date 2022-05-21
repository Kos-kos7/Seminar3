// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите последовательно координаты x, y и z для точки А:");
int count;
double[] pointA = new double[3];
for(count = 0; count < 3; count++) {
    pointA[count] = Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine("Введите последовательно координаты x, y и z для точки В:");
double[] pointB = new double[3];
for(count = 0; count < 3; count++) {
    pointB[count] = Convert.ToDouble(Console.ReadLine());
}    

Console.WriteLine("Ваши точки: A (" + pointA[0] + "; " + pointA[1] + "; " + pointA[2] + "), B (" + pointB[0] + "; " + pointB[1] + "; " + pointB[2] + ") "); // вывод точек

double result;
double Distance(double[] pointA, double[] pointB)
{
    result = Math.Sqrt((pointB[0] - pointA[0]) * (pointB[0] - pointA[0])
     + (pointB[1] - pointA[1]) * (pointB[1] - pointA[1])
     + (pointB[2] - pointA[2]) * (pointB[2] - pointA[2]));  // метод Distance
    return result;
}

double dist = Distance(pointA, pointB);
Console.WriteLine("Расстояние между этими точками равно " + dist);  //вывод расстояния