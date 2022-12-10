using System;

namespace task92
{
    class Program
    {
        static void Main(string[] args)
        {
             int[] myArray = Enumerable.Range(1,8).ToArray();

           for (int i=0; i<myArray.Length; i++ )
           {
            Console.WriteLine(myArray[i]);
           }
        }

    }
}