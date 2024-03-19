using System.Collections.Generic;
using UnityEngine;

namespace _Source.Core{
    public class ResourceBank : MonoBehaviour
    {
        private Dictionary<GameResource, ObservableInt> ResourceDictionary { get; } =
            new Dictionary<GameResource, ObservableInt>();

        private void Awake()
        {
            InitializeResources();
        }

        private void InitializeResources()
        {
            foreach (GameResource resource in System.Enum.GetValues(typeof(GameResource)))
            {
                ResourceDictionary.Add(resource, new ObservableInt());
            }
        }

        public void ChangeResource(GameResource resource, int value)
        {
            if (!ResourceDictionary.ContainsKey(resource))
            {
                ResourceDictionary[resource] = new ObservableInt();
            }
            ResourceDictionary[resource].Value += value;
        }

        public ObservableInt GetResource(GameResource resource)
        {
            return ResourceDictionary[resource];
        }
    }

}
