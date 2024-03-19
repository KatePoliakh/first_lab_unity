using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace _Source.Core{
    
    public class ResourceVisual : MonoBehaviour
    {
        [SerializeField] private GameResource resourceType;
        [SerializeField] private Text textComponent;
        [SerializeField] private ResourceBank resourceBank;

        private void Start()
        {
            textComponent.text = resourceBank.GetResource(resourceType).Value.ToString();
        }

        private void Update()
        {
            textComponent.text = resourceBank.GetResource(resourceType).Value.ToString();
        }

        private void UpdateResourceVisual()
        {
            textComponent.text = resourceType.ToString() + ": " + resourceBank.GetResource(resourceType).Value.ToString();
        }
    }

    
}
