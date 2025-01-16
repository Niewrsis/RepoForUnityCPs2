using AttackSystem;
using UnityEngine;

namespace InputSystem
{
    public class InputListener : MonoBehaviour
    {
        private CharacterContext _charecter;

        public void Construct(CharacterContext character)
        {
            _charecter = character;
        }
        private void Update()
        {
            ReadAttackInput();
        }
        private void ReadAttackInput()
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                _charecter.PerformAttack();
            }
        }
    }
}