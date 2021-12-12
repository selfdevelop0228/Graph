using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph.Common
{
    public class ListGraph
    {
       // ArrayList graph = new ArrayList();
        public List<List<int>> graphs;
        public ListGraph(int vector)
        {
            graphs = new List<List<int>>(vector);
            for (int i =0; i<vector;i++)
            {
                graphs.Add(new List<int>(vector));
            }
        }

        public  void  AddEdges(int edges1, int edges2)
        {
            //graphs.AddRange(List<edges1>)
            graphs.ElementAt(edges1).Add(edges2);
        }

        public void RemoveEdges(int edges1, int edges2)
        {
            graphs.ElementAt(edges1).Remove(edges2);
        }

        //public string RetirveData()
        //{
            
        //}
    }
}
