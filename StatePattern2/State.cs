using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern2
{
    public abstract class State
    {
        public abstract string Talk();
        public abstract State ChangeState();
        
    }
}
