using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Color;

namespace AtHomePractice
{
    [RequireComponent(typeof(Dropdown))]
    public class DropdownControl : MonoBehaviour
    {
        private Dropdown controller;
        
        void Start()
        {
            controller = GetComponent<Dropdown>();
            controller.options.Add(new Dropdown.OptionData("Hello"));
            controller.options.Remove(new Dropdown.OptionData("Option A"));
            controller.options.Remove(new Dropdown.OptionData("Option B"));
            controller.options.Remove(new Dropdown.OptionData("Option C"));
            controller.name = "Dialogue";
        }

        
        void Update()
        {
            if (Input.GetKey(KeyCode.Space))
            {
                controller.options.Add(new Dropdown.OptionData("Reach for the sky!"));
            }
        }
    }
}