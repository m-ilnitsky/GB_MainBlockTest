using System;
using System.Linq;

int ReadInt(string message, int minNumber = int.MinValue, int maxNumber = int.MaxValue)
{
    Console.Write(message);
    string line = Console.ReadLine();

    while (true)
    {
        if (int.TryParse(line, out int number))
        {
            if (minNumber <= number && number <= maxNumber)
            {
                return number;
            }

            Console.WriteLine($"Введите число в диапазоне от {minNumber} до {maxNumber}!");
            continue;
        }

        Console.WriteLine($"Введите коррекное целое число!");
    }
}

string ReadString(string message)
{
    Console.Write(message);
    return Console.ReadLine() ?? "";
}

string[] ReadStringsArray()
{
    int stringsCount = ReadInt("Введите количество строк массива: ", 0, 10);
    string[] strings = new string[stringsCount];

    for (int i = 0; i < stringsCount; i++)
    {
        strings[i] = ReadString($"Введите {i + 1}-ю строку массива: ");
    }

    return strings;
}

string[] GetStringsWithMaxLength(string[] strings, int maxStringLength)
{
    int resultStringsCount = 0;

    foreach (string str in strings)
    {
        if (str.Length <= maxStringLength)
        {
            resultStringsCount++;
        }
    }

    string[] resultStrings = new string[resultStringsCount];

    for (int i = 0, j = 0; i < strings.Length && j < resultStrings.Length; i++)
    {
        if (strings[i].Length <= maxStringLength)
        {
            resultStrings[j] = strings[i];
            j++;
        }
    }

    return resultStrings;
}

void WriteStringsArray(string[] strings)
{
    Console.Write($"[{string.Join(", ", strings.Select(s => $"\"{s}\""))}]");
}

void WriteStringsArrays(string[] sourceArray, string[] resultArray)
{
    WriteStringsArray(sourceArray);
    Console.Write(" => ");
    WriteStringsArray(resultArray);
    Console.WriteLine();
}

void ConvertAndWrite(string[] strings, int maxStringLength)
{
    WriteStringsArrays(strings, GetStringsWithMaxLength(strings, maxStringLength));
}

const int maxStringLength = 3;

string[] testStrings1 = { "Hello", "2", "world", ":-)" };
string[] testStrings2 = { "1234", "1567", "-2", "computer science" };
string[] testStrings3 = { "Russia", "Denmark", "Kazan" };

string[] userStrings = ReadStringsArray();

Console.WriteLine();
ConvertAndWrite(testStrings1, maxStringLength);
ConvertAndWrite(testStrings2, maxStringLength);
ConvertAndWrite(testStrings3, maxStringLength);
ConvertAndWrite(userStrings, maxStringLength);
Console.WriteLine();
