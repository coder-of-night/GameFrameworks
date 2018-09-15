using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework
{
    public delegate void Run();
    public delegate void Run<T>(T v);
    public delegate void Run<T, K>(T v1, K v2);
    
}
