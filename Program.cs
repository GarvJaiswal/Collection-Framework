using System;
using System.Collections.Generic;

class IntLinkedListCRUD
{
    private LinkedList<int> linkedList;

    public IntLinkedListCRUD()
    {
        linkedList = new LinkedList<int>();
    }

    public void Create(int value)
    {
        linkedList.AddLast(value);
    }

    public int Read()
    {
        if (linkedList.Count > 0)
            return linkedList.First.Value;
        else
        {
            Console.WriteLine("Linked list is empty.");
            return default(int); // Or return -1 or any default value you prefer
        }
    }

    public void Update(int newValue)
    {
        if (linkedList.Count > 0)
            linkedList.First.Value = newValue;
        else
            Console.WriteLine("Linked list is empty. Cannot update.");
    }

    public void Delete()
    {
        if (linkedList.Count > 0)
            linkedList.RemoveFirst();
        else
            Console.WriteLine("Linked list is empty. Cannot delete.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IntLinkedListCRUD myLinkedList = new IntLinkedListCRUD();

        // Create
        myLinkedList.Create(1);
        myLinkedList.Create(2);
        myLinkedList.Create(3);

        // Read
        Console.WriteLine("First value in the linked list: " + myLinkedList.Read());

        // Update
        myLinkedList.Update(4);
        Console.WriteLine("First value after update: " + myLinkedList.Read());

        // Delete
        myLinkedList.Delete();
        Console.WriteLine("First value after deletion: " + myLinkedList.Read());
    }
}
