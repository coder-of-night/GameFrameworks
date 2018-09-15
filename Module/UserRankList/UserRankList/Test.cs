using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Test
    {
        static void Main(string[] args)
        {
            User wanglei = new User("WangLei", 30.57f);
            User xiaoma = new User("XiaoMa", 30.58f);
            User liming = new User("LiMing", 31.62f);
            User chengliang = new User("ChengLiang", 32.67f);
            User liuxing = new User("LiuXing", 35.31f);

            LinkList<User> link = LinkList<User>.GetInstance();
        
            ShowRank.CalculatePosition(link, liuxing);
            ShowRank.CalculatePosition(link, wanglei);
            ShowRank.CalculatePosition(link, liming);
            ShowRank.CalculatePosition(link, chengliang);
            ShowRank.CalculatePosition(link, xiaoma);

            liming.time = 31.0f;
            ShowRank.CalculatePosition(link, liming);

            ShowRank.Put(link);
            Console.WriteLine();
            Console.WriteLine(xiaoma.name + "的Rank是 : " + link.GetIndexByUser(xiaoma));
            Console.WriteLine(liuxing.name + "的Rank是 : " + link.GetIndexByUser(liuxing));
            Console.WriteLine(wanglei.name + "的Rank是 : " + link.GetIndexByUser(wanglei));
            Console.WriteLine(chengliang.name + "的Rank是 : " + link.GetIndexByUser(chengliang));
            Console.WriteLine(liming.name + "的Rank是 : " + link.GetIndexByUser(liming));

            Console.WriteLine("\n删除了: " + link.Delete(link.GetIndexByUser(xiaoma)).name);
            Console.WriteLine("删除了: " + link.Delete(link.GetIndexByUser(liuxing)).name);
            Console.WriteLine("删除了: " + link.Delete(link.GetIndexByUser(wanglei)).name);
            Console.WriteLine("删除了: " + link.Delete(link.GetIndexByUser(chengliang)).name);
         //   Console.WriteLine("删除了: " + link.Delete(link.GetIndexByUser(liming)).name);

            Console.WriteLine();
            ShowRank.Put(link);

            Console.WriteLine("表长" + link.GetLength() + "\n");
            
            Console.ReadKey();
        }
    }
