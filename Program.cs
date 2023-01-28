//Написать программу, которая из имеющегося массива строк
//формирует массив из строк, длинной <= 3

int GetNumber(string message) //метод ввода числа в консоли
{
    int result;

    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число.");
        }
    }

    return result;
}

string[] InitArray(int dimention) //метод инициализации массива
{
    string[] array = new string[dimention];
    
    for (int i = 0; i < dimention; i++)
    {
        Console.Write($"Введите {i+1} значение массива: ");
        array[i] = Console.ReadLine()!;
    }

    return array;
}

void PrintArray(string[] array) //метод печати массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

