using System;
using Ylib.Util;

namespace Test
{
    class MainClass
    {
        static void Test_PrintA()
        {
            int Rows = 4, Cols = 10;
            double[,] A = new double[Rows, Cols];
            var A1 = new double[Rows * Cols];

            Console.WriteLine("from: Rows = {0}, Cols={1}", Rows, Cols);
            Console.WriteLine("[A] matrix");
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    A[i, j] = (i + 1) * 10 + j;
                    A1[i + j * Rows] = A[i, j];
                    Console.Write("{0} ", A[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("A1");
            A1.PrintV();
            Console.WriteLine("\n---IO---");
            A.PrintA();
            //IO.ChangeMaxColumns(5);
            //var mm = IO.MaxColumns;
            //IO.MaxColumns = 6;
            A1.PrintA1C(Rows, Cols, Rows);
            //IO.MaxColumns = 10;
            //IO.DefaultMaxColumns();
            A.PrintA();
                
        }

        public static void Main(string[] args)
        {
            Test_PrintA();

            Util.Pause();
        }
    }
}
