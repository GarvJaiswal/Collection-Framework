using System;
using System.Collections.Generic;

class IntStackCRUD
{
    private Stack<int> stack;

    public IntStackCRUD()
    {
        stack = new Stack<int>();
    }

    public void Create(int item)
    {
        stack.Push(item);
    }

    public int Read()
    {
        if (stack.Count > 0)
            return stack.Peek();
        else
            throw new InvalidOperationException("Stack is empty");
    }

    public void Update(int newItem)
    {
        if (stack.Count > 0)
        {
            stack.Pop();
            stack.Push(newItem);
        }
        else
        {
            throw new InvalidOperationException("Stack is empty");
        }
    }

    public int Delete()
    {
        if (stack.Count > 0)
            return stack.Pop();
        else
            throw new InvalidOperationException("Stack is empty");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IntStackCRUD myStack = new IntStackCRUD();

        // Create
        myStack.Create(1);
        myStack.Create(2);
        myStack.Create(3);

        // Read
        Console.WriteLine("Top item in the stack: " + myStack.Read());

        // Update
        myStack.Update(4);
        Console.WriteLine("Top item in the stack after update: " + myStack.Read());

        // Delete
        Console.WriteLine("Deleted item from the stack: " + myStack.Delete());
        Console.WriteLine("Top item in the stack after deletion: " + myStack.Read());
    }
}
