using System;
using System.Collections.Generic;

class IntDictionaryCRUD
{
    private Dictionary<int, int> dictionary;

    public IntDictionaryCRUD()
    {
        dictionary = new Dictionary<int, int>();
    }

    public void Create(int key, int value)
    {
        if (!dictionary.ContainsKey(key))
            dictionary.Add(key, value);
        else
            Console.WriteLine("Key already exists. Cannot add.");
    }

    public int Read(int key)
    {
        int value;
        if (dictionary.TryGetValue(key, out value))
            return value;
        else
            Console.WriteLine("Key does not exist.");
        return -1; // Or return default(int);
    }

    public void Update(int key, int newValue)
    {
        if (dictionary.ContainsKey(key))
            dictionary[key] = newValue;
        else
            Console.WriteLine("Key does not exist. Cannot update.");
    }

    public void Delete(int key)
    {
        if (dictionary.ContainsKey(key))
            dictionary.Remove(key);
        else
            Console.WriteLine("Key does not exist. Cannot delete.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IntDictionaryCRUD myDictionary = new IntDictionaryCRUD();

        // Create
        myDictionary.Create(1, 10);
        myDictionary.Create(2, 20);
        myDictionary.Create(3, 30);

        // Read
        Console.WriteLine("Value for key 1: " + myDictionary.Read(1));
        Console.WriteLine("Value for key 4: " + myDictionary.Read(4)); // Key does not exist.

        // Update
        myDictionary.Update(2, 25);
        Console.WriteLine("Updated value for key 2: " + myDictionary.Read(2));

        // Delete
        myDictionary.Delete(3);
        Console.WriteLine("Value for key 3 after deletion: " + myDictionary.Read(3)); // Key does not exist.
    }
}
