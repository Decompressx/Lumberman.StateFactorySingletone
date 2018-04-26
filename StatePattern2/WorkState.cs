using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern2
{
    public class WorkState : State
    {
        int count = 4;

        private static State uniqueWorkState;

        public static State getInstance
        {
            get
            {
                if (uniqueWorkState == null)
                     uniqueWorkState = new WorkState();
                return uniqueWorkState;
            }
        }

        private WorkState() {}

        public override string Talk()
        {
            if (count < 1)
                return "Дровосек нападает";
            else
            {
                count--;
                return "Отойди, мрггрлмгрмрлг!!!!!";
            }
        }

        public override State ChangeState()
        {
            return ForestTransportingState.getInstance;
        }
    }
}
