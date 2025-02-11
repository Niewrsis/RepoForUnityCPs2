namespace HotdogSystem.Types
{
    public class MeatHotdog : Hotdog
    {
        public MeatHotdog() : base("Хот-дог мясной") { }

        public override string GetName()
        {
            return name;
        }
        public override int GetCost()
        {
            return 330;
        }
    }
}
