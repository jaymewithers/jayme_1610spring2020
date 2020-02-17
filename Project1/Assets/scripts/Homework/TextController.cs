using UnityEngine;
using UnityEngine.UI;

namespace Homework
{
    [RequireComponent(typeof(Text))]
    public class TextController : MonoBehaviour
    {
        private Text textControl;

        void Start()
        {
            textControl = GetComponent<Text>();
            textControl.alignment = TextAnchor.MiddleCenter;
            textControl.color = Color.green;
            textControl.text = "Hello";
        }

        private void Update()
        {
            if (Input.GetKey(KeyCode.W))
            {
                textControl.text = "Welcome!";
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                textControl.text = "Run, run, run!";
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                textControl.text = "Go, go, go!";
            }

            if (Input.GetKey(KeyCode.Space))
            {
                textControl.text = "Jump!";
            }
        }
    }
}