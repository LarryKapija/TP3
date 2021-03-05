using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using static TP3.Circularlist;
namespace TP3
{
    class Program
    {
        static void Main(string[] args)
        {
        Circularlist list = new Circularlist(); 
        Circularlist list2 = new Circularlist(); 
  
        // Teacher example: 5->2->1->3->7->4->0 odd
        // First split: 5->2->1->3
        // Second split result: 7->4->0

        // Antoher example: 5->2->1->3->7->4 even
        // First split: 5->2->1
        // Second split: 3->7->4

        list.head = new Node(5); 
        list.head.next = new Node(2); 
        list.head.next.next = new Node(1); 
        list.head.next.next.next = new Node(3); 
        list.head.next.next.next.next = new Node(7); 
        list.head.next.next.next.next.next = new Node(4); 
        list.head.next.next.next.next.next.next = new Node(0); 
        list.head.next.next.next.next.next.next.next = list.head; 

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("\nOriginal Circular Linked list (odd) ");
        list.printList(list.head);
        // Split the list 
        Console.ForegroundColor = ConsoleColor.Blue;
        list.splitList(); 
        Console.WriteLine("\nFirst Circular List "); 
        list.printList(list.head1); 
        Console.WriteLine("\nSecond Circular List "); 
        list.printList(list.head2); 


        /*EVEN*/
        list2.head = new Node(5); 
        list2.head.next = new Node(2); 
        list2.head.next.next = new Node(1); 
        list2.head.next.next.next = new Node(3); 
        list2.head.next.next.next.next = new Node(7); 
        list2.head.next.next.next.next.next = new Node(4); 
        list2.head.next.next.next.next.next.next = list2.head; 

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("\n\nOriginal Circular Linked list (even) "); 
        list2.printList(list2.head); 
  
        // Split the list 
        Console.ForegroundColor = ConsoleColor.Blue;
        list2.splitList(); 
        Console.WriteLine("\nFirst Circular List "); 
        list2.printList(list2.head1); 
        Console.WriteLine("\nSecond Circular List "); 
        list2.printList(list2.head2); 

        }
    }
}
