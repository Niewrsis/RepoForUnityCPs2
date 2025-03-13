using ResourceSystem;
using UI;
using UnityEngine;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        public ResourceSlot Pancakes;
        public ResourceSlot Guts;
        public ResourceSlot Skulls;

        [SerializeField] private FillDropdown AddDropdown;
        [SerializeField] private FillDropdown RemoveDropdown;

        private void Awake()
        {
            CreateResources();
            ResourcesUI();
        }
        private void CreateResources()
        {
            Pancakes = new();
            Guts = new();
            Skulls = new();

            Pancakes.Resource = Resource.Pancakes;
            Guts.Resource = Resource.Guts;
            Skulls.Resource = Resource.Skull;

            Pancakes.Count = 0;
            Guts.Count = 0;
            Skulls.Count = 0;
        }
        private void ResourcesUI()
        {
            AddDropdown.Construct(Pancakes, Guts, Skulls);
            RemoveDropdown.Construct(Pancakes, Guts, Skulls);
        }
    }
}