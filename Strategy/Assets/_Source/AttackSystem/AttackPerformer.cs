namespace AttackSystem
{
    public class AttackPerformer
    {
        private ButtonHolder _buttonHolder;

        private IAttackStrategy _firstStrategy;
        private IAttackStrategy _secondStrategy;
        private IAttackStrategy _thirdStrategy;

        private CharacterContext _character;

        public AttackPerformer(CharacterContext character, ButtonHolder buttonHolder, IAttackStrategy firstStrategy, IAttackStrategy secondStrategy, IAttackStrategy thirdStrategy)
        {
            _character = character;
            _buttonHolder = buttonHolder;

            _firstStrategy = firstStrategy;
            _secondStrategy = secondStrategy;
            _thirdStrategy = thirdStrategy;

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
        private void SelectFirst() => _character.SetStrategy(_firstStrategy);
        private void SelectSecond() => _character.SetStrategy(_secondStrategy);
        private void SelectThird() => _character.SetStrategy(_thirdStrategy);
    }
}