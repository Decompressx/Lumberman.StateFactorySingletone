using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern2
{
    public class ForestTransportingState : State
    {
        private static State uniqueForestTransportingState;

        public static State getInstance
        {
            get
            {
                if (uniqueForestTransportingState == null)
                    uniqueForestTransportingState = new ForestTransportingState();
                return uniqueForestTransportingState;
            }
        }

        private ForestTransportingState()
        {

        }

        public override string Talk()
        {
            return "Люди нередко интересуются, где я черпаю вдохновение.Мой секрет прост — я с детства немножко дебил.";
        }

        public override State ChangeState()
        {
            return ForestSaleState.getInstance;
        }
    }
}
