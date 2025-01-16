using UnityEngine;

namespace AttackSystem.Strategies
{
    public class ThirdAttackStrategy : IAttackStrategy
    {
        public void PerformAttack(Animator animator)
        {
            animator.SetTrigger(GlobalKeys.THIRD_ATTACK_TRIGGER);
        }
    }
}