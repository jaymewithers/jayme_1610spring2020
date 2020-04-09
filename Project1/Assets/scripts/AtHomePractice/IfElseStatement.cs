using UnityEngine;
using UnityEngine.UI;

    [RequireComponent(typeof(Text))]
    public class IfElseStatement : MonoBehaviour
    {
        private Text textObj;
        public int levelOne = 0;
        public int levelTwo = 1;
        public int levelThree = 2;
        public int currentLevel;

        void Start()
        {
            textObj = GetComponent<Text>();
            currentLevel = levelOne;
        }

        
        void Update()
        {
            if (currentLevel == levelOne)
            {
                textObj.text = "Level One";
            }
            else if (currentLevel == levelTwo)
            {
                textObj.text = "Level Two";
            }
            else if (currentLevel == levelThree)
            {
                textObj.text = "Level Three";
            }
            else
            {
                textObj.text = "Invalid";
            }
        }
    }