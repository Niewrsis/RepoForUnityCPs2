namespace HotdogSystem2.Extras
{
    public class ExtraDecorator : HotdogDecorator
    {
        protected ExtrasSO extra;
        public ExtraDecorator(ExtrasSO extras, Hotdog hotdog) : base(hotdog, extras.Name)
        {
            extra = extras;
        }

        public override string GetName()
        {
            return base.GetName() + " c " + extra.Name;
        }
        public override int GetCost()
        {
            return hotdog.GetCost() + extra.ExtraMoney;
        }
        public override int GetWeigth()
        {
            return hotdog.GetWeigth() + extra.ExtraWeight;
        }
    }
}