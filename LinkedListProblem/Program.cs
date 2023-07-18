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
            Console.WriteLine("1.Add");
            Console.WriteLine("2.AddFirst");
            Console.WriteLine("3.AddLast");
            Console.WriteLine("4.Display");
            Console.Write("Enter The Option:");
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
                    case 2:
                        linkedList.ReversOrder(70);
                        linkedList.ReversOrder(30);
                        linkedList.ReversOrder(56);
                        break;
                    case 3:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        break;
                    case 4:
                        linkedList.Display();
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
