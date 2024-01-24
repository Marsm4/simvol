using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

        int enUpperCaseCount = 0;
        int enLowerCaseCount = 0;
        int ruUpperCaseCount = 0;
        int ruLowerCaseCount = 0;
        int digitsCount = 0;
        int otherCount = 0;

        foreach (char c in input)
        {
            if (Char.IsLetter(c))
            {
                if (Char.IsUpper(c))
                {
                    if ((c >= 'A' && c <= 'Z') || (c >= 'А' && c <= 'Я'))
                    {
                        enUpperCaseCount++;
                    }
                    else
                    {
                        ruUpperCaseCount++;
                    }
                }
                else
                {
                    if ((c >= 'a' && c <= 'z') || (c >= 'а' && c <= 'я'))
                    {
                        enLowerCaseCount++;
                    }
                    else
                    {
                        ruLowerCaseCount++;
                    }
                }
            }
            else if (Char.IsDigit(c))
            {
                digitsCount++;
            }
            else
            {
                otherCount++;
            }
        }

        Console.WriteLine("EnUpperCase: " + enUpperCaseCount);
        Console.WriteLine("EnLowerCase: " + enLowerCaseCount);
        Console.WriteLine("RuUpperCase: " + ruUpperCaseCount);
        Console.WriteLine("RuLowerCase: " + ruLowerCaseCount);
        Console.WriteLine("Digits: " + digitsCount);
        Console.WriteLine("Other: " + otherCount);
    }
}