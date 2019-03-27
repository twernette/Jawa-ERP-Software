using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jawa_ERP_Software
{
        class GenericStack<T>
        {
            public class Node
            {
                public T Data { get; set; }
                public Node Next { get; set; }
            }

            protected Node _head;
            protected int _size;

            public bool IsEmpty
            {
                get
                {
                    return _head == null;
                }
            }

            public int Size
            {
                get
                {
                    return _size;
                }
            }

            public T Pop()
            {
                if (IsEmpty)
                {
                    throw new Exception("List is empty");
                }
                T returnData = _head.Data;
                _head = _head.Next;
                _size--;
                return returnData;
            }

            public void Push(T Data)
            {
                Node oldHead = _head;
                _head = new Node();
                _head.Data = Data;
                _head.Next = oldHead;
                _size++;
            }

        }
    }