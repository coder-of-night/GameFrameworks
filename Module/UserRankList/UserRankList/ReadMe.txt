///////////////
//主要功能说明//
///////////////

/*获取单链表单例对象*/
1> LinkList<T> link = LinkList<T>.GetInstance();

/*用户按成绩序插入排行榜(不会重复)*/
2> ShowRank.CalculatePosition(LinkList<T> link, T type)
