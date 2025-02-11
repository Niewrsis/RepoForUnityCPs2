namespace HotdogSystem.Types
{
    public class ClassicHotdog : Hotdog
    {
        public ClassicHotdog() : base("Хот-дог классический") { }

        public override string GetName()
        {
            return name;
        }
        public override int GetCost()
        {
            return 210;
        }
    }
}
