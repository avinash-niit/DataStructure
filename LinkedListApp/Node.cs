using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListApp
{
    public class Node<T> where T : class 
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
    }
}
