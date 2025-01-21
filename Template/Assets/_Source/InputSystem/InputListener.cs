using Core;
using UnityEngine;

namespace InputSystem
{
    public class InputListener : MonoBehaviour
    {
        private EventManager _eventManager;

        public void Construct(EventManager eventManager)
        {
            _eventManager = eventManager;
        }
        private void Update()
        {
            ReadAttackInput();
        }
        private void ReadAttackInput()
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                _eventManager.OnAttack?.Invoke();
            }
        }
    }
}