using System;
using System.Collections.Generic;

namespace ReverseLinkedList
{
    public class LinkedList
    {
        public Node Head;

        public LinkedList()
        {
        }

        public LinkedList(List<int> vals)
        {
            vals.ForEach(v => Add(v));
        }

        public void Add(int val)
        {
            if (Head == null)
            {
                Head = new Node(val);
            }
            else
            {
                Node cur = Head;
                while (cur.Next != null) { cur = cur.Next; }
                cur.Next = new Node(val);
            }
        }

        public void Print(Action<string> channel)
        {
            Node cur = Head;
            while (cur != null)
            {
                channel(cur.Val.ToString());
                cur = cur.Next;
            }
            channel("end");
        }

        public List<int> GetValues()
        {
            var vals = new List<int>();
            Node cur = Head;
            while (cur != null)
            {
                vals.Add(cur.Val);
                cur = cur.Next;
            }
            return vals;
        }

        public LinkedList Reverse()
        {
            Node cur = Head;
            Node prev = null;
            Node next = null;

            while (cur != null)
            {
                // Ensure got temp pointer to "next" (before changing it)
                next = cur.Next;

                // Reverse
                cur.Next = prev;

                // Advance
                prev = cur;
                cur = next;
            }

            Head = prev;
            return this;
        }
    }
}
