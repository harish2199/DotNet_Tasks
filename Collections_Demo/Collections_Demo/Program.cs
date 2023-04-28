using System.Collections;
using System.Collections.Generic;

namespace Collections_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array List
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2.4f);
            list.Add("Hello");
            list.Add(true);
            list.Insert(2, 2);
            list.Remove(1); // removing elemnet at index 2
            Console.WriteLine("Total elements in the list = " + list.Count);

            Console.WriteLine("Before clearing");
            foreach (var i in list) // we can use var or object
            {
                Console.WriteLine(i);
            }

            list.Clear();
            Console.WriteLine("After clearing");
            foreach (var i in list) // we can use var or object
            {
                Console.WriteLine(i);
            }

            //Stack
            Console.WriteLine("------------------------------------------------------------------------");
            Stack s = new Stack();
            s.Push(10);
            s.Push(20);
            s.Push(30);
            s.Push(40);

            Console.WriteLine($"using peek method : {s.Peek()}");

            Console.WriteLine($"{s.Pop()} is popped");

            foreach (var i in s)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine($"{s.Contains(20)}");

            //QUEUE

            Console.WriteLine("------------------------------------------------------------------");

            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            Console.WriteLine($"using peek method : {queue.Peek()}");
            Console.WriteLine($"{queue.Dequeue()} is removed from queue");

            foreach (var i in queue)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine($"{queue.Contains(6)}");

            //Sorted List

            Console.WriteLine("-------------------------------------------------------------------");

            SortedList sortedlist = new SortedList();
            sortedlist.Add(1, 2);
            sortedlist.Add(3, 4);
            sortedlist.Add(4, 5);
            sortedlist.Add(2, 8);
            Console.WriteLine(sortedlist.GetByIndex(0));
            Console.WriteLine(sortedlist.GetKey(2));// it gives the key at index 2



            foreach (var item in sortedlist.Keys)
            {
                Console.WriteLine($"Key: {item} : Value: {sortedlist[item]}");//sortedlist[item] it gives value of item
            }

            //Hash Table

            Console.WriteLine("-------------------------------------------------------------------");

            Hashtable ht = new Hashtable(); 
            ht.Add(1, 2);
            ht.Add(2, 4);
            ht.Add(3, 4);
            ht.Add(4, 5);
            Console.WriteLine($"Total elements in hashtable = {ht.Count}");

            foreach (var item in ht.Keys)
            {
                Console.WriteLine($"Key: {item} : Value: {ht[item]}");//sortedlist[item] it gives value of item
            }
        }
    }
}