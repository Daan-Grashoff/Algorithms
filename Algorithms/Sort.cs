using System;
using System.Diagnostics;
using System.Linq;

// ...

namespace Algorithms
{

	public class Sort
	{
		public int[] InsertionSort(int[] a)
		{
			for (int i = 1; i < a.Length; i++)
			{
				int key = a[i];

				int j = i - 1;

				while (j >= 0 && key < a[j])
				{
					a[j + 1] = a[j];
					j = j - 1;
				}

				a[j + 1] = key;
			}
			return a;
		}

		public int[] BubbleSort(int[] a)
		{
			for (int i = 0; i < a.Length - 1; i++)
			{
				for (int j = 0; j < a.Length - j; j++)
				{
					if (a[j] > a[j + 1])
					{
						Swap(a[j], a[j + 1]);
					}
				}
			}
			return a;
		}

		public static void Swap(int a, int b)
		{
			int tmp = a;
			a = b;
			a = tmp;
		}


		public void MergeSort(int[] A, int p, int r)
		{
			if (p < r)
			{
				int q = (p + r) / 2;
				MergeSort(A, p, q);
				MergeSort(A, q + 1, r);
				Merge(A, p, q, r);
			}
		}
		public void Merge(int[] A, int p, int q, int r)
		{
			int n1 = q - p + 1;
			int n2 = r - q;

			int[] L = new int[n1];
			int[] R = new int[n2];

			for (int i = 0; i < n1; i++)
				L[i] = A[p + i];

			for (int j = 0; j < n2; j++)
				R[j] = A[q + 1 + j];



			int ii = 0;
			int jj = 0;
			int k = p;

			while (ii < n1 && jj < n2)
			{
				if (L[ii] <= R[jj])
				{
					A[k] = L[ii];
					ii++;
					k++;
				}
				else
				{
					A[k] = R[jj];
					jj++;
					k++;
				}
			}

			while (ii < n1)
			{
				A[k] = L[ii];
				k++;
				ii++;
			}

			while (jj < n2)
			{
				A[k] = R[jj];
				k++;
				jj++;
			}
				
		}
	}

}
