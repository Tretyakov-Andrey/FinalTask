//  Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
//  меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
//  выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
//  исключительно массивами.

string[] GetNumbers(int size)
{
    System.Console.WriteLine("Ishodniy massiv: ");
    string[] numbers = new string[size];
    for (int i = 0; i < size; i++)
    {
        numbers[i] = Convert.ToString(new Random().Next(1, 10000));
        System.Console.Write($"{numbers[i],8}");
    }
    return numbers;
}

string[] Result(string[] numbers)
{
    System.Console.WriteLine();
    System.Console.WriteLine("Result: ");
    int count = 0;
    for (int j = 0; j < numbers.Length; j++)
    {
        count = 0;

        for (int n = 0; n < numbers[j].Length; n++)
        {
            count++;
        }
        if (count < 4) System.Console.Write($"{numbers[j],8}");
    }
    return numbers;
}

Result(GetNumbers(10));