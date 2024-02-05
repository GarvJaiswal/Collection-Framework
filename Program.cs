using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a new list
        List<string> myList = new List<string>();

        // Add some initial items
        myList.Add("Item 1");
        myList.Add("Item 2");
        myList.Add("Item 3");

        // Read (Retrieve) items
        Console.WriteLine("Items in the list:");
        foreach (var item in myList)
        {
            Console.WriteLine(item);
        }

        // Update an item
        int indexToUpdate = 1;
        if (indexToUpdate >= 0 && indexToUpdate < myList.Count)
        {
            myList[indexToUpdate] = "Updated Item";
            Console.WriteLine($"Item at index {indexToUpdate} has been updated.");
        }
        else
        {
            Console.WriteLine("Invalid index for update.");
        }

        // Delete an item
        int indexToDelete = 0;
        if (indexToDelete >= 0 && indexToDelete < myList.Count)
        {
            myList.RemoveAt(indexToDelete);
            Console.WriteLine($"Item at index {indexToDelete} has been deleted.");
        }
        else
        {
            Console.WriteLine("Invalid index for deletion.");
        }

        // Read (Retrieve) items after deletion
        Console.WriteLine("Items in the list after deletion:");
        foreach (var item in myList)
        {
            Console.WriteLine(item);
        }

        // Add a new item
        myList.Add("New Item");
        Console.WriteLine("New item added to the list.");

        // Read (Retrieve) items after addition
        Console.WriteLine("Items in the list after addition:");
        foreach (var item in myList)
        {
            Console.WriteLine(item);
        }
    }
}
