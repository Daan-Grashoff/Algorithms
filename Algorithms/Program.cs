using System;
using System.Diagnostics;
using System.Linq;


// ...



namespace Algorithms
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var rnd = new Random();

			var sorter = new Sort();
			var searcher = new Search();
			var testArray = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };

			//var testArray2 = Enumerable.Repeat(0, 10000).Select(arg => rnd.Next()).ToArray();

			//var a = sorter.InsertionSort(testArray);

			sorter.MergeSort(testArray, 0, testArray.Length - 1);

			//var linkedList = new LinkedList<string>();

			//ITree<int> tree = new Empty<int>();


			//tree = Insertion.InsertTree(tree, 10);
			//tree = Insertion.InsertTree(tree, 11);
			//tree = Insertion.InsertTree(tree, 9);


			//tree = BuildTree(tree, testArray2);

			Console.WriteLine(rnd.Next(1, 10));
		}


		//public static ITree<int> BuildTree(ITree<int> t, int[] P)
		//{
		//	for (int i = 0; i < P.Length - 1; i++)
		//	{
		//		t = Insert(t, P[i]);
		//	}
		//	return t;
		//}
	}

	public class StackNode<T>
	{
		public T Value { get; }
		public StackNode<T> Next { get; }

		public StackNode(T v, StackNode<T> n)
		{
			this.Value = v;
			this.Next = n;
		}
	}

	public class LinkedList<T>
	{
		public StackNode<T> first = null;

		public bool IsEmpty()
		{
			return first == null;
		}

		public void Push(T item)
		{
			StackNode<T> oldfirst = first;
			first = new StackNode<T>(item, oldfirst);
		}

		public T Pop()
		{
			T item = first.Value;
			first = first.Next;
			return item;
		}
	}

	public class Insertion
	{
		public static ITree<int> InsertTree(ITree<int> T, int i)
		{
			if (T.IsEmpty)
				return new Node<int>(new Empty<int>(), i, new Empty<int>());

			if (T.Value < i)
				return new Node<int>(T.Left, T.Value, InsertTree(T.Right, i));
			else
				return new Node<int>(InsertTree(T.Left, i), T.Value, T.Right);
		}
	}
}
