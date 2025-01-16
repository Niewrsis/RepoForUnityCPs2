using UnityEngine;

namespace AttackSystem
{
    public class CharacterContext : MonoBehaviour
    {
        [SerializeField] private Animator animator;

        private IAttackStrategy _currentStrategy;

        public void SetStrategy(IAttackStrategy strategy)
        {
            _currentStrategy = strategy;
        }

        public void PerformAttack()
        {
            if (_currentStrategy != null)
            {
                _currentStrategy.PerformAttack(animator);
            }
        }

        public void AttackAnimationEnded()
        {
            animator.ResetTrigger(GlobalKeys.FIRST_ATTACK_TRIGGER);
            animator.ResetTrigger(GlobalKeys.SECOND_ATTACK_TRIGGER);
            animator.ResetTrigger(GlobalKeys.THIRD_ATTACK_TRIGGER);
        }
    }
}