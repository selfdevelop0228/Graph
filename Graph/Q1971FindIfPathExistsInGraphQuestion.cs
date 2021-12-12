using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Graph.Common;
namespace Graph
{
    //    There is a bi-directional graph with n vertices, where each vertex is labeled from 0 to n - 1 (inclusive). The edges in the graph are represented as a 2D integer array edges, where each edges[i] = [ui, vi] denotes a bi-directional edge between vertex ui and vertex vi.Every vertex pair is connected by at most one edge, and no vertex has an edge to itself.

    //You want to determine if there is a valid path that exists from vertex start to vertex end.

    //Given edges and the integers n, start, and end, return true if there is a valid path from start to end, or false otherwise.
    public class Q1971FindIfPathExistsInGraphQuestion
    {
        // [[0,1],[0,2],[3,5],[5,4],[4,3]]
        //public static bool FindPathExistsInGraph(int n, int[][] edges, int start, int end)
        //{
        //    //N=vector [0,1,2,3,4,5]
        //    //Edges=[0,1],[0,2],[3,5],[5,4],[4,3]
        //    bool[] isConnected = new bool[n];

        //    if ( edges == new int[0][] { })
        //    {
        //        return true;
        //    }
        //    foreach (int [] data in edges)
        //    {

        //        if (isConnected[data[0]] == true || isConnected[data[1]] == true)
        //        {
        //            isConnected[data[0]] = true;
        //            isConnected[data[1]] = true;
        //        }

        //        if (data[0] == start || data[1]==start)
        //        {
        //            isConnected[data[0]] = true;
        //            isConnected[data[1]] = true;
        //        }
        //    }

        //    if(isConnected[start] == true && isConnected[end]==true)
        //    {
        //        return true;
        //    }


        //    return false;
        //}


        public static bool FindPathExistsInGraph(int n, int[][] edges, int start, int end)
        {
            ListGraph graph = new ListGraph(n);

            for (int i = 0; i < edges.Length; i++)
            {
                graph.AddEdges(edges[0][0], edges[0][1]);
            }

            foreach (var data in graph.graphs)
            {
               for(int i =0; i<data.Count;i++)
                {
                    if (data[i]==  start || data[i]== end)
                    {
                        
                    }
                }
            }

        }
    }
}
