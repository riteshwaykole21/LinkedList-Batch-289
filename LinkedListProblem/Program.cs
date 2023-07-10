using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List Data Structure");
            LinkedList linkedList = new LinkedList();
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("1 : Add Data");
                int Option = Convert.ToInt32(Console.ReadLine());
                switch(Option)
                {
                    case 1:
                        linkedList.Add(30);
                        linkedList.Add(56);
                        linkedList.Add(70);
                        break;
                }
            }
        }
    }
}
