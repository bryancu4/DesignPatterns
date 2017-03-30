using ChainOfResponsibilityPoker.Enums;

namespace ChainOfResponsibilityPoker.Catagorizers
{
    class StraightFlushCatagorizer : HandCatagorizer
    {
        public override HandRanking Catagorize(Hand hand)
        {
            if (HasFlush(hand) && HasStraight(hand))
            {
                return HandRanking.StraightFlush;
            }

            return Next.Catagorize(hand);
        }
    }
}