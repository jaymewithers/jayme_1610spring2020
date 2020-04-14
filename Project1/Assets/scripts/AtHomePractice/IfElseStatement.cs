using UnityEngine;

public class IfElseStatement : MonoBehaviour
    {
        public int levelOne = 0;
        public int levelTwo = 1;
        public int levelThree = 2;
        public int currentLevel;

        void Start()
        {
            currentLevel = levelOne;
        }

        
        void Update()
        {
            if (currentLevel == levelOne)
            {
                print("Level One");
            }
            else if (currentLevel == levelTwo)
            {
                print("Level Two");
            }
            else if (currentLevel == levelThree)
            {
                print("Level Three");
            }
            else
            {
                print("Invalid");
            }
        }
    }