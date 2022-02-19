using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListImplementation
{
   public class LinkedList
    {
       public class Node
        {
            internal int Data;
            internal Node nextElement;
            public Node()
            {
                nextElement = null;
             
            }
        }

        Node head;
        public LinkedList()
        {
            head = null;
        }

        public bool IsEmpty()
        {
            if (head == null)
                return true;
            else 
                return false;         
        }
        public void InsertAtHead(int value)
        {
           Node Newnode = new Node();
            Newnode.Data = value;
            Newnode.nextElement = head;
            head = Newnode;
            Console.Write(value + " Inserted !    ");
        }

        public bool PrintList()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Empty List");
                return false;
            }
            Node temp= head;
            Console.WriteLine("List: ");
            while (temp != null)
            {
                Console.WriteLine(temp.Data + "->");
              temp = temp.nextElement;
            }
            Console.WriteLine("null");
            return true;
        }

        //Create a function insertAtTail() that takes an integer, adds the integer to the end of a 
        // linked list, and returns the updated linked list.The new node will point to null.
        public string Elements()
        {
            string elementList = "";      
            Node temp = head;
            while(temp != null)
            {
                elementList += temp.Data.ToString();
                elementList += "->";
                temp = temp.nextElement;
            }
            elementList += "null";
           return elementList;          
        }

        public void InsertAtTail(int value)
        {
            if (IsEmpty())
            {
                InsertAtHead(value);    
            }

            Node NewNode = new Node();
            Node last= head;

            while(last.nextElement != null)
            {
                last = last.nextElement;    
            }
            NewNode.Data = value;
            Console.WriteLine(value + "Inserted") ;
            NewNode.nextElement = null;
            last.nextElement = NewNode;
        }

        public int SumValues()
        {
            int sum = 0;
            Node current = head;
            while(current != null)
            {
                sum += current.Data;
                current = current.nextElement;
            }
            return sum; 
        }

        public bool FindTarget(int val)
        {
            Node cucrrent = head;
            while (cucrrent != null)
            {
                if(cucrrent.Data == val)
                {
                    return true;
                }
                cucrrent = cucrrent.nextElement;                  
            }
            return false;
        }

        public int FindIndex(int index)
        {
          Node current = head;
          int count = 0;
            while (current != null)
            {               
                if(count == index)
                    return current.Data;
                count++;
                current = current.nextElement;               
            }           
            return 0;
        }

        public Node Reverse()
        {
            Node prev = null;
            Node current = head;
            while(current != null)
            {
                Node next = current.nextElement;
                current.nextElement = prev;
                prev = current;
                current = next;
            }
            return prev;
        }
        public Node ZipperList(Node head1, Node head2)
        {
            Node tail = head1;
            Node current1 = head1.nextElement;
            Node current2 = head2;
            int counter = 0;

            while(current1 != null && current2!= null)
            {
                if (counter % 2 == 0)
                {
                    tail.nextElement = current2;
                    current2 = current2.nextElement;
                }
                else
                {
                    tail.nextElement = current1;
                    current1 = current1.nextElement;
                }
                tail= tail.nextElement;
                counter++;
            }

            if(current1 != null) tail.nextElement = current1;
            if (current2 != null) tail.nextElement = current2;
            return head1;
        }
    }
}
