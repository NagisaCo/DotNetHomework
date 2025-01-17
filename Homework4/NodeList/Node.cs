﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeList
{
    public class Node<T>
    {
        public Node<T>? Next { get; set; }
        public T Data { get; set; }

        public Node(T data)
        {
            Next = null;
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
