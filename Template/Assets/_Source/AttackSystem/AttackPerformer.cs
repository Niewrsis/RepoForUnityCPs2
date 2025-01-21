using EnemySystem;

namespace AttackSystem
{
    public class AttackPerformer
    {
        private ButtonHolder _buttonHolder;

        private IAttackStrategy _firstStrategy;
        private IAttackStrategy _secondStrategy;
        private IAttackStrategy _thirdStrategy;

        private CharacterContext _character;

        private EnemyManager _enemyManager;

        public AttackPerformer(CharacterContext character, ButtonHolder buttonHolder, IAttackStrategy firstStrategy, IAttackStrategy secondStrategy, IAttackStrategy thirdStrategy, EnemyManager enemyManager)
        {
            _character = character;
            _buttonHolder = buttonHolder;

            _firstStrategy = firstStrategy;
            _secondStrategy = secondStrategy;
            _thirdStrategy = thirdStrategy;

            _enemyManager = enemyManager;

            Init();
        }
        private void Init()
        {
            InitButtons();
            SelectFirst();
        }
        private void InitButtons()
        {
            _buttonHolder.FirstButton.onClick.AddListener(SelectFirst);
            _buttonHolder.SecondButton.onClick.AddListener(SelectSecond);
            _buttonHolder.ThirdButton.onClick.AddListener(SelectThird);
        }
        private void SelectFirst()
        {
            _character.SetStrategy(_firstStrategy);
            _enemyManager.SpawnEnemy1();
        }
        private void SelectSecond()
        {
            _character.SetStrategy(_secondStrategy);
            _enemyManager.SpawnEnemy2();
        }
        private void SelectThird()
        {
            _character.SetStrategy(_thirdStrategy);
            _enemyManager.SpawnEnemy3();
        }
    }
}