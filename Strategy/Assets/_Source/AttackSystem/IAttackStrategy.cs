using UnityEngine;

namespace AttackSystem
{
    public interface IAttackStrategy
    {
        void PerformAttack(Animator animator);
    }
}