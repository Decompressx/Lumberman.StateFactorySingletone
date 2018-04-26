using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern2
{
    public class ComebackState : State
    {
        private static State uniqueComebackState;

        public static State getInstance
        {
            get
            {
                if (uniqueComebackState == null)
                    uniqueComebackState = new ComebackState();
                return uniqueComebackState;
            }
        }

        private ComebackState()
        {

        }

        public override string Talk()
        {
            return null;
        }

        public override State ChangeState()
        {
            return WorkState.getInstance;
        }
    }
}
