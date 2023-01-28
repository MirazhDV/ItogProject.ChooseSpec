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

string[] NewArray(string[] array) //метод поиска чисел 
{
    int count = 0;
    int limit = 3;    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= limit)
        {
            count++;
        }              
    }    
    string[] newArray = new string[count];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (newArray.Length < 1)
        {
            Console.WriteLine($"Подходяших элементов ТЮ-ТЮ! В следующий раз попробуйте другой массив.");
            break;            
        }
        if (array[i].Length <= limit)
        {
            newArray[j]=array[i];
            j++;
        }
    }
    return newArray;
}

