using System.Collections.Generic;

namespace _Source.Core{
    
    using UnityEngine;

    public class GameManager : MonoBehaviour
    {
        public ResourceBank ResourceBank { get; private set; }
        
        public Dictionary<GameResource, ObservableInt> ResourceProductionLevels { get; private set; }


        private void Awake()
        {
            ResourceBank = new ResourceBank();
            ResourceBank.ChangeResource(GameResource.Humans, 10);
            ResourceBank.ChangeResource(GameResource.Food, 5);
            ResourceBank.ChangeResource(GameResource.Wood, 5);
            
            ResourceProductionLevels = new Dictionary<GameResource, ObservableInt>()
            {
                {GameResource.HumansProdLvl, new ObservableInt(1)},
                {GameResource.FoodProdLvl, new ObservableInt(1)},
                {GameResource.WoodProdLvl, new ObservableInt(1)},
                {GameResource.StoneProdLvl, new ObservableInt(1)},
                {GameResource.GoldProdLvl, new ObservableInt(1)}
            };
        }
    }

    
}
