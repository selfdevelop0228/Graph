using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph.Sample.Interface
{
    public interface IGraph<T>
    {
        //获取顶点数
        int GetNumOfVertex();
        //获取边或弧的数目
        int GetNumOfEdge();
        //在两个顶点之间添加权为v的边或弧
        void SetEdge(LinkedListNode<T> v1, LinkedListNode<T> v2, int v);
        //删除两个顶点之间的边或弧
        void DelEdge(LinkedListNode<T> v1, LinkedListNode<T> v2);
        //判断两个顶点之间是否有边或弧
        bool IsEdge(LinkedListNode<T> v1, LinkedListNode<T> v2);
    }
}
