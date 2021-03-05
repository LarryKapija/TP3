using System;
using System.Collections.Generic;
using System.Collections;
namespace TP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating the list
            int count = 0;
            //1->2->1->2->1->3->1
            //int[] teachersExample = {1,2,1,2,1,3,1};
            int[] list = {1,2,1,2,1,3,1,3,4,5,1,2,8,4,3,5,3,6,56,53,4,5,24,5,123,4,12,4,45,9,9,5,2,3,5,3,23,5,3,2,3,5,5,57,57,45,43,5,4};
            int number = 0;
            // Instance of linked list bro
            LinkedList<int> numberList = new LinkedList<int>(list);

            foreach(var item in numberList)
            {
                Console.Write($"{item} ->");
            }
            while(true)
            {
                try 
                {
                    Console.Write("\nInsert the number: ");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch(Exception e )
                {
                    //Console.WriteLine(e);
                    Console.WriteLine("\nInsert a correct value");
                }
            }

            foreach (int i in numberList)
            {
               //Algorithm
                if(i == number )
                {
                    count ++;
                }
            }
            if( count > 0)
            {
                Console.WriteLine($"They are {count} numbers {number} in the list");
            }
            else
            {
                Console.WriteLine($"They are not {number} in the list");
            }
        }
    }
}
