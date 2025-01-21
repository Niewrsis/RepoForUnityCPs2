using AttackSystem;
using AttackSystem.Strategies;
using EnemySystem;
using EnemySystem.Enemies;
using InputSystem;
using UnityEngine;
using UnityEngine.TextCore.Text;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private InputListener inputListener;
        [SerializeField] private ButtonHolder buttonHolder;
        [SerializeField] private CharacterContext character;
        [SerializeField] private EnemyManager enemyManager;
        
        
        private EventManager eventManager;

        private AttackPerformer _attackPerformer;

        private IAttackStrategy _firstStrategy, _secondStrategy,_thirdStrategy;

        private Enemy1 _enemy1;
        private Enemy2 _enemy2;
        private Enemy3 _enemy3;

        private void Awake()
        {
            eventManager = new();

            InitEnemies();
            enemyManager.Construct(_enemy1, _enemy2, _enemy3, eventManager);

            InitStrategies();

            _attackPerformer = new AttackPerformer(character, buttonHolder, _firstStrategy, _secondStrategy, _thirdStrategy, enemyManager);

            inputListener.Construct(eventManager);

            eventManager.OnAttack += character.PerformAttack;
        }
        private void InitStrategies()
        {
            _firstStrategy = new FirstAttackStrategy();
            _secondStrategy = new SecondAttackStrategy();
            _thirdStrategy = new ThirdAttackStrategy();
        }
        private void InitEnemies()
        {
            _enemy1 = new Enemy1(enemyManager.TempEnemy1);
            _enemy2 = new Enemy2(enemyManager.TempEnemy2);
            _enemy3 = new Enemy3(enemyManager.TempEnemy3);
        }
    }
}