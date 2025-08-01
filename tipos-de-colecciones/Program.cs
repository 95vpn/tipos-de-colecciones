using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipos_de_colecciones
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(1);
            numbers.Remove(1);

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            */

            /*
            Hashtable numbers = new Hashtable();
            numbers.Add(1, "1a");
            numbers.Add(2, "2");
            numbers.Add(3, "3");
            numbers.Add(4, "4");

            foreach (var i in numbers.Values)
            {
                Console.WriteLine(i);
            }
            */

            /*
            Dictionary<int, string> numbers = new Dictionary<int, string>();
            numbers.Add(1, "1a");
            numbers.Add(2, "2");
            numbers.Add(3, "3");
            numbers.Add(4, "4");

            foreach (var i in numbers.Values)
            {
                Console.WriteLine(i);
            }
            */

            /*
            Queue<int> numbers = new Queue<int>();
            numbers.Enqueue(1);
            numbers.Enqueue(2);
            numbers.Enqueue(3);
            numbers.Enqueue(4);
            numbers.Dequeue();
            numbers.Dequeue();

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            */

            Stack<int> numbers = new Stack<int>();
            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);
            numbers.Push(4);
            int last = numbers.Pop(); 

            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
