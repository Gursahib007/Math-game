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
        Random rnd = new Random();
        char choice = ' ';
        int number1 = 0;
        int number2 = 0;
        int result = 0;
        int answer = 0;
        int point = 0;
        

        List<Transaction> transactionHistory = new List<Transaction>();

        string text = "=-=-=-WELCOME TO MATH GAME 101-=-=-=";
        Console.Write(new string(' ', (Console.WindowWidth - text.Length) / 2));
        Console.WriteLine(text);

        text = "The calculator can perform Additions, Subtractions, Divisons and Multiplications, CAN YOU?";
        Console.Write(new string(' ', (Console.WindowWidth - text.Length) / 2));
        Console.WriteLine(text);

        Console.WriteLine("\n\nFor every correct answer you get 1 point, For wrong one you lose 1 point");

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

                number1 = rnd.Next(1, 100);
                number2 = rnd.Next(1, 100);
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
                    Console.WriteLine($"Perform operation on numbers {number1} and {number2}");
                    result = number1 + number2;
                    Thread.Sleep(250);
                    Console.Write("\n\nEnter answer :  ");
                    answer = Convert.ToInt32(Console.ReadLine());
                    Thread.Sleep(250);
         
                    if (result == answer)
                    {
                        Console.WriteLine("\n\nCorrecr Answer!");
                        point++;
                    }
                    else
                    {
                        Console.WriteLine($"\n\nWrong Answer, Correct answer is {result}");
                        point--;
                    }
                    break;

                case '-':
                    Console.WriteLine($"Perform operation on numbers {number1} and {number2}");
                    result = number1 - number2;
                    Thread.Sleep(250);
                    Console.Write("\n\nEnter answer :  ");
                    answer = Convert.ToInt32(Console.ReadLine());
                    Thread.Sleep(250);

                    if (result == answer)
                    {
                        Console.WriteLine("\n\nCorrecr Answer!");
                        point++;
                    }
                    else
                    {
                        Console.WriteLine($"\n\nWrong Answer, Correct answer is {result}");
                        point--;
                    }
                    break;

                case '*':
                    Console.WriteLine($"Perform operation on numbers {number1} and {number2}");
                    result = number1 * number2;
                    Thread.Sleep(250);
                    Console.Write("\n\nEnter answer :  ");
                    answer = Convert.ToInt32(Console.ReadLine());
                    Thread.Sleep(250);

                    if (result == answer)
                    {
                        Console.WriteLine("\n\nCorrecr Answer!");
                        point++;
                    }
                    else
                    {
                        Console.WriteLine($"\n\nWrong Answer, Correct answer is {result}");
                        point--;
                    }
                    break;

                case '/':

                    Console.WriteLine($"Perform operation on numbers {number1} and {number2}");
                    result = number1 + number2;
                    Thread.Sleep(250);
                    Console.Write("\n\nEnter answer :  ");
                    answer = Convert.ToInt32(Console.ReadLine());
                    Thread.Sleep(250);

                    if (result == answer)
                    {
                        Console.WriteLine("\n\nCorrecr Answer!");
                        point++;
                    }
                    else
                    {
                        Console.WriteLine($"\n\nWrong Answer, Correct answer is {result}");
                        point--;
                    }
                    break;

                case '0':
                    Console.WriteLine("Thanks for using the program");
                    break;

                default:
                    choice = 'e';
                    Console.WriteLine("Invalid Choice");
                    break;
            }

            // Store the transaction
            if (choice != '5' && choice != '0' && choice != 'e')
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
