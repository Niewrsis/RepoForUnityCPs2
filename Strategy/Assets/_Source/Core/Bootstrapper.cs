using AttackSystem;
using InputSystem;
using UnityEngine;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private InputListener inputListener;
        [SerializeField] private ButtonHolder buttonHolder;
        [SerializeField] private CharacterContext character;

        private AttackPerformer _attackPerformer;

        private IAttackStrategy _firstStrategy, _secondStrategy,_thirdStrategy;

        private void Awake()
        {
            InitStrategies();

            _attackPerformer = new AttackPerformer(character, buttonHolder, _firstStrategy, _secondStrategy, _thirdStrategy);

            inputListener.Construct(character);
        }
        private void InitStrategies()
        {
            _firstStrategy = AttackStrategyFactory.CreateFirstStrategy();
            _secondStrategy = AttackStrategyFactory.CreateSecondStrategy();
            _thirdStrategy = AttackStrategyFactory.CreateThirdStrategy();
        }
    }
}