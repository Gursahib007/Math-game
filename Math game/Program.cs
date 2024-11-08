using System;
using System.Collections.Generic;
using System.Threading;

public class Transaction
{
    public int Number1 { get; set; }
    public int Number2 { get; set; }
    public char Operation { get; set; }
    public int Result { get; set; }

    public Transaction(int number1, int number2, char operation, int result)
    {
        Number1 = number1;
        Number2 = number2;
        Operation = operation;
        Result = result;
    }

    // Override ToString to display the transaction in a readable format
    public override string ToString()
    {
        return $"{Number1} {Operation} {Number2} = {Result}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        char choice = ' ';
        int number1 = 0;
        int number2 = 0;
        int result = 0;

        List<Transaction> transactionHistory = new List<Transaction>();

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
     |       5. View History   |  // New Option
     |       0. Exit           |
     ===========================");
            Console.Write("\n\nEnter your choice in the form on equivalent character [+], [-], [*], [/], [5 for history], [0 for exit] : ");

            choice = Convert.ToChar(Console.ReadLine());

            if (choice == '5')
            {
                Console.Clear();
                Console.WriteLine("Transaction History:");
                foreach (var transaction in transactionHistory)
                {
                    Console.WriteLine(transaction);
                }
                Console.WriteLine("\n\nPress Enter key to continue");
                Console.ReadLine();
                Console.Clear();
                continue; // Skip the rest of the loop for history viewing
            }

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
                    if (number2 != 0)
                    {
                        result = number1 / number2;
                        Thread.Sleep(250);
                        Console.WriteLine($"\n\nQuotient of number1 (\"{number1}\") and number2 (\"{number2}\") = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
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

            // Store the transaction
            if (choice != '5' && choice != '0')
            {
                Transaction newTransaction = new Transaction(number1, number2, choice, result);
                transactionHistory.Add(newTransaction);
            }

            Console.WriteLine("\n\n\nPress Enter key to continue");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
