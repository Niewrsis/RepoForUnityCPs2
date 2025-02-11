namespace HotdogSystem2
{
    public abstract class HotdogDecorator : AHotdogBase
    {
        protected Hotdog hotdog;
        protected string decoratorName;
        protected HotdogDecorator(Hotdog hotdog, string decoratorName) : base(hotdog.GetName(), hotdog.GetCost(), hotdog.GetWeigth())
        {
            this.hotdog = hotdog;
            this.decoratorName = decoratorName;
        }
        public override string GetName()
        {
            return hotdog.GetName();
        }
        public override abstract int GetCost();
        public abstract override int GetWeigth();
    }
}
