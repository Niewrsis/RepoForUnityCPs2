namespace HotdogSystem.Types
{
    public class CeaserHotdog : Hotdog
    {
        public CeaserHotdog() : base("Хот-дог Цезарь") { }

        public override string GetName()
        {
            return name;
        }
        public override int GetCost()
        {
            return 290;
        }
    }
}
