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

        private void Awake()
        {
            _attackPerformer = new AttackPerformer(character, buttonHolder);

            inputListener.Construct(character);
        }
    }
}