using System;
using System.Diagnostics;

// ...

namespace Algorithms
{

	public interface ITree<T>
	{
		bool IsEmpty { get; }
		T Value { get; }
		ITree<T> Left { get; }
		ITree<T> Right { get; }
	}

	public class Empty<T> : ITree<T>
	{
		public bool IsEmpty
		{
			get
			{
				return true;
			}
		}

		public ITree<T> Left
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public ITree<T> Right
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public T Value
		{
			get
			{
				throw new NotImplementedException();
			}
		}
	}

	public class Node<T> : ITree<T>
	{
		public bool IsEmpty { get { return false; } }

		public ITree<T> Left { get; set; }

		public ITree<T> Right { get; set; }

		public T Value { get; set; }

		public Node(ITree<T> l, T v, ITree<T> r)
		{
			this.Left = l;
			this.Right = r;
			this.Value = v;
		}
	}

}
