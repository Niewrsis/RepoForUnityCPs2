using UnityEngine;

namespace UI
{
    public class SetActiveGameObjects : MonoBehaviour
    {
        [SerializeField] private SetActiveSlot[] gameObjects;

        private void Awake()
        {
            foreach(SetActiveSlot gameObject in gameObjects)
            {
                gameObject.GameObject.SetActive(gameObject.SetActive);
            }
        }
    }
}