using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    /// <summary>
    /// 用户实体类
    /// </summary>
    public class User
    {
        public string name;
        public float time;
       
        public User(string name, float time)
        {
            this.name = name;
            this.time = time;
        }
    }

