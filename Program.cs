//  Контрольная работа по курсу "Введение в языки программирования"
/*  Задача: Написать программу, которая из имеющегося массива строк сформирует массив из строк,
    длина которых меньше, либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
    либо задать на старте выполнения алгоритма.*/

string[] EnterArray()
{
    Console.WriteLine("Нажмите 'Пробел' если хотите ввести массив строк с клавиатуры, либо любую клавишу, чтобы оставить массив по умолчанию.");
    if (Console.ReadKey().Key == ConsoleKey.Spacebar) 
    {
        Console.WriteLine();
        Console.WriteLine("Введите строки через пробел:");
        string [] keyEnterArray = Console.ReadLine().Split();
        return keyEnterArray;
    }
    else 
    {
        string[] defaultArray = {"Git", "это", "одна", "из", "реализаций", "распределённых", "систем", "контроля", "версий", "имеющая", "как", "и", "локальные", "так", "и", "удалённые", "репозитории", "Является", "самой", "популярной", "реализацией", "систем", "контроля", "версий", "в", "мире"};
        return defaultArray;
    }
}
string[] AddElementToResultArray(string element, string[] array)
{
    string[] newArray = new string[array.Length + 1];
    newArray[array.Length] = element;
    for (int i = 0; i < array.Length; i++)
        newArray[i] = array[i];

    return newArray;
}
string Print(string[] array)
{
    string result = String.Empty;
    for (int i = 0; i < array.Length -1; i++)
    {
        result += $"{array[i]}, ";
    }
    result += $"{array[array.Length-1]}.";
    return result;
}

Console.Clear();
string[] array = EnterArray();
string[] resultArray = {};

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) resultArray = AddElementToResultArray(array[i], resultArray);
}

if (resultArray.Length == 0) Console.WriteLine("В исходном массиве нет строк, длина которых меньше, либо равна 3 символа.");
else 
{
    Console.WriteLine($"В результирующем массиве {resultArray.Length} элементов.");
    Console.WriteLine("Желаете вывести результат на экран? Y/N");
    if (Console.ReadKey().Key == ConsoleKey.Y) 
    {
        Console.WriteLine();
        Console.WriteLine(Print(resultArray));
    }
}
