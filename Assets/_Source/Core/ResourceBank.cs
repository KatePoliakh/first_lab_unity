using System.Collections.Generic;
using UnityEngine;

namespace _Source.Core{
    public class ResourceBank : MonoBehaviour
    {
        private Dictionary<GameResource, ObservableInt> ResourceDictionary { get; } =
            new Dictionary<GameResource, ObservableInt>()
            {
                {GameResource.Humans, new ObservableInt(0)},
                {GameResource.Food, new ObservableInt(0)},
                {GameResource.Wood, new ObservableInt(0)},
                {GameResource.Stone, new ObservableInt(0)},
                {GameResource.Gold, new ObservableInt(0)},
                {GameResource.HumansProdLvl, new ObservableInt(1)},
                {GameResource.FoodProdLvl, new ObservableInt(1)},
                {GameResource.WoodProdLvl, new ObservableInt(1)},
                {GameResource.StoneProdLvl, new ObservableInt(1)},
                {GameResource.GoldProdLvl, new ObservableInt(1)}
            };

        public void ChangeResource(GameResource resource, int value)
        {
            if (!ResourceDictionary.ContainsKey(resource))
            {
                ResourceDictionary[resource] = new ObservableInt(0);
            }
            ResourceDictionary[resource].Value += value;
        }

        public ObservableInt GetResource(GameResource resource)
        {
            return ResourceDictionary[resource];
        }
        public ObservableInt GetResourceLevel(GameResource resource)
        {
            return ResourceDictionary[resource];
        }
        public void ChangeResourceLevel(GameResource resource, int value)
        {
            ResourceDictionary[resource].Value += value;
        }
    }

}
