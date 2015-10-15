using System;
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

            //Delete the 2nd element in the list
            myLinkedList.Delete(2);
            //Delete the new 2nd element in the list. Was 3rd before previous delete
            myLinkedList.Delete(2);

            for (Node x = myLinkedList.Head; x != null; x = x.Next)
            {
                Console.WriteLine(x.Data);
            }

        }
    }
}
