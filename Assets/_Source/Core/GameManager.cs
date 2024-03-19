using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _Source.Core{
    
    using UnityEngine;

    public class GameManager : MonoBehaviour
    {
        [SerializeField] private ResourceBank resourceBank;

        private void Awake()
        {
            InitializeStartingResources();
        }

        private void InitializeStartingResources()
        {
            resourceBank.ChangeResource(GameResource.Humans, 10);
            resourceBank.ChangeResource(GameResource.Food, 5);
            resourceBank.ChangeResource(GameResource.Wood, 5);
        }
    }

    
}
