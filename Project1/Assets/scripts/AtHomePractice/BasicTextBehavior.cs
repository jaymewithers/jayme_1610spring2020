using UnityEngine;
using UnityEngine.UI;

namespace AtHomePractice
{
    [RequireComponent(typeof(Text))]
    public class BasicTextBehavior : MonoBehaviour
    {
        private Text textObj;
        public IntData dataObj;

        void Start()
        {
            textObj = GetComponent<Text>();
        }

        private void Update()
        {
            textObj.text = dataObj.value.ToString();
        }
    }
}