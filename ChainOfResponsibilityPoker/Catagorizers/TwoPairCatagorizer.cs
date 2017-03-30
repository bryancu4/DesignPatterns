using System.Collections.Generic;
using ChainOfResponsibilityPoker.Enums;

namespace ChainOfResponsibilityPoker.Catagorizers
{
    class TwoPairCatagorizer : HandCatagorizer
    {
        public override HandRanking Catagorize(Hand hand)
        {
            Dictionary<Value, int> seen = new Dictionary<Value, int>();

            foreach (Card c in hand.Cards)
            {
                if (seen.ContainsKey(c.Value))
                {
                    seen[c.Value]++;
                }
                else
                {
                    seen[c.Value] = 1;
                }
            }

            if (seen.Count == 3)
            {
                int twoSeen = 0;
                int oneSeen = 0;
                foreach (int val in seen.Values)
                {
                    switch (val)
                    {
                        case 1:
                            oneSeen++;
                            break;
                        case 2:
                            twoSeen++;
                            break;
                        default:
                            break;
                    }
                }

                if (oneSeen == 1 && twoSeen == 2)
                {
                    return HandRanking.TwoPair;
                }
            }

            return Next.Catagorize(hand);
        }
    }
}