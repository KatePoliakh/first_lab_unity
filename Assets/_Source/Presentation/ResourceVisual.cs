using UnityEngine;
using _Source.Core;
using TMPro;

namespace _Source.Presentation{
    
    public class ResourceVisual : MonoBehaviour
    {
        [SerializeField]
        private GameResource gameResource;
        
        [SerializeField]
        private GameManager gameManager;
        

        private void Start()
        {
            ResourceBank bank = gameManager.ResourceBank;

            bank.GetResource(gameResource).OnValueChanged = value =>
                GetComponent<TMP_Text>().text = $"{value}";
            
            bank.ChangeResource(gameResource, 0);
        }

        
    }

    
}
