using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    /// <summary>
    /// 单链表规范
    /// </summary>
    /// <typeparam name="T">节点类型</typeparam>
    public interface IList<T>
    {
        /// <summary>
        /// 求链表长度
        /// </summary>
        /// <returns></returns>
        int GetLength();

        /// <summary>
        /// 清空链表
        /// </summary>
        void Clear();

        /// <summary>
        /// 判空
        /// </summary>
        /// <returns></returns>
        bool IsEmpty();

        /// <summary>
        /// 在表索引位置前面插入节点
        /// </summary>
        /// <param name="user">节点数据域</param>
        /// <param name="i">索引</param>
        void Insert(T user, int i);

        /// <summary>
        /// 根据索引查询节点
        /// </summary>
        /// <param name="i">索引</param>
        /// <returns></returns>
        T GetUserByIndex(int i);

        /// <summary>
        /// 根据节点查询索引
        /// </summary>
        /// <param name="value">节点</param>
        /// <returns></returns>
        int GetIndexByUser(T user);


        ///// <summary>
        ///// 添加节点
        ///// </summary>
        ///// <param name="item">节点数据域</param>
        //void Append(T name);

        /// <summary>
        /// 删除索引位置的节点
        /// </summary>
        /// <param name="i">索引</param>
        /// <returns></returns>
        T Delete(int i);
    }

