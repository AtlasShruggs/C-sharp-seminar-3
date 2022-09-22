Console.WriteLine("Введите номер задачи");

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
    float[] coordsA = new float[3];
    for (int _ = 0, i = 0; _ < arrA.Length; _++)
    {
        Console.WriteLine(arrA[_]);
        try
        {
            coordsA[i] = float.Parse(arrA[_]);
            i++;
        }
        catch
        {
            continue;
        }
    }
    Console.WriteLine(coordsA[0] + coordsA[1] + coordsA[2]);
}