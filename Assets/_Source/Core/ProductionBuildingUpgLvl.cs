using UnityEngine;
using UnityEngine.UI;

namespace _Source.Core
{
    public class ProductionBuildingUpgLvl : MonoBehaviour
    {
        [SerializeField]
        private GameResource gameResource;
        
        [SerializeField]
        private GameManager gameManager;
    
        private Button _button;
        private ResourceBank _resourceBank;

        public void Start()
        {
            _resourceBank = gameManager.ResourceBank;
            _button = GetComponent<Button>();
            _button.onClick.AddListener(OnClick);
        }
    
        private void OnClick()
        {
            _resourceBank.ChangeResourceLevel(gameResource, 1);
        }
    }
}