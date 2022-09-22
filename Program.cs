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
//else if (exNum ==)