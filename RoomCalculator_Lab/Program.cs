// calculate area of a classroom


Console.WriteLine("What is the length of your room?");
double roomLength = double.Parse(Console.ReadLine());


Console.WriteLine("What is the width of your room?");
double roomWidth = double.Parse(Console.ReadLine());


Console.WriteLine("What is the height of your room?");
double roomHeight = double.Parse(Console.ReadLine());


double roomArea = roomLength * roomWidth;

    Console.WriteLine($"Your room is {roomArea}");

double roomPerimeter = (roomLength * 2) + (roomWidth * 2);

    Console.WriteLine($"You room perimeter is {roomPerimeter}");


double roomVolume = roomLength * roomWidth * roomHeight;

    Console.WriteLine($"The volume of your room is {roomVolume}");


double wallAreaLength = roomLength * roomHeight;
double wallAreaWidth = roomWidth * roomHeight;
double roomSurfaceArea = (roomArea * 2) + (wallAreaWidth * 2) + (wallAreaLength * 2);

    Console.WriteLine($"The total surface area of your walls, floor and ceiling is {roomSurfaceArea}");


if(roomArea <= 250)
{
    Console.WriteLine("Wow that is a really small room.");
}
else if(roomArea < 650)
{
    Console.WriteLine("That is a medium sized room.");
}
else if(roomArea >= 650)
{
    Console.WriteLine("That room is huge.");
}
