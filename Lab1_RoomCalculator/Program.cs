using System;
using System.Threading;

namespace Lab1_RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool calculatingRooms = true;
            bool wannaRestart;
            string userInput;
            string userLength;
            string userWidth;
            double area;
            double perimeter;
            double roomWidth;
            double roomLength;
            double surfaceArea;
            double volume;
            double roomHeight;
            string userHeight;

            Console.WriteLine("Welcome to the Room Measurement Caluclator!");
            Console.WriteLine("");

            while (calculatingRooms == true)
            {
                wannaRestart = true;
                try
                {
                    Console.WriteLine("First, let's calculate the room's area and perimeter.");
                    Console.WriteLine("");
                    Console.Write("Enter the length of the room in feet: ");
                    userLength = Console.ReadLine();
                    roomLength = double.Parse(userLength);
                    Console.WriteLine("");
                    Console.Write("Enter the width of the room in feet: ");
                    userWidth = Console.ReadLine();
                    roomWidth = double.Parse(userWidth);
                    Console.WriteLine("");

                    area = CalculateArea(roomWidth, roomLength);

                    perimeter = CalculatePerimeter(roomWidth, roomLength);

                    Console.WriteLine(string.Format("{0,5}{1,20}", ">", $"The room area is {area} square feet."));
                    Console.WriteLine(string.Format("{0,5}{1,20}", ">", $"The room perimeter is {perimeter} square feet."));
                    if (area > 650)
                    {
                        Console.WriteLine(string.Format("{0,5}{1,20}", ">", "Based on our caluclations, this appears to be a large room."));
                        Console.WriteLine("");
                    }
                    else if (area <= 650 && area > 250)
                    {
                        Console.WriteLine(string.Format("{0,5}{1,20}", ">",
                        "Based on our caluclations, this appears to be a medium-sized room."));
                        Console.WriteLine("");
                    }
                    else if (area <= 250)
                    {
                        Console.WriteLine(string.Format("{0,5}{1,20}", ">", "Based on our calculations, this appears to be a small room."));
                        Console.WriteLine("");
                    }
                    Console.WriteLine("Next, let's calculate the room's volume and surface area.");
                    Console.WriteLine("");
                    Console.Write("Enter the height of the room in feet: ");
                    userHeight = Console.ReadLine();
                    roomHeight = double.Parse(userHeight);
                    Console.WriteLine("");

                    volume = CalculateVolume(roomWidth, roomLength, roomHeight);

                    surfaceArea = CalculateSurfaceArea(roomWidth, roomLength, roomHeight);

                    Console.WriteLine(string.Format("{0,5}{1,20}", ">", $"The room volume is {volume} square feet."));
                    Console.WriteLine(string.Format("{0,5}{1,20}", ">", $"The room surface area is {surfaceArea} square feet."));
                    Console.WriteLine("");
                }
                catch
                {
                    Console.WriteLine("Oooop - something went wrong there. Let's try again.");
                    Console.WriteLine("");
                    wannaRestart = false;
                    calculatingRooms = true;
                }

                while (wannaRestart == true)
                {
                    Console.WriteLine("Would you like to calculate the meausurement details of another room?");
                    userInput = Console.ReadLine().ToLower();

                    if (userInput == "y" || userInput == "yes")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("More room calculations coming your way!");
                        Thread.Sleep(2500);
                        Console.Clear();
                        calculatingRooms = true;
                        wannaRestart = false;
                    }
                    else if (userInput == "n" || userInput == "no")
                    {
                        calculatingRooms = false;
                        wannaRestart = false;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Sorry, I didn't understand that response. Please try again.");
                        Console.WriteLine("");
                        wannaRestart = true;
                    }
                }
            }
            Console.WriteLine("Thank you for using the room calculator!");
            Console.WriteLine("Goodbye!");
        }
        static double CalculateArea(double roomWidth, double roomLength)
        {
            //area = L*W
            return (roomWidth * roomLength);
        }
        static double CalculatePerimeter(double roomWidth, double roomLength)
        {
            //Perimeter = (W*2) + (L*2)
            return ((roomWidth * 2) + (roomLength * 2))
;        }
        static double CalculateVolume(double roomWidth, double roomLength, double roomHeight)
        {
            //Volume = W*L*H
            return (roomWidth * roomLength * roomHeight);
        }
        static double CalculateSurfaceArea(double roomWidth, double roomLength, double roomHeight)
        {
            //Surface Area = 2*(L*H) + 2*(W*H) + 2*(L*W)
            return ((2 * (roomHeight)) + (2 * (roomLength)) + (2 * (roomWidth)));
;
        }
    }
}
