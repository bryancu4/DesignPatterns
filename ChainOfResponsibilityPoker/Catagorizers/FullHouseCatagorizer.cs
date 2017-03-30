using System.Collections.Generic;
using ChainOfResponsibilityPoker.Enums;

namespace ChainOfResponsibilityPoker.Catagorizers
{
    class FullHouseCatagorizer : HandCatagorizer
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

            if (seen.Count == 2)
            {
                if(seen.ContainsValue(3) && seen.ContainsValue(2))
                {
                    return HandRanking.FullHouse;
                }
            }

            return Next.Catagorize(hand);
        }
    }
}