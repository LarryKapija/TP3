using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP3
{
    public class Circularlist
    {
    public Node head, head1, head2; 
  
    public class Node  
    { 
        public int data; 
        public Node next, prev; 
  
        public Node(int d) 
        { 
            data = d; 
            next = prev = null; //next property is here
        } 
    } 
    //rabbit = fast
    //turtle or hare idk = slow
    
    public void splitList()  
    { 
        Node turtle = head; //even
        Node rabbit = head; //odd
  
        if (head == null)  //is empty
        { 
            return; 
        } 
  
        
        while (rabbit.next != head && 
               rabbit.next.next != head) //while they are not equal to head because its circular list
                                         // whenever its equal to head just finish the cycle
        { 
            rabbit = rabbit.next.next; 
            turtle = turtle.next; 
        } 

        if (rabbit.next.next == head) // even
        { 
            rabbit = rabbit.next; 
        } 

        head1 = head; 
    
        if (head.next != head) 
        { 
            head2 = turtle.next; 
        } 
          
        rabbit.next = turtle.next; 
  
        turtle.next = head;
 
    } 
  
    public void printList(Node node) 
    { 
        Node temp = node; 
        if (node != null)  
        { 
            do
            { 
                Console.Write(temp.data + " "); 
                temp = temp.next; 
            } while (temp != node); 
        } 
    } 
    
    } 
}
