//Assignment 6.1.1
//Implement a single linked list with each node representing a house.
//You may add data in it like house number, brief address, type of house ( like Ranch, Colonial).
//Each house (node) will be linked to next .
//Give facility to the user to search a house by its number and then display the details.

using Assignment_6._1;

HouseLinkedList houseList = new HouseLinkedList();
houseList.AddHouse(10, "123 Main St", "Single Family");
houseList.AddHouse(20, "456 Oak St", "Condo");
houseList.AddHouse(30, "789 Pine St", "Townhouse");
houseList.AddHouse(40, "101 Maple St", "Duplex");

Console.Write("Enter a house number to search for: ");

int houseNumber = Convert.ToInt32(Console.ReadLine());

ManualHouse result = houseList.Search(houseNumber);

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
