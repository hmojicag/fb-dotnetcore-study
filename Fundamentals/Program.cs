using System;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
    			Console.WriteLine("--------Testing Node------------------");
    			Node<string> firstNode = new Node<string>("Hello Haza");
    			Node<string> lastNode = firstNode;
    			Console.WriteLine("FirstNode: " + firstNode.ToString());
    			Console.WriteLine("LastNode: " + lastNode.ToString());
    			lastNode.Item = "Hello chango";
    			Console.WriteLine("FirstNode: " + firstNode.ToString());
    			Console.WriteLine("LastNode: " + lastNode.ToString());

    			Console.WriteLine("--------Testing Bag------------------");
    			Bag<string> bag = new Bag<string>();
    			bag.addItem("Cloud");
    			bag.addItem("Tifa");
    			bag.addItem("Red XIII");
    			Console.WriteLine(bag.ToString());

          Console.WriteLine("--------Testing Queue------------------");
          Queue<string> queue = new Queue<string>();
          queue.enqueue("Cloud");
          queue.enqueue("Tifa");
          queue.enqueue("Barret");
          Console.WriteLine(queue);//Cloud, Tifa, barret
          Console.WriteLine("Dequeued: " + queue.dequeue());//Barret
          queue.enqueue("Red XIII");
          Console.WriteLine(queue);//Cloud, Tifa, Red XIII
          Console.WriteLine("Dequeued: " + queue.dequeue());//Red XIII
          Console.WriteLine("Dequeued: " + queue.dequeue());//Tifa
          Console.WriteLine("Dequeued: " + queue.dequeue());//Cloud
          Console.WriteLine(queue);//Empty Queue
          queue.enqueue("Cid");
          Console.WriteLine(queue);//Cid
        }

    }
}
