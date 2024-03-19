using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _Source.Core{
    public class ResourceBank : MonoBehaviour
    {
        private Dictionary<GameResource, ObservableInt> resourceDictionary = new Dictionary<GameResource, ObservableInt>();

        private void Awake()
        {
            InitializeResources();
        }

        private void InitializeResources()
        {
            foreach (GameResource resource in System.Enum.GetValues(typeof(GameResource)))
            {
                resourceDictionary.Add(resource, new ObservableInt());
            }
        }

        public void ChangeResource(GameResource resource, int value)
        {
            resourceDictionary[resource].Value += value;
        }

        public ObservableInt GetResource(GameResource resource)
        {
            return resourceDictionary[resource];
        }
    }

}
