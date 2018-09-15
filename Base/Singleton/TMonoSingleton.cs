using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework
{
    public abstract class TMonoSingleton<T> : MonoSingleton, ISingleton where T : TMonoSingleton<T>
    {
        private static T        m_Instance = null;
        private static object   s_lock = new object();


        public static T S
        {
            get
            {
                if (m_Instance == null)
                {
                    lock (s_lock)
                    {
                        if (m_Instance == null)
                        {
                            m_Instance = CreateMonoSingleton<T>();
                        }
                    }
                }

                return m_Instance;
            }
        }

        public virtual void OnSingletonInit() { }

    }
}
