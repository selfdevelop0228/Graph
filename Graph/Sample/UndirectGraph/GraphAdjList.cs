using Graph.Sample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph.Sample.UndirectGraph
{
    /// <summary>
    /// 无向图邻接表类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <summary>
    /// 无向图邻接表类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GraphAdjList<T> : IGraph<T>
    {
        //邻接表数组
        private VexNode<T>[] adjList;

        //记录图中所有顶点的访问情况
        private int[] visited;

        //索引器
        public VexNode<T> this[int index]
        {
            get
            {
                return adjList[index];
            }
            set
            {
                adjList[index] = value;
            }
        }

        //构造器
        public GraphAdjList(Node<T>[] nodes)
        {
            adjList = new VexNode<T>[nodes.Length];
            for (int i = 0; i < nodes.Length; ++i)
            {
                adjList[i].Data = nodes[i];
                adjList[i].FirstAdj = null;
            }

            visited = new int[adjList.Length];
            for (int i = 0; i < visited.Length; ++i)
            {
                visited[i] = 0;
            }
        }

        //获取顶点的数目
        public int GetNumOfVertex()
        {
            return adjList.Length;
        }

        //获取边的数目
        public int GetNumOfEdge()
        {
            int i = 0;

            foreach (VexNode<T> nd in adjList)
            {
                adjListNode<T> p = nd.FirstAdj;
                while (p != null)
                {
                    ++i;
                    p = p.Next;
                }
            }

            return i / 2;//无向图
        }

        //判断v是否是图的顶点
        public bool IsNode(Node<T> v)
        {
            //遍历邻接表数组
            foreach (VexNode<T> nd in adjList)
            {
                //如果v等于nd的data，则v是图中的顶点，返回true
                if (v.Equals(nd.Data))
                {
                    return true;
                }
            }
            return false;
        }

        //获取顶点v在邻接表数组中的索引
        public int GetIndex(Node<T> v)
        {
            int i = -1;
            //遍历邻接表数组
            for (i = 0; i < adjList.Length; ++i)
            {
                //邻接表数组第i项的data值等于v，则顶点v的索引为i
                if (adjList[i].Data.Equals(v))
                {
                    return i;
                }
            }
            return i;
        }

        //判断v1和v2之间是否存在边
        public bool IsEdge(Node<T> v1, Node<T> v2)
        {
            //v1或v2不是图的顶点
            if (!IsNode(v1) || !IsNode(v2))
            {
                Console.WriteLine("Node is not belong to Graph!");
                return false;
            }
            adjListNode<T> p = adjList[GetIndex(v1)].FirstAdj;
            while (p != null)
            {
                if (p.Adjvex == GetIndex(v2))
                {
                    return true;
                }

                p = p.Next;
            }

            return false;
        }

        //在顶点v1和v2之间添加权值为v的边
        public void SetEdge(Node<T> v1, Node<T> v2, int v)
        {
            //v1或v2不是图的顶点或者v1和v2之间存在边
            if (!IsNode(v1) || !IsNode(v2) || IsEdge(v1, v2))
            {
                Console.WriteLine("Node is not belong to Graph!");
                return;
            }

            //权值不对
            if (v != 1)
            {
                Console.WriteLine("Weight is not right!");
                return;
            }

            //处理顶点v1的邻接表
            adjListNode<T> p = new adjListNode<T>(GetIndex(v2));

            if (adjList[GetIndex(v1)].FirstAdj == null)
            {
                adjList[GetIndex(v1)].FirstAdj = p;
            }
            //顶点v1有邻接顶点
            else
            {
                p.Next = adjList[GetIndex(v1)].FirstAdj;
                adjList[GetIndex(v1)].FirstAdj = p;
            }

            //处理顶点v2的邻接表
            p = new adjListNode<T>(GetIndex(v1));

            //顶点v2没有邻接顶点
            if (adjList[GetIndex(v2)].FirstAdj == null)
            {
                adjList[GetIndex(v2)].FirstAdj = p;
            }

            //顶点v2有邻接顶点
            else
            {
                p.Next = adjList[GetIndex(v2)].FirstAdj;
                adjList[GetIndex(v2)].FirstAdj = p;
            }
        }

        //删除顶点v1和v2之间的边
        public void DelEdge(Node<T> v1, Node<T> v2)
        {
            //v1或v2不是图的顶点
            if (!IsNode(v1) || !IsNode(v2))
            {
                Console.WriteLine("Node is not belong to Graph!");
                return;
            }

            //顶点v1与v2之间有边
            if (IsEdge(v1, v2))
            {
                //处理顶点v1的邻接表中的顶点v2的邻接表结点
                adjListNode<T> p = adjList[GetIndex(v1)].FirstAdj;
                adjListNode<T> pre = null;

                while (p != null)
                {
                    if (p.Adjvex != GetIndex(v2))
                    {
                        pre = p;
                        p = p.Next;
                    }
                }
                pre.Next = p.Next;

                //处理顶点v2的邻接表中的顶点v1的邻接表结点
                p = adjList[GetIndex(v2)].FirstAdj;
                pre = null;

                while (p != null)
                {
                    if (p.Adjvex != GetIndex(v1))
                    {
                        pre = p;
                        p = p.Next;
                    }
                }
                pre.Next = p.Next;
            }
        }

        //无向图的深度优先遍历算法的实现
        public void DFS()
        {
            for (int i = 0; i < visited.Length; ++i)
            {
                if (visited[i] == 0)
                {
                    DFSAL(i);
                }
            }
        }

        //从某个顶点出发进行深度优先遍历
        public void DFSAL(int i)
        {
            visited[i] = 1;
            adjListNode<T> p = adjList[i].FirstAdj;
            while (p != null)
            {
                if (visited[p.Adjvex] == 0)
                {
                    DFSAL(p.Adjvex);
                }
                p = p.Next;
            }

        }

        public void SetEdge(LinkedListNode<T> v1, LinkedListNode<T> v2, int v)
        {
            throw new NotImplementedException();
        }

        public void DelEdge(LinkedListNode<T> v1, LinkedListNode<T> v2)
        {
            throw new NotImplementedException();
        }

        public bool IsEdge(LinkedListNode<T> v1, LinkedListNode<T> v2)
        {
            throw new NotImplementedException();
        }
    }
}
