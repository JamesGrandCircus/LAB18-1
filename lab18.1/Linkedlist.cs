using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab18._1
{

    public static class Linkedlist
    {

       
        

        public static void PrintReverse(this LinkedList<int> list)
        {
            Console.WriteLine("original array: \n 1 \n 2 \n 3 \n 2\n 2\n 4\n 5\n 5\n 7\n 8\n 4\n 4\n 1\n 0\n 10");
            Console.WriteLine("reversed");
            for (int i = list.Count -1; i >= 0; i--)
            {
                
                    Console.WriteLine(list.ElementAt(i));
              
            }
        }

        public static bool InsertAt(this LinkedList<int> x, int index)
        {

            LinkedListNode<int> thisnode = x.First;
            if (x.Count >= index)
            {
                for (int i = 0; i < x.Count; i++)
                {
                    if (i==index -1)
                    {
                        x.AddAfter(thisnode, 1);
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public static class LinkedListExtensions
    {

        public static bool RemoveAt<T>(this LinkedList<T> list, int index)

        {
            if (index >= list.Count)
            {
                return false;
            }
            else
            {
                LinkedListNode<T> current = list.First;
                for (int i = 0; i <= index && current != null; i++)
                {
                    if (i != index)
                    {
                        current = current.Next;
                        continue;
                    }
                    else
                    {
                        list.Remove(current);
                        return true;
                    }
                }
            }
            return false;



        }
    }
}
