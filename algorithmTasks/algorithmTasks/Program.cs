namespace algorithmTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1:  Verilən ədədə və ya ondan böyük ən yaxın ədədə qədər fibonaççi ardıcıllığını ekrana çap edin.
            /*
             * F(0) = 0
             * F(1) = 1
             * F(n) = F(n-1) + F(n-2) = 1
             */
            Console.WriteLine("Enter a number to find the Fibonacci series up to: ");
            int rightBoundary = Convert.ToInt32(Console.ReadLine());
            int fibonacciOne = 0;
            int fibonacciTwo = 1;
            int fibonacciThree = 0;
            Console.WriteLine("Fibonacci series: ");
            Console.WriteLine(fibonacciOne);
            Console.WriteLine(fibonacciTwo);
            while (fibonacciThree < rightBoundary)
            {
                fibonacciThree = fibonacciOne + fibonacciTwo;
                fibonacciOne = fibonacciTwo;
                fibonacciTwo = fibonacciThree;
                Console.WriteLine(fibonacciThree);
                if (fibonacciThree > rightBoundary)
                {
                    Console.WriteLine("Since " + rightBoundary + " does not exist in the Fibonacci series, the algorithm stopped on the smallest term of the series greater than " + rightBoundary + ", or on " + fibonacciThree);
                }
            }
            //task 2:  2 dəyişənin dəyərlərini 3cü dəyişən istifadə etmədən dəyişin
            //int a = -3;
            //int b = -7;
            ////arithmetic add/substrrction time O(1), space O(1)
            //a = a + b;
            //b = a - b;
            //a = a - b;
            ////bitwise xor time O(1), space O(1)
            //a = a ^ b;
            //b = a ^ b;
            //a = a ^ b;
            //Console.WriteLine(a + ", " + b);
        }
    }
}
