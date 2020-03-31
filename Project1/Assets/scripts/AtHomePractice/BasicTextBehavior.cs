using UnityEngine;
using UnityEngine.UI;

namespace AtHomePractice
{
    [RequireComponent(typeof(Text))]
    public class BasicTextBehavior : MonoBehaviour
    {
        private Text textObj;

        void Start()
        {
            textObj = GetComponent<Text>();
        }
    }
}