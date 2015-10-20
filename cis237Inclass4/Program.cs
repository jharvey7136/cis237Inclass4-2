﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define a new linked list to use
            MyLinkedList myLinkedList = new MyLinkedList();

            //Add a bunch of stuff to it
            myLinkedList.Add("first");
            myLinkedList.Add("second");
            myLinkedList.Add("third");
            myLinkedList.Add("fourth");

            //Loop through with this differently looking for loop to output
            //In here, the first part is initalization: Setting x to the Head
            //the second part is the test: If x != null, keep going
            //The last part is: Set the current x to x's next porinter. (The next in the list)
            for (Node x = myLinkedList.Head; x != null; x = x.Next)
            {
                Console.WriteLine(x.Data);
            }

            //Couple of blank lines
            Console.WriteLine();
            Console.WriteLine();

            //Print out the 2nd one
            Node nodeINeed = myLinkedList.Retrive(2);
            Console.WriteLine(nodeINeed.Data);

            //Print out the 2nd one again in one statement
            Console.WriteLine(myLinkedList.Retrive(2).Data);

            //Couple of blank lines
            Console.WriteLine();
            Console.WriteLine();

            //Delete the 2nd element in the list
            myLinkedList.Delete(2);
            //Delete the new 2nd element in the list. Was 3rd before previous delete
            myLinkedList.Delete(2);

            for (Node x = myLinkedList.Head; x != null; x = x.Next)
            {
                Console.WriteLine(x.Data);
            }

            //Couple of blank lines
            Console.WriteLine();
            Console.WriteLine();

            //Add two new ones to the list
            myLinkedList.Add("fifth");
            myLinkedList.Add("sixth");

            //Print the list one last time
            for (Node x = myLinkedList.Head; x != null; x = x.Next)
            {
                Console.WriteLine(x.Data);
            }


            Console.WriteLine("***************************************");
            Console.WriteLine("***************************************");

            //A generic linked list that sends in the type that we would like to use
            //This one will behave exactly like the one used above since it is taking a
            //string.
            GenericLinkedList<string> myGenericLinkedList = new GenericLinkedList<string>();

            //Some other linked lists that can use the generic one. One of them is of type
            //integer, and the other is of type Object
            GenericLinkedList<int> myOtherGenericLinkedLIst = new GenericLinkedList<int>();
            GenericLinkedList<Object> myObjectGenericLinkedList = new GenericLinkedList<object>();

            //Use the generic string one to do the same work as above
            //Add a bunch of stuff to it
            myGenericLinkedList.Add("first");
            myGenericLinkedList.Add("second");
            myGenericLinkedList.Add("third");
            myGenericLinkedList.Add("fourth");

            //Loop through with this differently looking for loop to output
            //In here, the first part is initalization: Setting x to the Head
            //the second part is the test: If x != null, keep going
            //The last part is: Set the current x to x's next porinter. (The next in the list)
            for (GenericNode<string> x = myGenericLinkedList.Head; x != null; x = x.Next)
            {
                Console.WriteLine(x.Data);
            }




        }
    }
}
