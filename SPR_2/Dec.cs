using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SPR_2;

public class Dec<T>
{
    private Node<T> head;
    private Node<T> tail;

    public Dec()
    {
        head = null;
        tail = null;
    }

    public void PushBack(T item)
    {
        Node<T> newNode = new Node<T>(item);
        if (tail == null)
        {
            head = tail = newNode;
        }
        else
        {
            tail.Next = newNode;
            tail = newNode;
        }
    }

    public void PushFront(T item)
    {
        Node<T> newNode = new Node<T>(item);
        if (head == null)
        {
            head = tail = newNode;
        }
        else
        {
            newNode.Next = head;
            head = newNode;
        }
    }

    public T PopBack()
    {
        if (!IsEmpty())
        {
            if (head == tail)
            {
                T item = tail.Data;
                head = tail = null;
                return item;
            }

            Node<T> current = head;
            while (current.Next != tail)
            {
                current = current.Next;
            }

            T tailData = tail.Data;
            tail = current;
            tail.Next = null;
            return tailData;
        }
        else
        {
            throw new InvalidOperationException("дек пустой");
        }
    }

    public T PopFront()
    {
        if (!IsEmpty())
        {
            T item = head.Data;
            head = head.Next;
            if (head == null)
            {
                tail = null;
            }
            return item;
        }
        else
        {
            throw new InvalidOperationException("дек пустой");
        }
    }

    public T Peek()
    {
        if (!IsEmpty())
        {
            return head.Data;
        }
        else
        {
            throw new InvalidOperationException("дек пустой");
        }
    }

    public T PeekTail()
    {
        if (!IsEmpty())
        {
            return tail.Data;
        }
        else
        {
            throw new InvalidOperationException("дек пустой");
        }
    }

    public bool IsEmpty()
    {
        return head == null;
    }
}
