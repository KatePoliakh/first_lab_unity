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
                {GameResource.Gold, new ObservableInt(0)}
            };
            

        private void Awake()
        {
            InitializeResources();
        }

        private void InitializeResources()
        {
            foreach (GameResource resource in System.Enum.GetValues(typeof(GameResource)))
            {
                ResourceDictionary.Add(resource, new ObservableInt(0));
            }
        }

        public void ChangeResource(GameResource resource, int value)
        {
            ResourceDictionary[resource].Value += value;
        }

        public ObservableInt GetResource(GameResource resource)
        {
            return ResourceDictionary[resource];
        }
    }

}
