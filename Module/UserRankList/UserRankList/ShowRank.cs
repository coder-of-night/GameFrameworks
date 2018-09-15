using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    /// <summary>
    /// 包含遍历与按序插入
    /// </summary>
    public static class ShowRank
    {
        /// <summary>
        /// 遍历
        /// </summary>
        /// <param name="link">单链表对象</param>
        public static void Put(LinkList<User> link)
        {
            Node<User> n = link.Head;
            while (n != null)
            {
                Console.WriteLine(link.GetIndexByUser(n.Data) + "  " + n.Data.name + "  " + n.Data.time);
                n = n.Next;
            }
        }

        /// <summary>
        /// 用户按成绩序插入排行榜(不会重复)
        /// </summary>
        /// <param name="link">单链表对象</param>
        /// <param name="user">用户对象</param>
        public static void CalculatePosition(LinkList<User> link, User user)
        {
            link.Delete(link.GetIndexByUser(user));
            int i = 1;
            while (true)
            {
                 
                if (link.GetUserByIndex(i) == null)
                {
                    link.Insert(user, i);
                    Console.WriteLine("表长" + link.GetLength() + "\n");
                    break;
                }

               
                if (user.time <= link.GetUserByIndex(i).time)
                {
                    link.Insert(user, i);
                    Console.WriteLine("表长" + link.GetLength() + "\n");
                    break;
                }
                else
                {
                    i++;
                }

            }
        }

    }

