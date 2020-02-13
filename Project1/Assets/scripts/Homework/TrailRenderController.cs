using System;
using UnityEngine;

namespace Homework
{
    [RequireComponent(typeof(TrailRenderer))]
    public class TrailRenderController : MonoBehaviour
    {
        private TrailRenderer trailRenderControl;
        public Material trailRenderMaterial;
        
        void Start()
        {
            trailRenderControl = GetComponent<TrailRenderer>();
            trailRenderControl.time = 2f;
            trailRenderControl.endWidth = 0.1f;
            trailRenderControl.startWidth = 1f;
            trailRenderMaterial.color = Color.green;
        }

        private void Update()
        {
            if (Input.GetKey(KeyCode.B))
            {
                trailRenderMaterial.color = Color.blue;
            }
        }
    }
}