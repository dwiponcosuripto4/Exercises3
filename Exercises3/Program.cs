using System;

namespace Exercises3
{
    class Program
    {
        private int[] a = new int[1890];
        private int n;
        public void read()
        {
            while (true)
            {
                Console.Write("Masukan banyaknya elemen pada Array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 1890)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 1890 elemen. \n");
            }
            Console.WriteLine("");
            Console.WriteLine("----------------------");
            Console.WriteLine(" Masukan elemen array");
            Console.WriteLine("----------------------");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("----------------------------------");
                Console.WriteLine(" Elemen array yang telah tersusun ");
                Console.WriteLine("----------------------------------");
                for (int ds = n-2; ds )
            }
        }
    }
}
