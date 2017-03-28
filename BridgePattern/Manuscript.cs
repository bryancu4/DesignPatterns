namespace BridgePattern
{
    public abstract class Manuscript
    {
        protected readonly IFormatter Formatter;

        protected Manuscript(IFormatter formatter)
        {
            this.Formatter = formatter;
        }

        public abstract void Print();
    }
}