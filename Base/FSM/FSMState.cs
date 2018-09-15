using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework
{
    public class FSMState<T>
    {
        public virtual string stateName
        {
            get { return this.GetType().Name; }
        }

        public virtual void Enter(T entity)
        {

        }

        public virtual void Execute(T entity, float dt)
        {

        }

        public virtual void Exit(T entity)
        {

        }

        public virtual void OnMsg(T entity, int key, params object[] args)
        {

        }
    }

}
