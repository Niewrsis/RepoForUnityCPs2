namespace HotdogSystem2
{
    public class Hotdog : AHotdogBase
    {
        public Hotdog(string name, int cost, int weigth) : base(name, cost, weigth) { }
        public override string GetName()
        {
            return name;
        }
        public override int GetCost()
        {
            return cost;
        }
        public override int GetWeigth()
        {
            return weigth;
        }
    }
}