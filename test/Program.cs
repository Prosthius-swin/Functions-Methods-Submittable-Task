using System;
using System.Collections;

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
            arraySum();

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

            static string arraySum() {
                Console.WriteLine("test");
                int[] array = new int[5];
                Console.WriteLine("Input 5 elements in the array.");
                for(int i; i < 5; i++) {
                    Console.WriteLine("Element {0} : " + i);
                    array[i] = Int32.Parse(Console.ReadLine());
                } 
                int sum = array.sum(); 
                Console.WriteLine("The sum of elements of the array is " + sum);
            }
        }
    }
}
