using System;


namespace ConsoleApp1
{
    class Program
    {

        static int functionRef(ref int i, int j)
        {
            i--;
            return i + j;
        }

        static int functionOut(out int i, int j) {
            j--;
            i = j;
            return i + j;
        }
            
        static void Main(string[] args)
        {
            int i = 9, j = 100;
            //int sum = functionRef(ref i, j);
            int sum = functionOut(out i, j);
            Console.WriteLine(i);
            Console.WriteLine(sum);


            int n = 0.01 as Double;
            Console.WriteLine("n = " +n);
        }
    }
}
