using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListApp
{
    public class LinkedList<T> where T:class
    {
        public Node<T> Head { get; private set; }

        private Node<T> tail;

        public int Count { get; private set; }

        public LinkedList(){
            tail = Head;
        }

        public void AddNode(Node<T> node) {
            node.Next = null;

            if (tail == null) {
                Head = node;
                tail = Head;
            }
            else {
                tail.Next = node;
                tail = node;
            }
            Count++;
        }

        public void InsertAt(Node<T> node, int index) {
            Node<T> temp = Head;
            for (int i = 0; i < index && temp.Next !=null; i++) {
            }
        }

        public void RemoveNode(Node<T> node){
        }

        public void RemoveAt(int index){
        }

        public bool IsCircular() {
            throw new NotImplementedException();
        }

        public bool ContainsLoop() {
            throw new NotImplementedException();
        }

        public int GetItemFromHead(int index) {
            throw new NotImplementedException();
        }

        public int GetItemFromTail(int index){
            throw new NotImplementedException();
        }

        public int FindItemFromTop(T value){
            throw new NotImplementedException();
        }

        public int FindItemFromTail(T value){
            throw new NotImplementedException();
        }

        public void Sort() {
            throw new NotImplementedException();
        }

        public void Reverse() {
        }

        public void ReomveLoop() {
        }

    }
}