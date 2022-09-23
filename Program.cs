﻿Console.WriteLine("Введите номер задачи");

int exNum = int.Parse(Console.ReadLine());

if (exNum == 19)
    {
    Console.WriteLine("Введите число");
    int num = Math.Abs(int.Parse(Console.ReadLine()));
    string str = num.ToString();
    char[] arr = str.ToCharArray();
    Array.Reverse(arr);
    string newStr = new string(arr); 
    if (str == newStr)
    {Console.WriteLine("Палиндром");}
    }
else if (exNum == 21)
{
    Console.WriteLine("Введите координаты точки А в формате 1,2,3");
    string[] arrA = Console.ReadLine().Split(',');
    double[] coordsA = new double[3];
    for (int _ = 0, i = 0; _ < arrA.Length; _++)
    {
        Console.WriteLine(arrA[_]);
        try
        {
            coordsA[i] = double.Parse(arrA[_], System.Globalization.CultureInfo.InvariantCulture);
            i++;
        }
        catch
        {
            continue;
        }
    }
    Console.WriteLine();
    Console.WriteLine("Введите координаты точки B в формате 1,2,3");
    string[] arrB = Console.ReadLine().Split(',');
    double[] coordsB = new double[3];
    for (int _ = 0, i = 0; _ < arrA.Length; _++)
    {
        Console.WriteLine(arrB[_]);
        try
        {
            coordsB[i] = double.Parse(arrB[_], System.Globalization.CultureInfo.InvariantCulture);
            i++;
        }
        catch
        {
            continue;
        }
    }
    double summ = 0;
    for (int _ = 0; _ < 3; _++)
    {
        summ += Math.Pow((coordsA[_] - coordsB[_]), 2);
    }
    Console.WriteLine();
    Console.WriteLine(Math.Sqrt(summ));
}