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

double[] getArray(int number)
{
Random rnd = new Random();
double[] array = new double[number];
for(int i = 0; i < number; i++)
{
array[i] = rnd.NextDouble() * 100;
}
return array;
}

void showArray(double[] array)
{
Console.Write($"[{Math.Round(array[0], 2)}");
if(array.Length > 1)
{
for(int i = 1; i < array.Length; i++)
{
Console.Write($"; {Math.Round(array[i], 2)}");
}
}
Console.WriteLine("]");
}

double differenceMinMax(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(min > array[i])
            min = array[i];
        if(max < array[i])
            max = array[i];
    }
    return max - min;
}


int number = getNumber("Введите размер массива: ");
double[] array = getArray(number);
Console.Write("Ваш массив - ");
showArray(array);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна - {Math.Round(differenceMinMax(array), 2)}");