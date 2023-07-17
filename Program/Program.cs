using System;
using System.Linq;

string[] GetStringsWithMaxLength(string[] strings, int maxLength)
{
    int resultStringsCount = 0;

    foreach (string str in strings)
    {
        if (str.Length <= maxLength)
        {
            resultStringsCount++;
        }
    }

    string[] resultStrings = new string[resultStringsCount];

    for (int i = 0, j = 0; i < strings.Length && j < resultStrings.Length; i++)
    {
        if (strings[i].Length <= maxLength)
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

void WriteArrays(string[] sourceArray, string[] resultArray)
{
    WriteStringsArray(sourceArray);
    Console.Write(" => ");
    WriteStringsArray(resultArray);
    Console.WriteLine();
}

const int maxStringLength = 3;

string[] testStrings1 = { "Hello", "2", "world", ":-)" };
string[] testStrings2 = { "1234", "1567", "-2", "computer science" };
string[] testStrings3 = { "Russia", "Denmark", "Kazan" };

string[] resultStrings1 = GetStringsWithMaxLength(testStrings1, maxStringLength);
string[] resultStrings2 = GetStringsWithMaxLength(testStrings2, maxStringLength);
string[] resultStrings3 = GetStringsWithMaxLength(testStrings3, maxStringLength);

WriteArrays(testStrings1, resultStrings1);
WriteArrays(testStrings2, resultStrings2);
WriteArrays(testStrings3, resultStrings3);
Console.WriteLine();
