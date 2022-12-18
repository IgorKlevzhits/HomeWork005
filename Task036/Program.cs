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
    for (int i = 0; i < number; i++)
    {
        array[i] = rnd.Next(-1000, 1000);
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

int getSumOddNumbers(bool programmist, int[] array)
{
    int result = 0;
    int k;
    if(programmist)
        k = 1;
    else
        k = 0;
    for (int i = k; i < array.Length; i += 2)
    {
        result += array[i];
    }
    return result;
}
int number = getNumber("Введите размер массива: ");
int[] array = getArray(number);
showArray(array);
Console.WriteLine($"Сумма чисел на нечетных позициях, с точки зрения программиста, равна - {getSumOddNumbers(true, array)}");
Console.WriteLine($"Сумма чисел на нечетных позициях, с точки зрения обывателя, равна - {getSumOddNumbers(false, array)}");