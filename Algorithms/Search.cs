using System;
using System.Diagnostics;
using System.Linq;

// ...

namespace Algorithms
{
	
	public class Search
	{
		public int LinearSearch(int[] seq, int target)
		{
			for (int i = 0; i < seq.Length; i++)
			{
				if (seq[i] == target)
				{
					return i;
				}
			}
			return -1;
		}

		public int BinearySearch(int[] seq, int low, int high, int target)
		{
			if (low > high)
				return -1;

			var m = high + (low - high) / 2;

			if (seq[m] == target)
			   return m;

			if (seq[m] > target)
				return BinearySearch(seq, low, m - 1, target);
			else
				return BinearySearch(seq, m + 1, high, target);
		}

		public bool BinaryTreeSearch(ITree<int> T, int v)
		{
			if (T.IsEmpty)
				return false;
			
			//Console.WriteLine(T.Value + " - " + v);
			
			if (T.Value == v)
				return true;
			else
			{
				if (v < T.Value)
				{
					return BinaryTreeSearch(T.Left, v);
				}else {
					return BinaryTreeSearch(T.Right, v);
				}
			}
				
		}

		public void TreeWalker(ITree<int> T)
		{
			if (!T.IsEmpty)
			{
				TreeWalker(T.Left);
				Console.WriteLine(T.Value);
				TreeWalker(T.Right);
			}
		}

	}

}
