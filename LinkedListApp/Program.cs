using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (LinkedList<Project> list = new LinkedList<Project>())
            {
                list.Add(new Project { Id = 1, Name = "A" });
                list.Add(new Project { Id = 2, Name = "B" });
                list.Add(new Project { Id = 4, Name = "D" });
                list.Add(new Project { Id = 5, Name = "E" });
                try
                {
                    list.InsertAt(5, new Project { Id = 3, Name = "C" });
                }
                catch { }
                list.InsertAt(0, new Project { Id = 6, Name = "Z" });
                list.PrintList();
            }
            Console.ReadLine();
        }
    }
}
