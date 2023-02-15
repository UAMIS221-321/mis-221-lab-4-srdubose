using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        while (choice != 3)
        {
            Console.WriteLine("Enter 1 to display full triangle");
            Console.WriteLine("Enter 2 to display partial triangle");
            Console.WriteLine("Enter 3 to exit");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        DrawTriangle(true);
                        break;
                    case 2:
                        DrawTriangle(false);
                        break;
                    case 3:
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
            }
        }
    }

    static void DrawTriangle(bool fullTriangle)
    {
        int numRows = new Random().Next(3, 10);
        bool[][] triangle = new bool[numRows][];
        for (int i = 0; i < numRows; i++)
        {
            triangle[i] = new bool[i + 1];
            for (int j = 0; j <= i; j++)
            {
                triangle[i][j] = (new Random().Next(0, 2) == 1);
            }
        }

        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < (numRows - i - 1); j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j <= i; j++)
            {
                if (fullTriangle || triangle[i][j])
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
    }
}


