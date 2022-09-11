# nullable disable
/*
Console.WriteLine("Сколько чисел вы введёте?");
bool isNumber = int.TryParse(Console.ReadLine(), out int length);
if (!isNumber || length <= 0)
{
    Console.WriteLine("Ай-йа-яй!");
    return;
}

int[] UserArray(int length)
{
    int[] someNumbers = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"Введите число: ");
        string someString = Console.ReadLine();
        someNumbers[i] = Convert.ToInt32(someString);
        // bool isNumber = int.TryParse(Console.ReadLine(), out length);
        // if (!isNumber)
        // {
        //     Console.WriteLine("Буду делать а-та-та!");
        //     break;
        // } // unchecked condition:: не проверить
    }
    return someNumbers;
}
int MoreThenNull(int[] array)
{
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
int[] array = UserArray(length);
int inResult = MoreThenNull(array);
Console.WriteLine($"Положительных чисел: {inResult}");
*/
double[,] array = new double[2, 2];
Console.WriteLine("Введи первый коэффициент b1:");
bool isNumberB1 = double.TryParse(Console.ReadLine(), out double b1);
if (!isNumberB1)
{
    Console.WriteLine("Введите, пожалуйста, число");
    return;
}

array[0, 0] = b1;

Console.WriteLine("Введи второй коэффициент k1:");
bool isNumberK1 = double.TryParse(Console.ReadLine(), out double k1);
if (!isNumberK1)
{
    Console.WriteLine("Введите, пожалуйста, число");
    return;
}

array[0, 1] = k1;

Console.WriteLine("Введи третий коэффициент b2:");
bool isNumberB2 = double.TryParse(Console.ReadLine(), out double b2);
if (!isNumberB2)
{
    Console.WriteLine("Введите, пожалуйста, число");
    return;
}

array[1, 0] = b2;

Console.WriteLine("Введи последний коэффициент k2:");
bool isNumberK2 = double.TryParse(Console.ReadLine(), out double k2);
if (!isNumberB1)
{
    Console.WriteLine("Введите, пожалуйста, число");
    return;
}

array[1, 1] = k2;

// b1 == array[0,0]
// b2 == array[1,0]
// k1 == array[0,1]
// k2 == array[1,1]

double[] IntersectionPoint(double[,] array)
{
    double[] intersectionPoint = new double[2]; // x, y
    intersectionPoint[0]=(array[1,0] - array[0,0])/(array[0,1] - array[1,1]); // x == (b2 - b1)/(k1 - k2)
    intersectionPoint[1] = (array[0,0]*array[1,1] - array[1,0]*array[0,1])/(array[1,1] - array[0,1]); // y == (b1*k2 - b2*k1)/(k2- k1)
    return intersectionPoint;
}

if ((array[1,1] - array[0,1] == 0) && (array[1,0] - array[0,0] == 0))
{
    Console.WriteLine("Прямые либо параллельны, либо совпадают");
    return;
}
else
{
double[] intersectionPoint = IntersectionPoint(array);
Console.WriteLine($"x = {intersectionPoint[0]}, y = {intersectionPoint[1]}");
return;
}