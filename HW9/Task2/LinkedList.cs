using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class LinkedList<T>: IEnumerable<T>, IComparable<T>
    {
        private Node<T> _head;
        private Node<T> _tail;
        private int _length;

        public int Count { get; set; }

        public LinkedList(int length)
        {
            if (length <= 0)
            {
                throw new LinkedListException("Вы пытаетесь ввести отрицательное или нулевое значение.");
            }

            _length = length;
            Count = 0;
        }

        public void Add(T element)
        {
            if (Count >= _length)
            {
                throw new LinkedListException("Список полон.");
            }

            Node<T> newNode = new Node<T>(element);

            if (_head == null)
            {
                _head = newNode;
            }
            else
            {
                _tail.NextNode = newNode;
            }

            _tail = newNode;
            Count++;
        }

        public void Insert(T element, int index)
        {
            if (Count >= _length)
            {
                throw new LinkedListException("Список полон.");
            }

            if (index >= _length)
            {
                throw new LinkedListException("Значение индекса больше длины коллекции.");
            }

            if (index < 0)
            {
                throw new LinkedListException("Индекс меньше длины коллекции.");
            }

            Node<T> newNode;

            if (index == 0)
            {
                newNode = new Node<T>(element);
                newNode.NextNode = _head;
                _head = newNode;
            }
            else
            {
                newNode = _head;
                int currentIndex = 0;
                while (true)
                {
                    if (currentIndex == index - 1)
                    {
                        var temp = newNode.NextNode;
                        newNode.NextNode = new Node<T>(element);
                        newNode.NextNode.NextNode = temp;
                        break;
                    }

                    newNode = newNode.NextNode;
                    currentIndex++;
                }
            }

            Count++;
        }

        public void Remove(T element)
        {
            if (Count == 0)
            {
                throw new LinkedListException("Список пуст.");
            }

            if (element == null)
            {
                throw new LinkedListException("Вы ничего не передали.");
            }

            Node<T> currentNode = _head;
            Node<T> previousNode = null;

            while (currentNode != null)
            {
                if (currentNode.Value.Equals(element))
                {
                    if (previousNode != null)
                    {
                        previousNode.NextNode = currentNode.NextNode;

                        if (currentNode.NextNode == null)
                        {
                            _tail = previousNode;
                        }
                    }
                    else
                    {
                        _head = _head.NextNode;

                        if (_head == null)
                        {
                            _tail = null;
                        }
                    }

                    Count--;
                }

                previousNode = currentNode;
                currentNode = currentNode.NextNode;
            }
        }

        public void RemoveAt(int index)
        {
            if (index >= _length)
            {
                throw new LinkedListException("Значение индекса больше длины коллекции.");
            }

            if (index < 0)
            {
                throw new LinkedListException("Индекс меньше длины коллекции.");
            }

            if (index == 0)
            {
                _head = _head.NextNode;
            }
            else
            {
                Node<T> currentNode = _head;
                int currentIndex = 0;

                while (true)
                {
                    if (currentIndex == index - 1)
                    {
                        currentNode.NextNode = currentNode.NextNode.NextNode;
                        break;
                    }

                    currentNode = currentNode.NextNode;
                    currentIndex++;
                }
            }

            Count--;
        }

        public int IndexOf(T element)
        {
            if (element == null)
            {
                throw new LinkedListException("Вы ничего не передали.");
            }

            Node<T> currentNode = _head;
            int currentIndex = 0;
            while (true)
            {
                if (currentIndex <= _length)
                {
                    if (currentNode.Value.Equals(element))
                    {
                        return currentIndex;
                    }

                    currentNode = currentNode.NextNode;
                    currentIndex++;
                }
                else
                {
                    return -1;
                }
            }
        }

        public bool Contains(T element)
        {
            if (element == null)
            {
                throw new LinkedListException("Вы ничего не передали.");
            }

            Node<T> currentNode = _head;

            while (true)
            {
                if (currentNode != null)
                {
                    if (currentNode.Value.Equals(element))
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }

                currentNode = currentNode.NextNode;
            }
        }

        public void Clear()
        {
            _head = null;
            _tail = null;
            Count = 0;
        }

        public int CompareTo(T other)
        {
            //if (this._length > other._length)
            //    return 1;
            //if (this._length < other._length)
            //    return -1;
            //else
                return 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> currentNode = _head;
            while (currentNode != null)
            {
                yield return currentNode.Value;
                currentNode = currentNode.NextNode;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
