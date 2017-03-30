using ChainOfResponsibilityPoker.Enums;

namespace ChainOfResponsibilityPoker.Catagorizers
{
    class StraightCatagorizer : HandCatagorizer
    {
        public override HandRanking Catagorize(Hand hand)
        {
            if (HasStraight(hand))
            {
                return HandRanking.Straight;
            }

            return Next.Catagorize(hand);
        }
    }
}