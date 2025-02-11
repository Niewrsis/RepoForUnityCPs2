namespace HotdogSystem2
{
    public abstract class AHotdogBase
    {
        protected string name;
        protected int cost;
        protected int weigth;
        public AHotdogBase(string name, int cost, int weigth)
        {
            this.name = name;
            this.cost = cost;
            this.weigth = weigth;
        }
        public abstract string GetName();
        public abstract int GetCost();
        public abstract int GetWeigth();
    }
}