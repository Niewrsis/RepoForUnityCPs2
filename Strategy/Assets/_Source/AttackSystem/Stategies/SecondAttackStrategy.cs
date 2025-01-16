using Core;
using UnityEngine;

namespace AttackSystem.Strategies
{
    public class SecondAttackStrategy : IAttackStrategy
    {
        public void PerformAttack(Animator animator)
        {
            animator.SetTrigger(GlobalKeys.SECOND_ATTACK_TRIGGER);
        }
    }
}