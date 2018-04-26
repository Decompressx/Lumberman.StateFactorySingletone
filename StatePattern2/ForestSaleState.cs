using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern2
{
    public class ForestSaleState : State
    {
        private static State uniqueForestSaleState;

        public static State getInstance
        {
            get
            {
                if (uniqueForestSaleState == null)
                    uniqueForestSaleState = new ForestSaleState();
                return uniqueForestSaleState;
            }
        }

        private ForestSaleState()
        {

        }

        public override string Talk()
        {
            return "Дровосек продал лес";
        }

        public override State ChangeState()
        {
            return ComebackState.getInstance;
        }
    }
}
