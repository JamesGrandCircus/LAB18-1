using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab18._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 2, 2, 4, 5, 5, 7, 8, 4, 4, 1, 0, 10 };
            int x = array.Max();
            int[] y = new int[x + 1];
            for (int i = 0; i < y.Length; i++)
            {
                for (int j = 0; j < array.Length; j++) 
                {
                    if (array[j] == i)
                    {
                        y[i]++;
                    }
                }
            }

            for (int i = 0; i < y.Length; i++)
            {
                if (i>0)
                {
                    Console.WriteLine($"[{i}]:{y[i]}");
                }
            }

            LinkedList<int> numbers = new LinkedList<int>();
            numbers.AddFirst(1);
            numbers.AddLast(2);
            numbers.AddLast(3);
            numbers.AddLast(2);
            numbers.AddLast(2);
            numbers.AddLast(4);
            numbers.AddLast(5);
            numbers.AddLast(5);
            numbers.AddLast(7);
            numbers.AddLast(8);
            numbers.AddLast(4);
            numbers.AddLast(4);
            numbers.AddLast(1);
            numbers.AddLast(0);
            numbers.AddLast(10);


            Dictionary<int, int> numlist = new Dictionary<int, int>();
            LinkedList<int> findnum = new LinkedList<int>();

            Console.WriteLine("using dictionary:");
            foreach (var thing in numbers)
            {
                if (numlist.ContainsKey(thing))
                {

                    numlist[thing]++;
                }
                else
                {
                    
                    numlist.Add(thing, 1);
                }
            }
                foreach (int thing in numlist.Keys)
                {
                Console.WriteLine($"{thing}:{numlist[thing]}");
                }

            //remove method, but I'm a little at a loss at what to do with a return bool value, if I'm even doing the method correctly.
            Console.WriteLine("Enter to remove a number");
            
            string index = Console.ReadLine();
            int numindex;
            if (int.TryParse(index, out numindex))
            {
               bool result = numbers.RemoveAt(numindex);
               Console.WriteLine(result);
               
            }
            else
            {
                Console.WriteLine("not a number!");
            }
           

            numbers.PrintReverse();
            numbers.InsertAt(4);
            // ran out of time for more sophiscated implementation, i am bad at this! 














            Console.ReadKey();
        } 
    }
}
