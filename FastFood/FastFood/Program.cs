using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int foodQuantity = int.Parse(Console.ReadLine());

        int[] Orders = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Queue<int> orders = new Queue<int>(Orders);

        int biggestOrder = int.MinValue;

        while (orders.Count > 0)
        {
            int currentOrder = orders.Peek();

            if (currentOrder > biggestOrder)
            {
                biggestOrder = currentOrder;
            }

            if (foodQuantity >= currentOrder)
            {
                foodQuantity -= currentOrder;
                orders.Dequeue();
            }
            else
            {
                break;
            }
        }

        Console.WriteLine(biggestOrder);

        if (orders.Count == 0)
        {
            Console.WriteLine("Orders complete");
        }
        else
        {
            Console.WriteLine("Orders left: " + string.Join(" ", orders));
        }
    }
}
