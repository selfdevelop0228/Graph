using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph.Sample.Interface
{
    public class Node<T>
    {
        private T data; //数据域
        //构造器
        public Node(T v)
        {
            data = v;
        }
        //数据域属性
        public T Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }
    }
}
