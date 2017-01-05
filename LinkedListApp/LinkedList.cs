using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListApp {
    public class LinkedList<T> : IDisposable where T : class, IDisposable {

        #region Instance Variables

        public Node<T> Head { get; private set; }
        private Node<T> tail;
        public int Count { get; private set; }

        #endregion

        #region Constrcutor

        public LinkedList() {
            tail = Head;
        }

        #endregion

        #region Public Methods

        public void Add(T element) {
            Node<T> node = new Node<T>();
            node.Value = element;
            node.Next = null;

            if (tail == null) {
                Head = tail = node;
            } else {
                tail.Next = node;
                tail = node;
            }
            Count++;
        }

        public void InsertAt(int index, T element) {
            if (index > Count) {
                throw new IndexOutOfRangeException(
                    string.Format(Properties.Resources.IndexOutOfRangeMessage, index)
                    );
            }

            Node<T> node = new Node<T>();
            node.Value = element;

            Node<T> temp = Head;
            if (index == 0) {
                node.Next = Head;
                Head = node;
            } else if (index == Count) {
                Add(element);
            } else {
                temp = FindNodeAtIndex(index - 1, temp);
                node.Next = temp.Next;
                temp.Next = node;
            }
            Count++;
        }

        public void Remove(T element) {

        }

        public void RemoveAt(int index) {
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

        public int GetItemFromTail(int index) {
            throw new NotImplementedException();
        }

        public int FindItemFromTop(T value) {
            throw new NotImplementedException();
        }

        public int FindItemFromTail(T value) {
            throw new NotImplementedException();
        }

        public void Sort() {
            throw new NotImplementedException();
        }

        public void Reverse() {
        }

        public void ReomveLoop() {
        }

        public void PrintList() {
            Node<T> temp = Head;
            while (temp != null) {
                Console.Write(temp.Value);
                temp = temp.Next;
            }
        }

        #endregion

        #region Private Methods

        private Node<T> FindNodeAtIndex(int index, Node<T> temp) {
            while (index > 0 && temp != null) {
                temp = temp.Next;
                index--;
            }
            return temp;
        }

        #endregion

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing) {
            if (!disposedValue) {
                if (disposing) {
                    Node<T> temp = Head;
                    Console.WriteLine("-------------------------");
                    while (temp != null) {
                        temp = Head.Next;
                        Console.WriteLine("Releasing : " + Head.Value);
                        Free(Head);
                        Head = temp;

                    }
                }
                disposedValue = true;
            }
        }

        private void Free(Node<T> head) {
            head.Dispose();
        }

        public void Dispose() {
            Dispose(true);
        }
        #endregion
    }
}