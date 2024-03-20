
using _Source.Core;
using TMPro;
using UnityEngine;

namespace _Source.Presentation{
    
    public class ResourceVisualUpgLvl : MonoBehaviour
    {
        [SerializeField]
        private GameManager gameManager;

        [SerializeField]
        private GameResource resource;
        
        private void Start()
        {
            var bank = gameManager.ResourceBank;
            
            bank.GetResource(resource).OnValueChanged = value =>
                GetComponent<TMP_Text>().text = $"{value}";

            bank.ChangeResourceLevel(resource, 0);
        }
        
    }
    
}
