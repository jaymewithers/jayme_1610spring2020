using System;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

namespace Homework
{
    [RequireComponent(typeof(Image))]
    public class ImageController : MonoBehaviour
    {
        private Image imageControl;
        public Material imageMaterial;
        
        void Start()
        {
            imageControl = GetComponent<Image>();
            imageMaterial.color = Color.red;
        }

        private void OnEnable()
        {
            print("There is an image.");
        }

        private void OnDisable()
        {
            print("No image.");
        }
    }
}