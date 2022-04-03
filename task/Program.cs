using System;
using System.Collections;
using System.Collections.Generic;
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
            //swapTwoInt();
            //raiseIntegerToAnother();
            //fibonacciSequence();
            //primeNumber();
            individualDigitsSum();


            //1
            /*static string sayHello() {
                string hello = "Welcome friends! \nHave a nice day!";
                Console.WriteLine(hello);
                return hello;
            }

            //2
            static string Welcome(string name = "") {
                string welcome = "Welcome friend " + name + "!" + "\nHave a nice day!";
                Console.WriteLine(welcome);
                return welcome;
            }

            //3
            static string AddTwoNums(int n1, int n2) {
                int n3 = n1 + n2;
                Console.WriteLine("The sum of two numbers is: " + n3);
                string answer = Console.ReadLine();
                return answer;
            }

            //4
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
            }

            //5
            static string arraySum() {
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

            //6
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
                }

            //7
            static string raiseIntegerToAnother() {
                int baseNum;
                int expon;
                double raised;
                string answer;
                
                Console.WriteLine("Enter the base number");
                baseNum = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the exponent");
                expon = int.Parse(Console.ReadLine());

                raised = Math.Pow(baseNum, expon);

                Console.WriteLine("The number " + baseNum + " ^ (to the power of) " + expon + " = " + raised);
                answer = Console.ReadLine();
                return answer;
            }

            //8
            static string fibonacciSequence() {
                int counter;
                int first = 0;
                int second = 1;
                int result;
                List<int> sequence = new List<int>();

                Console.Write("Input number of fibonacci series : ");
                counter = int.Parse(Console.ReadLine());

                if (counter >= 1) {
                    sequence.Add(0);
                } if (counter >=2) {
                    sequence.Add(1);
                }
                
                for (int i = 2; i < counter; i++) {
                    result = first + second;
                    first = second;
                    second = result;
                    sequence.Add(result);
                }
                Console.WriteLine();
                foreach(int fib in sequence) {
                    Console.Write(fib + " ");
                } Console.WriteLine();
                return sequence.ToString();
            }

            //9
            static string primeNumber() {
                int number;
                int check = 0;
                string result;

                Console.Write("Input a number: ");
                number = int.Parse(Console.ReadLine());

                for (int i = 1; i <= number; i++) {
                    if (number % i == 0) {
                    check++;
                }
            } 
            if (check == 2) {
            Console.WriteLine("{0} is a Prime Number", number);
            result = Console.ReadLine();
            } else {
                Console.WriteLine("{0} is not a prime number", number);
                result = Console.ReadLine();
            }
            Console.WriteLine();
            return result;
            }*/

            //10
            static string individualDigitsSum() 
            {
                int num;
                int sum = 0;
                int remainder;
                string answer;

                Console.Write("Enter a number: ");
                num = int.Parse(Console.ReadLine());
           
                while (num > 0) 
                {
                    remainder = num % 10;
                    Console.WriteLine(remainder);
                    sum = sum + remainder;
                    num = num / 10;
                }
            
                Console.WriteLine("The Sum of Digits is: {0}", sum);
                answer = Console.ReadLine();
                return answer;
            }
        }
    }
}
