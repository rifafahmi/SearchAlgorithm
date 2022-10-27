using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithm
{
    class Program
    {

        class program
        {
            // Array to be searched
            int[] arr = new int[20];
            //number of elements in the array
            int n;
            // get the number of elements to store in the array
            int i;

            public void input()
            {
                while (true)
                {
                    Console.Write("Enter the number of elements on the array : ");
                    string s = Console.ReadLine();
                    n = int32.Parse(s);
                    if ((n > 0) && (n <= 20))
                        break;
                    else
                        Console.WriteLine("\nArray should have minimum 1 and maximum 20 elements.\n");
                }
                // Accept  array elements
                Console.WriteLine("");
                Console.WriteLine("----------------------");
                Console.WriteLine(" Enter array elements ");
                Console.WriteLine("----------------------");
                for (i = 0; i < n; i++)
                {
                    Console.Write("<" + (i + 1) + "> ");
                    string s1 = Console.ReadLine();
                    arr[i] = Int32.Parse(s1);

                }
            }

            public void BinarySearch()
            {
                char ch;
                do
                {
                    // accept the numbet to be searched 
                    Console.Write("|nEnter element want you to search :");
                    int item = Convert.ToInt32(Console.ReadLine());

                    //apply binary search 
                    int lowerbound = 0;
                    int Upperbound = n - 1;

                    //obtain the idex of the middle elements
                    int mid = (lowerbound + +Upperbound) / 2;
                    int ctr = 1;

                    // loop to search for the elements in the array
                    while ((item != arr[mid]) && (lowerbound <= Upperbound))
                    {
                        if (item > arr[mid])
                            lowerbound = mid + 1;
                        else
                            Upperbound = mid - 1;
                        mid = (lowerbound + Upperbound) / 2;
                        ctr++;

                    }
                    if (item == arr[mid])
                        Console.WriteLine("\n" + item.ToString() + " found at position " + (mid + 1).ToString());
                    else
                        Console.WriteLine("\n" + item.ToString() + " not found in the array\n");
                    Console.WriteLine("\nNumber of Comparasion : " + ctr);

                    Console.Write("\nContinue search (y/n):");
                    ch = char parse((Console.ReadLine));

                } while ((ch == 'y') || (ch == 'Y'));
            }

            public void LinearSearch()
            {
                char ch:
                //search for number of comparison
                int ctr;
                do
                {
                    //accept the number to be the searched
                    Console.Write("\nEnter the elements yo \u want to search: ");
                    int item = Convert.ToInt32(Console.ReadLine());

                    ctr = 0;
                    for (i = 0; i < n; i++)
                    {
                        ctr++;
                        if (arr[i] == item)
                        {
                            Console.WriteLine("\n" + item.ToString() + " found st possition " + (i + 1).ToString());
                            break;
                        }
                    }
                    if (i == n)
                        Console.WriteLine("\n" + item.ToString() + " not found in the array");
                    Console.WriteLine("\nNumber of comparison; " + ctr);
                    Console.Write("\nContinue search (y/n):");
                    ch = Char.Parse(Console.ReadLine());
                } while ((ch == 'y') || (ch == 'Y'));
            }

            static void Main(string[] args)
            {
                Program myList = new Program();
                int pilihmenu;
                do
                {
                    Console.WriteLine("Menu Option");
                    Console.WriteLine("=====================");
                    Console.WriteLine("1.Linier Search");
                    Console.WriteLine("2.Binary Search");
                    Console.WriteLine("3.Exit");
                    Console.Write("enter your choice (1,2,3) : ");
                    pilihmenu = Convert.ToInt32(Console.ReadLine());

                    switch (pilihmenu)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine(".......................");
                            Console.WriteLine("linear Search");
                            Console.WriteLine(".......................");
                            myList.input();
                            myList.LinearSearch();
                            break;

                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine(".......................");
                            Console.WriteLine("Binary Search");
                            Console.WriteLine(".......................");
                            myList.input();
                            myList.BinarySearch();
                            break;

                        case 3:
                            Console.WriteLine("exit.");
                            break;
                        default:
                            Console.WriteLine("eror");
                            break;

                    }
                    //to exit from the console
                    Console.WriteLine("\n\nPress Return to exit.");
                    Console.Readline();
                } while (pilihmenu != 3);
            }
        }

    }
}using System;

