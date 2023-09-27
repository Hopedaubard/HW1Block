// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Main();

void Main()
{
    // int n = Int32.Parse(Console.ReadLine());
    string[] ints = new string[] { "Thomas", "Younger", "in", "da", "house", "GOD" };
    int count = 0;
    for (int i = 0; i < ints.Length; i++)
    {
        if (ints[i].Length <= 3)
        {
            count++;
        }
    }
    string s = "0";
    string[] intsFinal = new string[count];
    for (int i = 0; i < ints.Length; i++)
    {
        s = ints[i];
        for (int j = 0; j < ints.Length; j++)
        {
            if (ints[i].Length <= 3)
            {
                intsFinal[j] = s;
                break;
            }
        }
    }
    // for (int i = 0; i < ints.Length; i++)
    // {
    //     ints[i] = "0";
    // }
    // Console.WriteLine(ints.Join);
    foreach (string elem in ints)
    {
        Console.Write($"{elem} ");
    }
    Console.WriteLine(count);
    foreach (string elem in intsFinal)
    {
        Console.Write($"{elem} ");
    }
}