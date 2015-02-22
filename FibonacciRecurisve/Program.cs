using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciRecurisve
{
    class Program
    {
        public static double FiboRecursive(double fib)
        {
            if (fib == 0 || fib == 1)
            {
                return 1;
            }
            else
            {
                return (FiboRecursive(fib-2) + FiboRecursive(fib-1));
            }
        }
        static void Main(string[] args)
        {
            Stopwatch st = new Stopwatch();

            Console.WriteLine("Bulunmasini istediginiz fibonacci degerini giriniz:  ");
            int fib = Int32.Parse(Console.ReadLine());
            st.Start();
            Console.WriteLine(fib + ". fibonacci sayisinin degeri : " + FiboRecursive(fib-1));
            st.Stop();
            TimeSpan ts = st.Elapsed;
            string time = String.Format("{0}:{1}:{2}.{3}", ts.Hours, ts.Minutes, ts.Seconds, ts.TotalMilliseconds * 1000000);
            Console.WriteLine("Bulma suresi : " + time);
            Console.ReadLine();
        }
    }
}
