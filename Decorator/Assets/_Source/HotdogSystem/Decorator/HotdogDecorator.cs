namespace HotdogSystem.Decorator
{
    public abstract class HotdogDecorator : Hotdog
    {
        protected Hotdog hotdog;
        protected string decoratorName;
        protected HotdogDecorator(Hotdog hotdog, string decoratorName) : base(hotdog.GetName())
        {
            this.hotdog = hotdog;
            this.decoratorName = decoratorName;
        }
        public override string GetName()
        {
            return hotdog.GetName() + " с " + decoratorName;
        }
        public override abstract int GetCost();
    }
}
