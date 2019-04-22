using System;
using System.Collections.Generic;

namespace DJD.Collections.Generic
{
    public class LinkedList<T>
    {
        private Node<T> nodes;
        private int _count;

        #region Properties
        public int Count
        {
            get { return _count; }
        }

        public bool IsEmpty
        {
            get { return _count <= 0; }
        }

        public IEnumerable<T> Items
        {
            get
            {
                Node<T> tmp = nodes;

                while (tmp.nextNode != null)
                {
                    yield return tmp.nodeValue;
                    tmp = tmp.nextNode;
                }
            }
        }
        #endregion

        #region Constructors
        public LinkedList()
        {
            _count = 0;
        }
        #endregion

        #region Public Methods
        public void Add(T item)
        {
            _count++;

            if (IsEmpty)
            {
                nodes = new Node<T>(item, null);
                return;
            }

            AddItem(item);
        }
        #endregion

        #region Private Methods
        private void AddItem(T item)
        {
            Node<T> tmp = nodes;

            while (tmp.nextNode != null)
            {
                tmp = tmp.nextNode;
            }

            tmp.nextNode = new Node<T>(item, null);
        }
        #endregion

        #region NestedClasses
        private class Node<Type>
        {
            public Type nodeValue;
            public Node<Type> nextNode;

            public Node(Type item, Node<Type> nextNode)
            {
                nodeValue = item;
                this.nextNode = nextNode;
            }
        }
        #endregion
    }
}
