//Assignment 6.1.1
//Implement a single linked list with each node representing a house.
//You may add data in it like house number, brief address, type of house ( like Ranch, Colonial).
//Each house (node) will be linked to next .
//Give facility to the user to search a house by its number and then display the details.

using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_6._1
{
    internal class ManualHouse
    {
        public int HouseNumber;
        public string Address;
        public string HouseType;

        public ManualHouse Next;

        public ManualHouse(int houseNumber, string address, string houseType)
        {
            HouseNumber = houseNumber;
            Address = address;
            HouseType = houseType;
            Next = null;
        }
    }

    internal class HouseLinkedList
    {
        public ManualHouse Head;

        
        public void AddHouse(int houseNumber, string address, string houseType)
        {
            ManualHouse newHouse = new ManualHouse(houseNumber, address, houseType);

            
            if (Head == null)
            {
                Head = newHouse;
                return;
            }

            
            ManualHouse current = Head;

            
            while (current.Next != null)
            {
                current = current.Next;
            }

            
            current.Next = newHouse;
        }

        // Search for a house by house number
        public ManualHouse? Search(int houseNumber)
        {
            ManualHouse? current = Head;

            
            while (current != null)
            {
                if (current.HouseNumber == houseNumber)
                {
                    return current;
                }

                current = current.Next;
            }

            
            return null;
        }

        
    }
}