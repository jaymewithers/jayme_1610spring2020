using UnityEngine;

namespace AtHomePractice
{
    public class Loops : MonoBehaviour
    {
        public int cupsInTheSink = 4;
        
        void Start()
        {
            while (cupsInTheSink > 0)
            {
                Debug.Log("I've washed a cup!");
                cupsInTheSink--;
            }

            bool shouldContinue = false;

            do
            {
              print("Hello World");  
              
            } while (shouldContinue == true);
            
            string[] strings = new string[3];

            strings[0] = "First string";
            strings[1] = "Second string";
            strings[2] = "Third string";

            foreach (string item in strings)
            {
                print(item);
            }
        }
    }
}

// unity tutorial - loops