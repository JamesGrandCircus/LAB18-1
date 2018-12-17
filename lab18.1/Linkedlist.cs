using System;
using System.Collections.Generic;
using System.Linq;

namespace lab18._1
{

	public static class Linkedlist
	{


		// James - I love that this is in a seperate file! good stuff.... I see that you are trying to make your own version of 
		// a linked list?   not really necessary, we just want you to add functionality to the existing linked list from dotnet.

		public static void PrintReverse(this LinkedList<int> list)
		{
			Console.WriteLine("original array: \n 1 \n 2 \n 3 \n 2\n 2\n 4\n 5\n 5\n 7\n 8\n 4\n 4\n 1\n 0\n 10");
			Console.WriteLine("reversed");
			for (int i = list.Count - 1; i >= 0; i--)
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
					if (i == index - 1)
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

	// JAmes -- Awesome stuff, I would put this entire class in it's own file though.  
	public static class LinkedListExtensions
	{

		// James -- Looks like you are getting a hang of extension methods, nicely done.
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
