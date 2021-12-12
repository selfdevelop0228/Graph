using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    //    There is an undirected star graph consisting of n LinkedListNodes labeled from 1 to n.A star graph is a graph where there is one center LinkedListNode and exactly n - 1 edges that connect the center LinkedListNode with every other LinkedListNode.

    //You are given a 2D integer array edges where each edges[i] = [ui, vi] indicates that there is an edge between the LinkedListNodes ui and vi. Return the center of the given star graph.
    public class Q1791FindCenter
    {
        public static int FindCenter(int[][] edges)
        {
            int[] count = new int[edges.Length + 2];

            foreach (int[] data in edges)
            {
                count[data[0]]++;
                count[data[1]]++;
            }

            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] == edges.Length)
                {
                    return i;
                }
            }
            return -1;
        }

    }
}
