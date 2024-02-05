using System;
using System.Collections.Generic;

class IntHashSetCRUD
{
    private HashSet<int> hashSet;

    public IntHashSetCRUD()
    {
        hashSet = new HashSet<int>();
    }

    public void Create(int item)
    {
        hashSet.Add(item);
    }

    public bool Read(int item)
    {
        return hashSet.Contains(item);
    }

    public bool Update(int currentItem, int newItem)
    {
        if (hashSet.Contains(currentItem))
        {
            hashSet.Remove(currentItem);
            hashSet.Add(newItem);
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool Delete(int item)
    {
        return hashSet.Remove(item);
    }
}

class Program
{
    static void Main(string[] args)
    {
        IntHashSetCRUD myHashSet = new IntHashSetCRUD();

        // Create
        myHashSet.Create(1);
        myHashSet.Create(2);
        myHashSet.Create(3);

        // Read
        Console.WriteLine("Does 2 exist in the HashSet? " + myHashSet.Read(2));

        // Update
        bool updated = myHashSet.Update(2, 4);
        if (updated)
            Console.WriteLine("Updated 2 to 4");
        else
            Console.WriteLine("Failed to update");

        // Delete
        bool deleted = myHashSet.Delete(2);
        if (deleted)
            Console.WriteLine("Deleted 2 from HashSet");
        else
            Console.WriteLine("Failed to delete");
    }
}
