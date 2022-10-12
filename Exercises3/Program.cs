using System;

namespace Exercises3
{
    class Program
    {
        private int[] a = new int[98];
        private int n;
        public void read()
        {
            while (true)
            {
                Console.Write("Masukan banyaknya elemen pada Array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 98)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 98 elemen. \n");
            }
            Console.WriteLine("");
            Console.WriteLine("----------------------");
            Console.WriteLine(" Masukan elemen array");
            Console.WriteLine("----------------------");

            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            Console.WriteLine("");
            Console.WriteLine("----------------------------------");
            Console.WriteLine(" Elemen array yang telah tersusun ");
            Console.WriteLine("----------------------------------");
            for (int ds = n - 2; ds < n; ds++)
            {
                Console.WriteLine(a[n - 1]);
            }
            Console.WriteLine("");
        }
        public void DwiponcoArray()
        {
            for (int i = 1; i < n; i++)
            {
                for (int ds = n-2; ds < n - i; ds++)
                //repeat steps 2 and 3 varying j from 0 to n-2
                {
                    if (a[ds] > a[n - 1])
                    {
                        int temp;
                        temp = a[ds];
                        a[ds] = a[n - 1]; //arr[j] to arr[n-1]
                        a[n - 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Program mylist = new Program();
            mylist.read();
            mylist.DwiponcoArray();
            mylist.display();
            Console.WriteLine("\n\nTekan Tombol Apa Saja Untuk Keluar.");
            Console.Read();
        }
    }
}
