using System;
using System.Collections.Generic;

class IntQueueCRUD
{
    private Queue<int> queue;

    public IntQueueCRUD()
    {
        queue = new Queue<int>();
    }

    public void Create(int item)
    {
        queue.Enqueue(item);
    }

    public int Read()
    {
        if (queue.Count > 0)
            return queue.Peek();
        else
            throw new InvalidOperationException("Queue is empty");
    }

    public void Update(int newItem)
    {
        if (queue.Count > 0)
        {
            // Dequeue and enqueue the updated item
            int currentFront = queue.Dequeue();
            queue.Enqueue(newItem);
        }
        else
        {
            throw new InvalidOperationException("Queue is empty");
        }
    }

    public int Delete()
    {
        if (queue.Count > 0)
            return queue.Dequeue();
        else
            throw new InvalidOperationException("Queue is empty");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IntQueueCRUD myQueue = new IntQueueCRUD();

        // Create
        myQueue.Create(1);
        myQueue.Create(2);
        myQueue.Create(3);

        // Read
        Console.WriteLine("Front item in the queue: " + myQueue.Read());

        // Update
        myQueue.Update(4);
        Console.WriteLine("Front item after update: " + myQueue.Read());

        // Delete
        Console.WriteLine("Deleted item from the queue: " + myQueue.Delete());
        Console.WriteLine("Front item after deletion: " + myQueue.Read());
    }
}
