namespace HotdogSystem
{
    public abstract class Hotdog
    {
        protected string name;
        public Hotdog(string name)
        {
            this.name = name;
        }

        public abstract string GetName();
        public abstract int GetCost();
    }
}