using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    /// <summary>
    /// 节点类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T>
    {
        /// <summary>
        /// 数据域
        /// </summary>
        private T data;

        /// <summary>
        /// 引用域
        /// </summary>
        private Node<T> next;

        /// <summary>
        /// 有数据构造器
        /// </summary>
        /// <param name="val"></param>
        public Node(T val)
        {
            data = val;
        }

        /// <summary>
        /// 无数据构造器
        /// </summary>
        public Node()
        {
            data = default(T);
            next = null;
        }

        /// <summary>
        /// 数据域属性
        /// </summary>
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

        /// <summary>
        /// 引用域属性
        /// </summary>
        public Node<T> Next
        {
            get
            {
                return next;
            }
            set
            {
                next = value;
            }
        }
    }

