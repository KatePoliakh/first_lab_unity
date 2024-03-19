namespace _Source.Core{
    
    using UnityEngine;

    public class GameManager : MonoBehaviour
    {
        public ResourceBank ResourceBank { get; private set; }
        

        private void Awake()
        {
            ResourceBank = new ResourceBank();
            InitializeStartingResources();
        }

        private void InitializeStartingResources()
        {
            
            ResourceBank.ChangeResource(GameResource.Humans, 10);
            ResourceBank.ChangeResource(GameResource.Food, 5);
            ResourceBank.ChangeResource(GameResource.Wood, 5);
        }
    }

    
}
