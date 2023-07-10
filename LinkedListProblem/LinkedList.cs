using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    public class LinkedList
    {
        public Node Head;
        public void Add(int Data)
        {
            Node node = new Node(Data);
            if(this.Head == null)
            {
                this.Head = node;   
            }
            else
            {
                Node temp = Head;
                while(temp.Next != null)
                {
                    temp = temp.Next;   
                }
                temp.Next = node;
            }
            Console.WriteLine($"{node.Data} inserted Into LinkedList");
        }
    }
}
