using Algorithms;
using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
         // MAIN
        {
            /*
            
            Results of trying the different sorting methods;


            Length of Array:             100                    500               100,000                   1000,0000

            Insertion Sort          00:00:00:0              00:00:00:25         00:00:10:515                [No result]
                    
            Selection Sort          00:00:00:0              00:00:00:80         00:00:32601                 [No result]

            Bubble Sort             00:00:00:0              00:00:00:85         00:01:13:477                [No result]
            
            Merge Sort              00:00:00:0              00:00:00:10         00:00:00:21                 00:00:04:219

            Quick Sort              00:00:00:0              00:00:00:71         00:00:00:20                 00:00:02:730

            Using Lambda            00:00:00:18             00:00:00:6          00:00:00:3                  00:00:00:3

            */

            int arr;
            Console.WriteLine("Enter length of the array");
            arr = Convert.ToInt32(Console.ReadLine());

            int[] arrX = Algoritmer1.Prepare(arr); // using the prepare method from dll file
            Console.WriteLine("\n");

            // switch case menu for user input
            bool a = true;

            while (a){
                Console.WriteLine("Enter the algorithm you want");
                Console.WriteLine("Bubble Sort = B");
                Console.WriteLine("Insertion Sort = I");
                Console.WriteLine("Selection Sort = S");
                Console.WriteLine("Merge Sort = M");
                Console.WriteLine("Quick Sort = Q");
                Console.WriteLine("Lambda Sort = L");
                Console.WriteLine("End = E");

                String menu = Console.ReadLine();

                switch (menu)
                {
                    case "B":
                        Console.WriteLine("Bubbel sort; ");
                        Algoritmer1.DelegateOne Delegate1 = Algoritmer1.BubbleSort; // using the delegate function
                        Algoritmer1.DisplayRunningTime(Delegate1, arrX); // using the displayrunningtime method
                        break;

                    case "I":
                        Console.WriteLine("Insertion sort; ");
                        Algoritmer1.DelegateOne Delegate2 = Algoritmer1.InsertionSort;
                        Algoritmer1.DisplayRunningTime(Delegate2, arrX);
                        break;

                    case "S":
                        Console.WriteLine("Selection sort; ");
                        Algoritmer1.DelegateOne Delegate3 = Algoritmer1.Sort;
                        Algoritmer1.DisplayRunningTime(Delegate3, arrX);
                        break;

                    case "M":
                        Console.WriteLine("Merge sort; ");
                        Algoritmer1.DelegateTwo Delegate4 = Algoritmer1.MergeSort;
                        Algoritmer1.DisplayRunningTime(Delegate4, arrX);
                        break;

                    case "Q":
                        Console.WriteLine("Quick sort; ");
                        Algoritmer1.DelegateTwo Delegate5 = Algoritmer1.QuickSort;
                        Algoritmer1.DisplayRunningTime(Delegate5, arrX);
                        break;

                    case "L":
                        Console.WriteLine("Lamba sort; ");
                        Algoritmer1.DelegateOne Delegate6 = Algoritmer1.LambdaSort;
                        Algoritmer1.DisplayRunningTime(Delegate6, arrX);
                        break;

                    case "E":
                    default:
                        a = false;
                        break;
                }
            }
        }
    }
}
