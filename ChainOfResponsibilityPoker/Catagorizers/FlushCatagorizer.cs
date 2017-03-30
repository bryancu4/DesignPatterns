using ChainOfResponsibilityPoker.Enums;

namespace ChainOfResponsibilityPoker.Catagorizers
{
    class FlushCatagorizer : HandCatagorizer
    {
        public override HandRanking Catagorize(Hand hand)
        {
            if (HasFlush(hand))
            {
                return HandRanking.Flush;
            }

            return Next.Catagorize(hand);
        }
    }
}