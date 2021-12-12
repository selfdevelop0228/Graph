using System;
using Graph.Common;
namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[,] some1 = new int[4,2] { { 1, 3 }, { 2, 4 }, { 5, 3 }, { 4, 3 } };
            // value estimated {[1,3],[3,2],[2,1]} output = -1
           // Test();
            int[][] some = new int[5][] { new int[2] { 1, 2 }, new int[2] { 3, 2 }, new int[2] { 4, 2 }, new int[2] { 5, 2 }, new int[2] { 6, 2 } };

            //int[][] some2 = new int[5][] { new int[2] { 1, 3 }, new int[2] { 1, 4 }, new int[2] { 2, 3 }, new int[2] { 4, 3 },new int[2] { 5, 4 } };
           var result1= Q997EasyTownJudge.FindJudge(6, some);
           // var result2 = Q997EasyTownJudge.FindJudge(5, some2);

            Console.WriteLine("Question 997 Easy Town Judge");
            Console.WriteLine(result1);
          //  Console.WriteLine(result2);


            Console.WriteLine("Question 1791 Find Center");
            int[][] edges = new int[4][] { new int[2] { 1, 3 }, new int[2] { 2, 3 }, new int[2] { 4, 3 }, new int[2] { 5,3} };

            var centerResult= Q1791FindCenter.FindCenter(edges);
            Console.WriteLine(centerResult);

            Console.WriteLine("Question 1971 Find If Path Exits In Graph");
            //int[][] edges1971 = new int[3][] { new int[2] { 0, 1 }, new int[2] { 1, 2 }, new int[2] { 2, 0 } };
            //int[][] edges1971 = new int[5][] { new int[2] { 0, 1 }, new int[2] { 0, 2 }, new int[2] { 3, 5 },new int[2] { 5,4}, new int [2]{ 4,3} };
            //int[][] edges1971 = new int[1][] { new int[2] { 0, 0 } };
            int[][] edges1971 = new int[][] {  };
            int vector = 6;
            int start = 0;
            int end = 5;
            //bool Q1971Result=Q1971FindIfPathExistsInGraphQuestion.FindPathExistsInGraph(1,edges1971,0,0);
            //Console.WriteLine(Q1971Result);
            //Console.ReadLine();
        }

        public static void Test()
        {

            ListGraph graph = new ListGraph(5);
     
            graph.AddEdges(0, 1);
           // graph.RemoveEdges(0, 1);
            graph.AddEdges(0, 2);
            graph.AddEdges(1, 0);
            graph.AddEdges(1, 3);
            graph.AddEdges(1, 4);
            graph.AddEdges(2, 0);
            graph.AddEdges(2, 3);
            graph.AddEdges(3, 1);
            graph.AddEdges(3, 2);
            graph.AddEdges(3, 4);
            graph.AddEdges(4, 1);
            graph.AddEdges(4, 3);

            foreach(var data in graph.graphs)
            {
                Console.WriteLine(data);
            }
        }
    }
}
