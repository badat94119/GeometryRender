using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;
            while (choice != 0)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Draw the triangle");
                Console.WriteLine("2. Draw the square");
                Console.WriteLine("3. Draw the rectangle");
                Console.WriteLine("4. Draw the upside-down triangle");
                Console.WriteLine("5. Draw the isosceles triangle");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Draw the triangle");
                        Console.WriteLine("Enter the height of the triangle: ");
                        int triangleHeight = Int32.Parse(Console.ReadLine());
                        for (int i = triangleHeight - 1; i >= 0; i--)
                        {
                            for (int j = 0; j <= i; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 2:
                        Console.WriteLine("Draw the square");
                        Console.WriteLine("Enter the length of a side: ");
                        int squareLength = Int32.Parse(Console.ReadLine());
                        for (int i = 0; i < squareLength; i++)
                        {
                            for (int j = 0; j < squareLength; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Draw the rectangle");
                        Console.WriteLine("Enter the length of a side: ");
                        int rectLength = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the length of another side: ");
                        int rectWidth = Int32.Parse(Console.ReadLine());
                        for (int i = 0; i < rectWidth; i++)
                        {
                            for (int j = 0; j < rectLength; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 4:
                        Console.WriteLine("Draw the upside-down triangle");
                        Console.WriteLine("Enter the height of the triangle: ");
                        int upsideDownTriangleHeight = Int32.Parse(Console.ReadLine());
                        for (int i = 1; i <= upsideDownTriangleHeight; i++)
                        {
                            for (int j = 1; j < i; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 5:
                        Console.WriteLine("Draw the isosceles triangle");
                        Console.Write("Enter the height of the triangle: ");
                        int height = int.Parse(Console.ReadLine());

                        for (int i = 1; i <= height; i++)
                        {
                            for (int j = 1; j <= height - i; j++)
                            {
                                Console.Write(" ");
                            }
                            for (int k = 1; k <= 2 * i - 1; k++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine(); 
                        }
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }
            }
        }
    }
}