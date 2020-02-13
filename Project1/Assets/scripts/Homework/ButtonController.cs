using UnityEngine;
using UnityEngine.UI;

namespace Homework
{
    [RequireComponent(typeof(Button))]
    public class ButtonController : MonoBehaviour
    {
        private Button buttonObj;

        void Start()
        {
            buttonObj = GetComponent<Button>();
        }

        private void OnEnable()
        {
            print("Click the button!");
        }

        private void OnDisable()
        {
            print("No button pressing for you.");
        }
    }
}