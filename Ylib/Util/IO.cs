using System;
using System.Security.Cryptography;
using System.Runtime.Remoting.Messaging;

namespace Ylib.Util
{
	public static class IO
	{
		static int MAX_COLUMNS = 10;

		public static int MaxColumns {
			get {
				return MAX_COLUMNS;
			}
			set {
				MAX_COLUMNS = value;
			}
		}

		public static void ChangeMaxColumns (int maxcols)
		{
			if (maxcols < 1)
				MAX_COLUMNS = 1;
			MAX_COLUMNS = maxcols;
		}

		public static void DefaultMaxColumns ()
		{
			MAX_COLUMNS = 10;
		}

		/// <summary>
		/// Print out the 2-D matrix on the screen.
		/// </summary>
		/// <param name="A">the 2D matrix.</param>
		public static void PrintA (this double[,] A)
		{
			var Rows = A.GetLength (0);
			var Cols = A.GetLength (1);
			int jl, jh;
			for (jl = 0; jl < Cols; jl += MAX_COLUMNS) {
				jh = jl + MAX_COLUMNS;
				if (jh > Cols)
					jh = Cols;
				Console.WriteLine ();
				Console.Write (Util.Spaces (6));
				for (int j = jl; j < jh; j++) {
					Console.Write ("{0,8:d}", j + 1);
				}
				Console.WriteLine ();
				for (int i = 0; i < Rows; i++) {
					Console.Write ("{0,6:d}", i + 1);
					for (int j = jl; j < jh; j++) {
						Console.Write ("{0,8:f2}", A [i, j]);
					}
					Console.WriteLine ();
				}
			}
			Console.WriteLine ();
		}

		/// <summary>
		/// Prints out a 2-D matrix with the form of 1-D column-mjor array .
		/// </summary>
		/// <param name="A">A[n,m]</param>
		/// <param name="n">Numbers of rows.</param>
		/// <param name="m">Numbers of columns.</param>
		/// <param name="nn">Number of rows of the matrix what A is belong to.</param>
		public static void PrintA1C (this double[] A, int n, int m, int nn)
		{
			var Rows = n;
			var Cols = m;
			int jl, jh;
			int p0 = -1 - nn;
			for (jl = 1; jl <= Cols; jl += MAX_COLUMNS) {
				jh = jl + MAX_COLUMNS - 1;
				if (jh > Cols)
					jh = Cols;
				Console.WriteLine ();
				Console.Write (Util.Spaces (6));
				for (int j = jl; j <= jh; j++) {
					Console.Write ("{0,8:d}", j);
				}
				Console.WriteLine ();
				for (int i = 1; i <= Rows; i++) {
					Console.Write ("{0,6:d}", i);
					for (int j = jl; j <= jh; j++) {
						Console.Write ("{0,8:f2}", A [p0 + i + j * nn]);
					}
					Console.WriteLine ();
				}
			}
			Console.WriteLine ();
		}

		/// <summary>
		/// Prints the vector to console.
		/// </summary>
		/// <param name="V">The source vector.</param>
		public static void PrintV (this double[] V)
		{
			V.PrintA1C (1, V.Length, 1);
		}
	}
}

