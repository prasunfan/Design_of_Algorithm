using System;

namespace Iterative
{
    public class Program
    {

        static void Main(string[] args)
        {
            var a=Fib_Iterative(5);
            Console.WriteLine("nth Fibo iterative is::"+a);
            var b=Fib_Recursive(5);
            Console.WriteLine("nth Fibo recursive is::"+b);
            var x=GCD_Iterative(45,30);
            Console.WriteLine("GCD iterative:"+x);
            var y=GCD_Recursive(60,45);
            Console.WriteLine("GCD recursive:"+y);
        }
        public static int Fib_Recursive(int n)
         {
            if (n == 1)
                return 0;
            if (n == 2)
                return 1;

            return Fib_Recursive(n - 1) + Fib_Recursive(n - 2);
        }
        public static long Fib_Iterative(int n)
        {
            long[] fibs = new long[n];

            fibs[0] = 0;
            fibs[1] = 1;

            for (int i = 2; i < n; i++)
            {
                fibs[i] = fibs[i - 1] + fibs[i - 2];
            }

            return fibs[n - 1];
        }

         public static int GCD_Recursive(int a, int b)
         {
             if(a==0){return b;}
             if(b==0){return a;}
             else
             {
                 return GCD_Recursive(b,a%b);
             }
             

        }

        public static int GCD_Iterative(int a, int b)
        {
            if(b==0){return a;}
            if(a==0){return b;}
            int t;
            while(b!=0)
            {
                t=b;
                b=a%b;
                a=t;
            }
            return a;
        }

    }
}