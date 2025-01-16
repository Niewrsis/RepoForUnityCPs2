using UnityEngine;

namespace AttackSystem.Strategies
{
    public class FirstAttackStrategy : IAttackStrategy
    {
        public void PerformAttack(Animator animator)
        {
            animator.SetTrigger(GlobalKeys.FIRST_ATTACK_TRIGGER);
        }
    }
}