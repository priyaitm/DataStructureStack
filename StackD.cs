using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure11
{
    internal class StackD
    {
        public Node top;

        public bool IsEmpty()
        {
            return top != null;
        }
        


        public void Push(int data)
        {
            
            Node node = new Node(data);
            if (IsEmpty())
            {
                top = node;
                return;
            }
            node.next = top;
            top = node;
        }
        public int Pop()
        {
            if (top == null)
            {
                return -1;
            }
             int data = top.data;
                top =top.next;
                return data;
            
           
        }
        public int Peek()
        {
            if (top != null)
            {
                return top.data;
            }
            return -1;
        }
        

    }

    
    }
