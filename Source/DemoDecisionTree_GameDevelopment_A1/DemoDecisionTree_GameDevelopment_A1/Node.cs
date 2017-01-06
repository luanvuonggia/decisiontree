﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDecisionTree_GameDevelopment_A1
{
    public class Node
    {
        Feature features;
        Node[] childs;
        int n;
        int numberLabel;

        internal Feature Features
        {
            get { return features; }
            set { features = value; }
        }

        internal Node[] Childs
        {
            get { return childs; }
            set { childs = value; }
        }

        public int NumberLabel
        {
            get { return numberLabel; }
            set { numberLabel = value; }
        }

        public Node(Feature features)
        {
            this.Features = features;
            this.Childs = new Node[Features.Values.Count];
            n = 0;
            for (int i = 0; i < Features.Values.Count; i++)
            {
                Childs[i] = null;
            }
            if (Features.Values.Count == 0)
                NumberLabel = 1;
            else
                NumberLabel = 0;
        }

        public void AddNode(Node child)
        {
            if (n < childs.Length)
            {
                childs[n] = child;
                NumberLabel = NumberLabel + child.NumberLabel;
            }
            n++;
        }
    }
}
