using System;
using System.Runtime.CompilerServices;

char choice = ' ';
int number1 = 0;
int number2 = 0;
int result = 0;

string text = "=-=-=-WELCOME TO CALCULATOR 101-=-=-=";
Console.Write(new string(' ', (Console.WindowWidth - text.Length) / 2));
Console.WriteLine(text);

text = "The calculator can perform Additions, Subtractions, Divisons and Multiplications";
Console.Write(new string(' ', (Console.WindowWidth - text.Length) / 2));
Console.WriteLine(text);

Console.WriteLine("\n\n\nPress Enter key to continue");
Console.ReadLine();

Console.WriteLine("\n\n\n\n");

text = "Loading";
Console.Write(new string(' ', (Console.WindowWidth - text.Length) / 2));
Console.Write(text);

for (int i = 0; i < 3; i++)
{
    Console.Write(" . ");
    Thread.Sleep(500);
}

Console.Clear();

while (!choice.Equals('0'))
{
    Console.WriteLine(@"         Choose an Operation:
     ===========================
     |       1. Addition       |
     |       2. Subtraction    |
     |       3. Multiplication |
     |       4. Division       |
     |       5. Exit           |
     ===========================");
    Console.Write("\n\nEnter your choice in the form on equivalent character [+], [-], [*], [/], [0 for exit] : ");

    choice = Convert.ToChar(Console.ReadLine());

    if (!choice.Equals('0'))
    {

        Console.Write("\n\n\nLoading");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(" . ");
            Thread.Sleep(250);
        }
        Console.Clear();

        Console.Write("Enter number 1 to perform operation on :  ");
        number1 = Convert.ToInt32(Console.ReadLine());
        Thread.Sleep(250);
        Console.WriteLine($"Entered Number 1: {number1}");

        Console.Write("\n\nEnter number 2 to perform operation on :  ");
        number2 = Convert.ToInt32(Console.ReadLine());
        Thread.Sleep(250);
        Console.WriteLine($"Entered Number 2: {number2}");
    }

    else
    {
        Console.Write("\n\n\nLoading");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(" . ");
            Thread.Sleep(175);
        }
        Console.Clear();
    }



    switch (choice)
    {
        case '+':
            result = number1 + number2;
            Thread.Sleep(250);
            Console.WriteLine($"\n\nSum of number1 (\"{number1}\") and number2 (\"{number2}\") = {result}");
            break;

        case '-':
            result = number1 - number2;
            Thread.Sleep(250);
            Console.WriteLine($"\n\nDifference of number1 (\"{number1}\") and number2 (\"{number2}\") = {result}");
            break;

        case '*':
            result = number1 * number2;
            Thread.Sleep(250);
            Console.WriteLine($"\n\nProduct of number1 (\"{number1}\") and number2 (\"{number2}\") = {result}");
            break;

        case '/':
            if ((double)number1 / (double)number2 == 0)
            {
                result = number1 / number2;
                Thread.Sleep(250);
                Console.WriteLine($"\n\nQuotient of number1 (\"{number1}\") and number2 (\"{number2}\") = {result}");
            }

            else
            {
                Console.WriteLine("Divison dosen't result in an integer");
                continue;
            }
            break;

        case '0':
            Console.WriteLine("Thanks for using the program");
            break;

        default:
            Console.WriteLine("Invalid Choice");
            break;

    }
    Console.WriteLine("\n\n\nPress Enter key to continue");
    Console.ReadLine();
    Console.Clear();

}
