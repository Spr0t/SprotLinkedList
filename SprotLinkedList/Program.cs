using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprotLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var List = new Model.LinkedList<int>();
            List.Add(1);
            List.Add(2);    
            List.Add(3);
            List.Add(4);
            List.Add(5);
            foreach (var item in List)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            List.Delete(3);
            List.Delete(7);
            List.Delete(1);

            foreach (var item in List)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }
    }
}
