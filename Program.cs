using System;

namespace IN4451_U4M3
{
    public class IT451_u4m3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In Program Main\n");

            IT451_u4m3 test = new IT451_u4m3();

            // =========================
            // Example 1 TEST CASES
            // =========================
            Console.WriteLine("=== Example 1 Tests (Minimum Value) ===");

            int[] ex1_test1 = { 4, 2, 9, 1, 6 };
            Console.WriteLine("Test 1 Result: " + test.Example1(ex1_test1, 5));

            int[] ex1_test2 = { 20, 15, 30, 10, 25 };
            Console.WriteLine("Test 2 Result: " + test.Example1(ex1_test2, 3));

            Console.WriteLine();

            // =========================
            // Example 2 TEST CASES
            // =========================
            Console.WriteLine("=== Example 2 Tests (Print Array) ===");

            int[] ex2_test1 = { 1, 2, 3 };
            test.Example2(ex2_test1);

            Console.WriteLine();

            int[] ex2_test2 = { 10, 20, 30, 40 };
            test.Example2(ex2_test2);

            Console.WriteLine();

            // =========================
            // Example 3 TEST CASES
            // =========================
            Console.WriteLine("=== Example 3 Tests (Search Values 10 & 5) ===");

            int[] ex3_test1 = { 10, 2, 5, 8 };
            Console.WriteLine("Test 1 Result: " + test.Example3(ex3_test1));

            int[] ex3_test2 = { 1, 2, 3, 4 };
            Console.WriteLine("Test 2 Result: " + test.Example3(ex3_test2));
        }

        // =====================================================
        // Example 1: Return minimum value from first z elements
        // =====================================================
        public int Example1(int[] y, int z)
        {
            int currmin = y[0];

            for (int i = 0; i < z && i < y.Length; i++)
            {
                if (y[i] < currmin)
                {
                    currmin = y[i];
                }
            }

            return currmin;
        }

        // =====================================================
        // Example 2: Print each value in the array
        // =====================================================
        public void Example2(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        // =====================================================
        // Example 3: Search for values 10 and 5 in array
        // =====================================================
        public bool Example3(int[] foo)
        {
            int a = 10;
            int b = 5;

            bool foundA = false;
            bool foundB = false;

            for (int i = 0; i < foo.Length; i++)
            {
                if (foo[i] == a)
                {
                    Console.WriteLine("The value of a (10) was found in the int array.");
                    foundA = true;
                }

                if (foo[i] == b)
                {
                    Console.WriteLine("The value of b (5) was found in the int array.");
                    foundB = true;
                }
            }

            if (!foundA && !foundB)
            {
                Console.WriteLine("None of the search values were found.");
            }

            return foundA || foundB;
        }
    }
}