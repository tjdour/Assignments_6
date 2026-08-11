//Assignment 6.1.2: Linkedlist using built-in LinkedList class
//Explore Linkedlist class from C# library.
using Assignment_6._1._2;

LinkedList<House> houses = new LinkedList<House>();

AddHouse(123, "123 Main St", "Single Family");
AddHouse(456, "456 Oak St", "Condo");
AddHouse(789, "789 Pine St", "Townhouse");
AddHouse(101, "101 Maple St", "Duplex");

Console.Write("Enter a house number to search for: ");
int houseNumber = Convert.ToInt32(Console.ReadLine());

House? result = Search(houseNumber);

Console.WriteLine();

if (result != null)
{
    Console.WriteLine("House found:");
    Console.WriteLine($"House Number: {result.HouseNumber}");
    Console.WriteLine($"Address: {result.Address}");
    Console.WriteLine($"House Type: {result.HouseType}");
}
else
{
    Console.WriteLine("House not found.");
}


void AddHouse(int houseNumber, string address, string houseType)
{
    House newHouse = new House(houseNumber, address, houseType);

    houses.AddLast(newHouse);
}


House? Search(int houseNumber)
{
    foreach (House house in houses)
    {
        if (house.HouseNumber == houseNumber)
        {
            return house;
        }
    }

    return null;
}







