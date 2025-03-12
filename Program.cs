using System;

class Program
{
    static void Main()
    {
        int a, b, c;

        try
        {
            Console.WriteLine("Podaj pierwszą liczbę naturalną:");
            a = ReadNaturalNumber();

            Console.WriteLine("Podaj drugą liczbę naturalną:");
            b = ReadNaturalNumber();

            Console.WriteLine("Podaj trzecią liczbę naturalną:");
            c = ReadNaturalNumber();
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }

        // Uporządkowanie liczb od najmniejszej do największej
        int[] numbers = { a, b, c };
        Array.Sort(numbers);
        a = numbers[0];
        b = numbers[1];
        c = numbers[2];

        // Sprawdzenie, czy a^2 + b^2 = c^2
        if (IsPythagoreanTriple(a, b, c))
        {
            Console.WriteLine($"Liczby {a}, {b} i {c} tworzą trójkę pitagorejską.");
        }
        else
        {
            Console.WriteLine($"Liczby {a}, {b} i {c} nie tworzą trójki pitagorejskiej.");
        }
    }

    static int ReadNaturalNumber()
    {
        string input = Console.ReadLine();
        if (int.TryParse(input, out int number) && number > 0)
        {
            return number;
        }
        else
        {
            throw new FormatException("Wprowadzono niepoprawną liczbę. Musisz podać liczbę naturalną większą od zera.");
        }
    }

    static bool IsPythagoreanTriple(int a, int b, int c)
    {
        return a * a + b * b == c * c;
    }
}
