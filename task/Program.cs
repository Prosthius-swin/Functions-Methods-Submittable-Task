﻿using System;
using System.Collections;
using System.Linq;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            //sayHello();
            //Welcome("John");
            //AddTwoNums(10, 3);
            //NumOfSpaces("This is a string");
            //arraySum();
            swapTwoInt();

            /*static string sayHello() {
                string hello = "Welcome friends! \nHave a nice day!";
                Console.WriteLine(hello);
                return hello;
            }

            static string Welcome(string name = "") {
                string welcome = "Welcome friend " + name + "!" + "\nHave a nice day!";
                Console.WriteLine(welcome);
                return welcome;
            }

            static string AddTwoNums(int n1, int n2) {
                int n3 = n1 + n2;
                Console.WriteLine("The sum of two numbers is: " + n3);
                string answer = Console.ReadLine();
                return answer;
            }

            static string NumOfSpaces(string input = "") {
                int spaces = 0;
                for (int i = 0; i < input.Length; i++) {
                    if (test[i] == ' ') {
                        spaces++;
                    }
                }
                    Console.WriteLine(test + " contains " + spaces + " spaces.");
                    string spacesCount = Console.ReadLine();
                    return spacesCount;
            }*/

            /*static string arraySum() {
                int[] arr = new int[5];
                Console.WriteLine("Input 5 elements in the array.");
                for(int i = 0; i < 5; i++) {
                    Console.WriteLine("Element - {0} : ",i);
                    arr[i] = Int32.Parse(Console.ReadLine());
                } 
                int sum = arr.Sum(); 
                Console.WriteLine("The sum of elements of the array is " + sum);
                string sumString = Console.ReadLine();
                return sumString;
            }

            static string swapTwoInt() {
                int i = 0;
                int[] arr = new int[2];

                Console.WriteLine("Enter a number: ",i);
                arr[i] = Int32.Parse(Console.ReadLine());
                i++;

                Console.WriteLine("Enter another number: ",i);
                arr[i] = Int32.Parse(Console.ReadLine());

                Array.Reverse(arr);
                Console.WriteLine();

                Console.WriteLine("Now the first number is " + arr[0] + " and the second number is " + arr[1] + ".");
                string swap = Console.ReadLine();

                return swap;
                }*/

            static string raiseIntegerToAnother() {
                int i = 0;
                int[] arr = new int[2];

                Console.WriteLine("Input Base number: ",i);
                arr[i] = Int32.Parse(Console.ReadLine());
                i++;

                Console.WriteLine("Input the Exponent: ",i);
                arr[i] = Int32.Parse(Console.ReadLine());

                int raised = Math.Pow(arr[0], arr[1]);

                Console.WriteLine();
            }
            }
        }
    }
//}