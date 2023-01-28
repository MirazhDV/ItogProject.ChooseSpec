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