

namespace _Source.Core
{
    using System.Collections;
    using UnityEngine;
    using UnityEngine.UI;

    public class ProductionBuilding : MonoBehaviour {
        [SerializeField]
        public GameResource resourceType;
        [SerializeField]
        public GameObject gameManagerObj;

        [SerializeField] public float productionTime;
        public Button button;
        public Slider slider;
        private ResourceBank _resourceBank;
        private GameManager _gameManager;

        

        void Start() {
            _gameManager = gameManagerObj.GetComponent<GameManager>();
            _resourceBank = _gameManager.ResourceBank;
            button = GetComponent<Button>();
            button.onClick.AddListener(StartProduction);
            slider = GetComponentInChildren<Slider>();
            slider.gameObject.SetActive(false);
        }

        public void StartProduction() {
            button.interactable = false;
            slider.gameObject.SetActive(true);
            StartCoroutine(ProduceResource());
        }

        IEnumerator ProduceResource() {
            productionTime *= 1- _resourceBank.GetResource(resourceType).Value / 100f;  
            float timer = 0f;
            while (timer < productionTime) {
                timer += Time.deltaTime;
                slider.value = timer / productionTime;
                yield return null;
            }
            button.interactable = true;
            slider.gameObject.SetActive(false);
            ResourceBank resourceBank = _gameManager.ResourceBank;
            if (resourceBank != null) {
                resourceBank.ChangeResource(resourceType, 1);
            }
        }
    }

}

