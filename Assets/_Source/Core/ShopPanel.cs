using UnityEngine;
using UnityEngine.UI;

namespace _Source.Core
{
    public class ShopPanel : MonoBehaviour
    {
        public Button exitButton;
        [SerializeField]
        public GameObject shopPanel;

        public Button openShopButton;

        void Start()
        {
            openShopButton = GetComponent<Button>();
            openShopButton.onClick.AddListener(OpenShop);
            exitButton.onClick.AddListener(CloseShop);
            shopPanel.SetActive(false);
        }

        private void OpenShop()
        {
            shopPanel.SetActive(!shopPanel.activeSelf);   
        }

        private void CloseShop()
        {
            shopPanel.SetActive(false);
        }
    }
}