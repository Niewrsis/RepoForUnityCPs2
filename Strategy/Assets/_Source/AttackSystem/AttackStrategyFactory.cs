using AttackSystem;
using AttackSystem.Strategies;

public static class AttackStrategyFactory
{
    public static IAttackStrategy CreateFirstStrategy() => new FirstAttackStrategy();
    public static IAttackStrategy CreateSecondStrategy() => new SecondAttackStrategy();
    public static IAttackStrategy CreateThirdStrategy() => new ThirdAttackStrategy();
}
}
