namespace HotdogSystem.Decorator
{
    public class SweetOnionDecorator : HotdogDecorator
    {
        public SweetOnionDecorator(Hotdog hotdog) : base(hotdog, "сладким луком") { }

        public override int GetCost()
        {
            return hotdog.GetCost() + 30;
        }
    }
}
