using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class MainScreenButtons : MonoBehaviour
    {
        [Header("Buttons")]
        [SerializeField] private Button mainMenuButton;
        [SerializeField] private Button addMenuButton;
        [SerializeField] private Button removeMenuButton;

        [Header("Menus")]
        [SerializeField] private GameObject mainMenu;
        [SerializeField] private GameObject addMenu;
        [SerializeField] private GameObject removeMenu;

        private bool _isActiveMainMenu;
        private bool _isActiveAddMenu;
        private bool _isActiveRemoveMenu;

        private void Start()
        {
            _isActiveMainMenu = false;
            _isActiveAddMenu = false;
            _isActiveRemoveMenu = false;

            mainMenuButton.onClick.AddListener(PressedMainMenuButton);
            addMenuButton.onClick.AddListener(PressedAddMenuButton);
            removeMenuButton.onClick.AddListener(PressedRemoveMenuButton);
        }
        private void PressedMainMenuButton()
        {
            _isActiveAddMenu = false;
            _isActiveRemoveMenu = false;

            addMenu.SetActive(_isActiveAddMenu);
            removeMenu.SetActive(_isActiveRemoveMenu);

            mainMenu.SetActive(!_isActiveMainMenu);

            _isActiveMainMenu = !_isActiveMainMenu;
        }
        private void PressedAddMenuButton()
        {
            _isActiveMainMenu = false;
            _isActiveRemoveMenu = false;

            mainMenu.SetActive(_isActiveMainMenu);
            removeMenu.SetActive(_isActiveRemoveMenu);

            addMenu.SetActive(!_isActiveAddMenu);

            _isActiveAddMenu = !_isActiveAddMenu;
        }
        private void PressedRemoveMenuButton()
        {
            _isActiveAddMenu = false;
            _isActiveMainMenu = false;

            addMenu.SetActive(_isActiveAddMenu);
            mainMenu.SetActive(_isActiveMainMenu);

            removeMenu.SetActive(!_isActiveRemoveMenu);

            _isActiveRemoveMenu = !_isActiveRemoveMenu;
        }
    }
}