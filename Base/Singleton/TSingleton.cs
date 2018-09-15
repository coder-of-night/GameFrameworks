using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework
{
    public class TSingleton<T> : ISingleton where T : TSingleton<T>, new()
	{
		protected static T		m_Instance;
        protected static object s_lock = new object();

        public static T S
		{
			get
			{
				if(m_Instance == null)
				{
                    lock (s_lock)
                    {
                        if (m_Instance == null)
                        {
                            m_Instance = new T();
                            m_Instance.OnSingletonInit();
                        }
                    }
				}
				return m_Instance;
			}
		}

        public static T ResetInstance()
        {
            m_Instance = new T();
            m_Instance.OnSingletonInit();
            return m_Instance;
        }

        public virtual void OnSingletonInit()
        {
        }
	}
}
