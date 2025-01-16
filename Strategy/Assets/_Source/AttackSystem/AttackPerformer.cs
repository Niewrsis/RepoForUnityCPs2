namespace AttackSystem
{
    public class AttackPerformer
    {
        private ButtonHolder _buttonHolder;

        private IAttackStrategy _firstStrategy;
        private IAttackStrategy _secondStrategy;
        private IAttackStrategy _thirdStrategy;

        private CharacterContext _character;

        public AttackPerformer(CharacterContext character, ButtonHolder buttonHolder)
        {
            _character = character;
            _buttonHolder = buttonHolder;

            Init();
        }
        private void Init()
        {
            InitStrategies();
            InitButtons();
            SelectFirst();
        }
        private void InitStrategies()
        {
            _firstStrategy = AttackStrategyFactory.CreateFirstStrategy();
            _secondStrategy = AttackStrategyFactory.CreateSecondStrategy();
            _thirdStrategy = AttackStrategyFactory.CreateThirdStrategy();
        }
        private void InitButtons()
        {
            _buttonHolder.FirstButton.onClick.AddListener(SelectFirst);
            _buttonHolder.SecondButton.onClick.AddListener(SelectSecond);
            _buttonHolder.ThirdButton.onClick.AddListener(SelectThird);
        }
        private void SelectFirst() => _character.SetStrategy(_firstStrategy);
        private void SelectSecond() => _character.SetStrategy(_secondStrategy);
        private void SelectThird() => _character.SetStrategy(_thirdStrategy);
    }
}