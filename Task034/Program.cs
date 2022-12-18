int getNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result) && (result > 0))
        {
            break;
        }
        else
        {
            Console.WriteLine($"Введено неверное число, повторить ввод");
        }
    }
    return result;
}

int[] getArray(int number)
{
Random rnd = new Random();
int[] array = new int[number];
for(int i = 0; i < number; i++)
{
array[i] = rnd.Next(100, 1000);
}
return array;
}

void showArray(int[] array)
{
    Console.Write($"[{array[0]}");
    if (array.Length > 1)
    {
        for (int i = 1; i < array.Length; i++)
        {
            Console.Write($", {array[i]}");
        }
    }
    Console.WriteLine("]");
}

void getEvenNumbers(int[] array)
{
int result = 0;
for(int i = 0; i < array.Length; i++)
{
if(array[i] % 2 == 0)
{
result++;
}
}
if(result % 10 == 1)
{
    Console.WriteLine($"{result} четное число.");
}
else if((result % 10 > 1) && (result % 10 < 5))
{
    Console.WriteLine($"{result} четных числа.");
}
else
{
    Console.WriteLine($"{result} четных чисел.");
}
}
int number = getNumber("Введите размер массива: ");
int[] array = getArray(number);
Console.Write("В массиве ");
showArray(array);
getEvenNumbers(array);