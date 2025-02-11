namespace HotdogSystem.Decorator
{
    public class PickledCucumberDecorator : HotdogDecorator
    {
        public PickledCucumberDecorator(Hotdog hotdog) : base(hotdog, "маринованными огурцами") { }

        public override int GetCost()
        {
            return hotdog.GetCost() + 50;
        }
    }
}
