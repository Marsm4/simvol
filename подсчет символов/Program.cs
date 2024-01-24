using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

        int enUpperCaseCount = 0;
        int enLowerCaseCount = 0;
        int digitsCount = 0;
        int otherCount = 0;

        foreach (char c in input)
        {
            if (Char.IsLetter(c))
            {
                if (Char.IsUpper(c))
                {
                    if ((c >= 'A' && c <= 'Z'))
                    {
                        enUpperCaseCount++;
                    }
                }
                else
                {
                    if ((c >= 'a' && c <= 'z') )
                    {
                        enLowerCaseCount++;
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
        Console.WriteLine("Digits: " + digitsCount);
        Console.WriteLine("Other: " + otherCount);
    }
}
