using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListApp {

    class Program {
        static void Main(string[] args) {

            using (LinkedList<Project> projects = new LinkedList<Project>()) {
                projects.Add(new Project { Id = 1, Name = "A" });
                projects.Add(new Project { Id = 2, Name = "B" });
                projects.Add(new Project { Id = 4, Name = "D" });
                projects.Add(new Project { Id = 5, Name = "E" });
                try {
                    projects.InsertAt(5, new Project { Id = 3, Name = "C" });
                } catch { }
                projects.InsertAt(0, new Project { Id = 6, Name = "Z" });
                projects.PrintList();
            }
            Console.ReadLine();
        }
    }
}
