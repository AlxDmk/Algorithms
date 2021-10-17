using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Lesson_5
{ 
    public class Node : IComparable

    {
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int data)
        {
            Data = data;
        }

        public Node(int data, Node left, Node right)
        {
            Data = data;
            Left = left;
            Right = right;
        }

        public int CompareTo(object obj)
        {
            if (obj is Node item)
            {
                return Data.CompareTo(item);
            }
            else
            {
                throw new Exception(" Не соответствует нужному типу");
            }
        }

        public int CompareTo(int data)
        {
            return Data.CompareTo(data);
        }

        public void Add(int data)
        {
            var note = new Node(data);
            if (data < Data)
            {
                if (Left == null)
                {
                    Left = note;
                }
                else
                {
                    Left.Add(data);
                }
            }
            else
            {
                if (Right == null)
                {
                    Right = note;
                }
                else
                {
                    Right.Add(data);
                }
            }
        }
    }
}
