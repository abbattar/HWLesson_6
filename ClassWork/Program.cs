# nullable disable
/*
Console.WriteLine("Введите длину первой стороны треугольника:");
bool isNumberSide1 = double.TryParse(Console.ReadLine(), out double side1);
Console.WriteLine("Введите длину первой стороны треугольника:");
bool isNumberSide2 = double.TryParse(Console.ReadLine(), out double side2);
Console.WriteLine("Введите длину первой стороны треугольника:");
bool isNumberSide3 = double.TryParse(Console.ReadLine(), out double side3);
if (!isNumberSide1 || side1 <= 0)
{
    Console.WriteLine("Не надо так!");
    return;
}
if (!isNumberSide2 || side2 <= 0)
{
    Console.WriteLine("Не надо так!");
    return;
}
if (!isNumberSide3 || side3 <= 0)
{
    Console.WriteLine("Не надо так!");
    return;
}

void ChekTriangleSides(double side1, double side2, double side3)
{
    Boolean[] value = new Boolean[3];
    value[0] = (side3 >= side1 + side2);
    value[1] = (side2 >= side1 + side3);
    value[2] = (side1 >= side2 + side3);
    if (value[0] || value[1] || value[2])
    {
        Console.WriteLine("Нет, такого треугольника не существует");
    }
    else Console.WriteLine("Да, такой треугольник существует");
}
ChekTriangleSides(side1, side2, side3);
*/
// Задача 42
/*
Console.WriteLine("Введите положительное десятичное число:");
bool isNumberDex = int.TryParse(Console.ReadLine(), out int dex);
if (!isNumberDex || dex < 0)
{
    Console.WriteLine("Не надо так!");
    return;
}
string TransfomationDecimalNumberToBinary(int dex)
{
    string someBytes = "";
    while (dex > 0)
    {
        int divisionDec = dex % 2;
        someBytes = Convert.ToString(divisionDec) + someBytes;
        dex = dex / 2;
    }
    return someBytes;
}
Console.WriteLine(TransfomationDecimalNumberToBinary(dex));
*/
// Задача 44
/*
Console.WriteLine("Введите положительное целое число:");
bool isNumber = int.TryParse(Console.ReadLine(), out int number);
if (!isNumber || number < 0)
{
    Console.WriteLine("Не пиши так!"); return;
}
void PrintArray(long[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"F({i}) = {array[i]}");
    }
}
void Fibonacci(int number)
{
    long[] fibo = new long[number];
    fibo[0] = 0;
    fibo[1] = 1;
    for (int i = 2; i < number; i++)
    {
        fibo[i] = fibo[i - 1] + fibo[i - 2];
    }
    PrintArray(fibo);
}
Fibonacci(number + 1);
*/

Console.WriteLine("Введите длину массива:");
bool isNumber = int.TryParse(Console.ReadLine(), out int length);
if (!isNumber || length <= 0) 
{
    Console.WriteLine("Ты что такой то?"); 
    return;
}

int[] FillArray(int length)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++) array[i] = random.Next(-99, 100);
    return array;
}

int[] NewArray(int[] array)
{
    int[] copyArray = new int[array.Length];
    for (int i = 0; i < length; i++)
    {
        copyArray[i]=array[i];
    }
    return copyArray;
}
void PrintArray(int[] array)
{
    if (array.Length == 0)
    {
        Console.WriteLine("Что то пошло не так!");
        return;
    }
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    } 
    Console.Write(array[array.Length - 1]);
    Console.WriteLine("]");
}
int[] trueArray = FillArray(length);
PrintArray(trueArray);

PrintArray(NewArray(trueArray));