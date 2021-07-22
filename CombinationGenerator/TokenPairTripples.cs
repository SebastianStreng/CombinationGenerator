using System;
using System.Collections.Generic;
using System.Text;

namespace CombinationGenerator
{
    public class TokenPairTripples
    {
        public Tokenpair tokenpair1;
        public Tokenpair tokenpair2;
        public Tokenpair tokenpair3;

        public TokenPairTripples(Tokenpair tokenpair1, Tokenpair tokenpair2, Tokenpair tokenpair3)
        {
            this.tokenpair1 = tokenpair1;
            this.tokenpair2 = tokenpair2;
            this.tokenpair3 = tokenpair3;
        }
    }


}
